using hospitalAddIn.Forms;
using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;       //microsoft Excel 14 object in references-> COM tab

namespace hospitalAddIn
{
    internal class HighlightKeywords
    {
        private HighlightKeywordsConfigModel config;
        private HighlightConfigForm form;
        public HighlightKeywords(HighlightKeywordsConfigModel config)
        {
            this.config = config;
            form = new HighlightConfigForm();
            form.startHighlightBtn.Click += Run;
        }
        public void Start() {
            form.keywordsFilePath.Text = config.keywordsFilePath;
            form.ShowDialog();
        }

        public async void Run(object sender, EventArgs e) {
            // Disable Button
            form.startHighlightBtn.Enabled = false;

            // Update config from Form
            config.keywordsFilePath = form.keywordsFilePath.Text;

            // Check if Paths are Valid
            if (File.Exists(config.keywordsFilePath))
            {
                // Get Keywords
                var keywordsList = await GetKeywordValues(config.keywordsFilePath);

                foreach (var keyword in keywordsList) {
                    FindKeywordSetColor(
                        keyword.Key, 
                        keyword.Value
                    );
                }

                Config.saveHighlightKeywordsConfig(config);
                form.Close();
                MessageBox.Show("Done");
            }
            else {
                MessageBox.Show("Invalid File Path");
            }

            form.startHighlightBtn.Enabled = true;
        }

        private void FindKeywordSetColor(
            string keyword, 
            KeywordHighlightModel settings
            ) {
            var sheet = Globals.ThisAddIn.Application.ActiveWorkbook.ActiveSheet;
            Excel.Range xlRange = sheet.UsedRange;
            Excel.Range currentFind = null;
            Excel.Range firstFind = null;

            currentFind = xlRange.Find(keyword, Type.Missing,
                Excel.XlFindLookIn.xlValues, Excel.XlLookAt.xlPart,
                Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlNext, false,
                Type.Missing, Type.Missing);

            while (currentFind != null)
            {
                // Keep track of the first range you find. 
                if (firstFind == null)
                {
                    firstFind = currentFind;
                }

                // If you didn't move to a new range, you are done.
                else if (currentFind.get_Address(Excel.XlReferenceStyle.xlA1)
                      == firstFind.get_Address(Excel.XlReferenceStyle.xlA1))
                {
                    break;
                }

                currentFind.Interior.Color = settings.color;
                currentFind.Font.Color = settings.fontColor;
                currentFind.Font.Size = settings.fontSize;
                currentFind.Font.Bold = settings.isBold;
                currentFind.Font.Italic = settings.isItalic;
                currentFind.Font.Underline = settings.isUnderline;

                currentFind = xlRange.FindNext(currentFind);
            }
        }

        private Task<List<KeyValuePair<string,KeywordHighlightModel>>> GetKeywordValues(string excelFilePath)
        {
            var result = new List<KeyValuePair<string, KeywordHighlightModel>>();

            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(excelFilePath);
            Excel._Worksheet xlWorksheet = xlWorkbook.Worksheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            // Get Keywords and Colors
            for (int i = 2; i <= rowCount; i++) {
                KeywordHighlightModel keywordHighlightModel = new KeywordHighlightModel();
                keywordHighlightModel.color = xlRange.Cells[i, 2].Interior.Color.ToString();
                keywordHighlightModel.fontColor = xlRange.Cells[i, 2].Font.Color.ToString();
                keywordHighlightModel.fontSize = xlRange.Cells[i, 2].Font.Size;
                keywordHighlightModel.isBold = xlRange.Cells[i, 2].Font.Bold;
                keywordHighlightModel.isItalic = xlRange.Cells[i, 2].Font.Italic;
                keywordHighlightModel.isUnderline = xlRange.Cells[i, 2].Font.Underline;

                result.Add(new KeyValuePair<string, KeywordHighlightModel>(
                    xlRange.Cells[i, 1].Value2.ToString(),
                    keywordHighlightModel
                ));
            }

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
    }
}
