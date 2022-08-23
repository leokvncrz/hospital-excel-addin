using hospitalAddIn.Forms;

namespace hospitalAddIn
{
    internal class ConvertCodes
    {
        private ConvertCodesConfigModel config;
        public ConvertCodes(ConvertCodesConfigModel config)
        {
            this.config = config;  
        }

        public void start() {
            var configForm = new ConvertConfigForm();
            // Pass Initial Config to Config Form
            configForm.icdCodesFilePath.Text = config.icdCodesFilePath;
            configForm.icdCodeColumn.Text = config.icdCodeColumn;
            configForm.icdTextColumn.Text = config.icdTextColumn;
            configForm.icdRowStart.Text = config.icdRowStart.ToString();
            configForm.icdRowEnd.Text = config.icdRowEnd.ToString();
            
            configForm.cptCodesFilePath.Text = config.cptCodesFilePath;
            configForm.cptCodeColumn.Text = config.cptCodeColumn;
            configForm.cptTextColumn.Text = config.cptTextColumn;
            configForm.cptRowStart.Text = config.cptRowStart.ToString();
            configForm.cptRowEnd.Text = config.cptRowEnd.ToString();
            configForm.ShowDialog();
        }
    }
}
