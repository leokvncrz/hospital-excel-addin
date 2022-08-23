using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;

namespace hospitalAddIn
{
    public partial class Ribbon
    {
        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void convertBtn_Click(object sender, RibbonControlEventArgs e) {
            var convertCode = new ConvertCodes(Config.getConvertCodeConfig());
            convertCode.start();
        }
        private void highlightBtn_Click(object sender, RibbonControlEventArgs e) {
            var highlightKeywords = new HighlightKeywords();
            highlightKeywords.run();
        }
    }
}
