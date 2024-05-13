using hospitalAddIn.Forms;
using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Linq;       //microsoft Excel 14 object in references-> COM tab

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
                var Task1 = GetKeywordValues(config.keywordsFilePath);

                // Prepare Raw Range
                var Task2 = Task.Run(PrepareRawRangeModel);

                await Task.WhenAll(Task1,Task2);

                var keywordsList = Task1.Result;
                var rawRange = Task2.Result;

                var itemsToHighlight = new List<HighlightKeywordItem>();

                foreach (var keyword in keywordsList) {
                    var itemsFound = FindKeywordSetColorV2(
                        keyword.Key, 
                        keyword.Value,
                        rawRange
                    );

                    itemsToHighlight.AddRange(itemsFound);
                }

                // Highlight Items
                highlightItems(itemsToHighlight);

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

        private List<HighlightKeywordItem> FindKeywordSetColorV2(
            string keyword,
            KeywordHighlightModel settings,
            List<RawRangeModel> rawRangeModel = null)
        {
            var result = new List<HighlightKeywordItem>();

            if (rawRangeModel == null)
            {
                return result;
            }

            // Find for Rows that has Highlight Text
            var rowMatch = rawRangeModel.FindAll(x => x.concatenatedRow.Contains(keyword.ToLower()));

            foreach (var row in rowMatch)
            {

                // Check if what column 
                for (var c = 0; c < row.columns.Length; c++)
                {
                    var column = row.columns[c];
                    if (column == null)
                    {
                        continue;
                    }
                    // Check if Direct Column Match
                    if (column.ToString().ToLower().Contains(keyword.ToLower()))
                    {
                        HighlightKeywordItem item = new HighlightKeywordItem();
                        item.row = row.rowNum;
                        item.column = row.startColumn + c;
                        item.hightlightSettings = settings;
                        result.Add(item);
                    }
                }
            }
            return result;
        }

        private void highlightItems(List<HighlightKeywordItem> items)
        {
            var sheet = Globals.ThisAddIn.Application.ActiveWorkbook.ActiveSheet;
            Excel.Range xlRange = sheet.UsedRange;
            var startRow = xlRange.Row;
            var startColumn = xlRange.Column;

            foreach (var item in items)
            {
                var cell = xlRange.Cells[item.row + 1 - startRow, item.column + 1 - startColumn];
                cell.Interior.Color = item.hightlightSettings.color;
                cell.Font.Color = item.hightlightSettings.fontColor;
                cell.Font.Size = item.hightlightSettings.fontSize;
                cell.Font.Bold = item.hightlightSettings.isBold;
                cell.Font.Italic = item.hightlightSettings.isItalic;
                cell.Font.Underline = item.hightlightSettings.isUnderline;
            }
        }

        private List<RawRangeModel> PrepareRawRangeModel()
        {
            var sheet = Globals.ThisAddIn.Application.ActiveWorkbook.ActiveSheet;
            var result = new List<RawRangeModel>();
            Excel.Range xlRange = sheet.UsedRange;
            var rawRange = xlRange.Value2;

            var startRow = xlRange.Row;
            var startColumn = xlRange.Column;

            var rowCount = rawRange.GetLength(0);
            var columnCount = rawRange.GetLength(1);

            for(int i = 1; i < rowCount; i++ )
            {
                RawRangeModel row = new RawRangeModel();
                row.rowNum = startRow - 1 + i;
                row.startColumn = startColumn;
                row.columns = new object[columnCount];
                // Accessing the current rows
                for (int j = 1; j <= columnCount; j++)
                {
                    row.columns[j - 1] = rawRange.GetValue(i, j);
                }
                row.concatenatedRow = string.Join(",", row.columns.Where(x => x != null)).ToLower();
                result.Add(row);
            }

            return result;
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
