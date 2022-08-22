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
            MessageBox.Show("Convert Clicked");
        }
        private void highlightBtn_Click(object sender, RibbonControlEventArgs e) {
            MessageBox.Show("Highlight Clicked");
        }
    }
}
