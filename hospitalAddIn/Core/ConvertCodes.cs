using hospitalAddIn.Forms;
using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;       //microsoft Excel 14 object in references-> COM tab

namespace hospitalAddIn
{
    internal class ConvertCodes
    {
        private ConvertCodesConfigModel config;
        private ConvertConfigForm form;
        public ConvertCodes(ConvertCodesConfigModel config)
        {
            this.config = config;
            form = new ConvertConfigForm();
            form.startConvertBtn.Click += Run;
        }

        public void Start() {
            // Pass Initial Config to Config Form
            form.icdCodesFilePath.Text = config.icdCodesFilePath;
            form.icdCodeColumn.Text = config.icdCodeColumn;
            form.icdTextColumn.Text = config.icdTextColumn;
            form.icdRowStart.Text = config.icdRowStart.ToString();
            form.icdRowEnd.Text = config.icdRowEnd.ToString();
            
            form.cptCodesFilePath.Text = config.cptCodesFilePath;
            form.cptCodeColumn.Text = config.cptCodeColumn;
            form.cptTextColumn.Text = config.cptTextColumn;
            form.cptRowStart.Text = config.cptRowStart.ToString();
            form.cptRowEnd.Text = config.cptRowEnd.ToString();
            form.ShowDialog();
        }

        public async void Run(object sender, EventArgs e) {
            // Disable Button
            form.startConvertBtn.Enabled = false;

            // Update config from Form
            config.icdCodesFilePath = form.icdCodesFilePath.Text;
            config.icdCodeColumn = form.icdCodeColumn.Text;
            config.icdTextColumn = form.icdTextColumn.Text;
            config.icdRowStart = int.Parse(form.icdRowStart.Text);
            config.icdRowEnd = int.Parse(form.icdRowEnd.Text);

            config.cptCodesFilePath = form.cptCodesFilePath.Text;
            config.cptCodeColumn = form.cptCodeColumn.Text;
            config.cptTextColumn = form.cptTextColumn.Text;
            config.cptRowStart = int.Parse(form.cptRowStart.Text);
            config.cptRowEnd = int.Parse(form.cptRowEnd.Text);

            // Check if Paths are Valid
            if (File.Exists(config.icdCodesFilePath) && File.Exists(config.cptCodesFilePath))
            {

                // Get ICD Codes
                form.startConvertBtn.Text = "Reading ICD Codes...";
                var icdLookupCode = await GetLookupCode(config.icdCodesFilePath);
                var codeRng = GetTargetRange(config.icdCodeColumn, config.icdRowStart, config.icdRowEnd);
                var rng = GetTargetRange(config.icdTextColumn, config.icdRowStart, config.icdRowEnd);
                // Change Range
                var activeSheet = Globals.ThisAddIn.Application.ActiveWorkbook.ActiveSheet;
                rng.NumberFormat = "General";
                var offSet = config.icdRowEnd - codeRng.Count;
                form.startConvertBtn.Text = "Processing ICD Codes...";
                form.Update();
                if (form.cbICDMultiple.Checked)
                {
                    for (var i = config.icdRowStart; i < config.icdRowEnd; i++)
                    {
                        form.startConvertBtn.Text = $"Processing ICD Codes ({i - offSet}/{codeRng.Count})";
                        form.Update();
                        string icdCode = codeRng[i - offSet].Text;
                        if (icdCode == "")
                        {
                            continue;
                        }
                        var targetCell = rng[i - offSet];
                        targetCell.Formula = "";
                        if (icdCode.Contains(","))
                        {
                            var splitCode = icdCode.Split(',');
                            splitCode.ToList().ForEach((code) =>
                            {
                                var formattedCode = FormatCode(code);
                                if (targetCell.Formula != "")
                                {
                                    targetCell.Formula = targetCell.Formula.Replace("=", "");
                                    targetCell.Formula = $"={targetCell.Formula}&\",\"&IFNA(VLOOKUP({formattedCode},{icdLookupCode},2,FALSE),\"NA\")";
                                }
                                else
                                {
                                    targetCell.Formula = $"=IFNA(VLOOKUP({formattedCode},{icdLookupCode},2,FALSE),\"NA\")";
                                }
                            });
                        }
                        else
                        {
                            targetCell.Formula = $"=IFNA(VLOOKUP({FormatCode(icdCode)},{icdLookupCode},2,FALSE),\"\")";
                        }
                    }
                }
                else
                {
                    rng.Value2 = $"=IFNA(VLOOKUP({config.icdCodeColumn}{config.icdRowStart},{icdLookupCode},2,FALSE),\"\")";
                }
                PasteValues(rng);

                // Get CPT Codes
                form.startConvertBtn.Text = "Reading CPT Codes...";
                var cptLookupCode = await GetLookupCode(config.cptCodesFilePath);
                codeRng = GetTargetRange(config.cptCodeColumn, config.cptRowStart, config.cptRowEnd);
                rng = GetTargetRange(config.cptTextColumn, config.cptRowStart, config.cptRowEnd);
                rng.NumberFormat = "General";
                offSet = config.cptRowEnd - codeRng.Count;
                form.startConvertBtn.Text = "Processing CPT Codes...";
                form.Update();
                if (form.cbCPTMultiple.Checked)
                {
                    for (var i = config.cptRowStart; i < config.cptRowEnd; i++)
                    {
                        form.startConvertBtn.Text = $"Processing CPT Codes ({i - offSet}/{codeRng.Count})";
                        form.Update();
                        string cptCode = codeRng[i - offSet].Text;
                        if (cptCode == "")
                        {
                            continue;
                        }
                        var targetCell = rng[i - offSet];
                        targetCell.Formula = "";
                        if (cptCode.Contains(","))
                        {
                            var splitCode = cptCode.Split(',');
                            splitCode.ToList().ForEach((code) =>
                            {
                                var formattedCode = FormatCode(code);
                                if (targetCell.Formula != "")
                                {
                                    targetCell.Formula = targetCell.Formula.Replace("=", "");
                                    targetCell.Formula = $"={targetCell.Formula}&\",\"&IFNA(VLOOKUP({formattedCode},{cptLookupCode},2,FALSE),\"NA\")";
                                }
                                else
                                {
                                    targetCell.Formula = $"=IFNA(VLOOKUP({formattedCode},{cptLookupCode},2,FALSE),\"NA\")";
                                }
                            });
                        }
                        else
                        {
                            targetCell.Formula = $"=IFNA(VLOOKUP({FormatCode(cptCode)},{cptLookupCode},2,FALSE),\"\")";
                        }
                    }
                }
                else
                {
                    rng.Value2 = $"=IFNA(VLOOKUP({config.cptCodeColumn}{config.cptRowStart},{cptLookupCode},2,FALSE),\"\")";
                }
                PasteValues(rng);

                Config.saveConvertCodesConfig(config);
                form.Close();
                MessageBox.Show("Done");
            }
            else {
                MessageBox.Show("Invalid Code File Path");
            }

            form.startConvertBtn.Text = "CONVERT CODES";
            form.startConvertBtn.Enabled = true;
            
        }

        private Task<string> GetLookupCode(string excelFilePath) {
            string result = "";

            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(excelFilePath);
            Excel._Worksheet xlWorksheet = xlWorkbook.Worksheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            var workbookName = xlWorkbook.Name;
            var sheetName = xlWorksheet.Name;

            result = excelFilePath.Replace(workbookName, $"[{workbookName}]");

            //= VLOOKUP([@[ICD10 Diagnosis Code 1]],'[Tons of ICD 10 codes.xlsx]Sheet1'!$A$1:$B$37659,2,FALSE)

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            result = $"'{result}{sheetName}'!$A$1:$B${rowCount}";

            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);

            return Task.FromResult(result);
        }

        private Excel.Range GetTargetRange(string column, int start, int end) {
            var sheet = Globals.ThisAddIn.Application.ActiveWorkbook.ActiveSheet;
            var columnIndex = ColumnLetterToColumnIndex(column);
            Excel.Range rng = (Excel.Range)sheet.Range(
                sheet.Cells[start, columnIndex],
                sheet.Cells[end, columnIndex]
            );

            return rng;
        }

        private void PasteValues(Excel.Range range) {
            range.Select();
            try
            {
                Globals.ThisAddIn.Application.Selection.Copy();
                Globals.ThisAddIn.Application.Selection.PasteSpecial(Excel.XlPasteType.xlPasteValues);
            }
            catch { 
                // Do Nothing
            }
        }

        private int ColumnLetterToColumnIndex(string columnLetter)
        {
            columnLetter = columnLetter.ToUpper();
            int sum = 0;

            for (int i = 0; i < columnLetter.Length; i++)
            {
                sum *= 26;
                sum += (columnLetter[i] - 'A' + 1);
            }
            return sum;
        }

        private string FormatCode(string code) {
            var formattedCode = code;
            var numberedCode = 0;
            int.TryParse(code, out numberedCode);
            if (numberedCode == 0)
            {
                formattedCode = $"\"{code.Replace(" ", "")}\"";
            }
            return formattedCode;
        }
    }
}
