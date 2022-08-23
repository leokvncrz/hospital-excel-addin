using Microsoft.Office.Tools.Ribbon;

namespace hospitalAddIn
{
    public partial class Ribbon
    {
        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void convertBtn_Click(object sender, RibbonControlEventArgs e) {
            var convertCode = new ConvertCodes(Config.getConvertCodeConfig());
            convertCode.Start();
        }
        private void highlightBtn_Click(object sender, RibbonControlEventArgs e) {
            var highlightKeywords = new HighlightKeywords(Config.getHighlightKeywordsConfig());
            highlightKeywords.Start();
        }
    }
}
