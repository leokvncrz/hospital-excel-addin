using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace hospitalAddIn.Forms
{
    public partial class ConvertConfigForm : Form
    {
        public ConvertConfigForm()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkNumberOnly_TextChanged(object sender, EventArgs e)
        {
            TextBox tbSender = sender as TextBox;
            if (System.Text.RegularExpressions.Regex.IsMatch(tbSender.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                tbSender.Text = tbSender.Text.Remove(tbSender.Text.Length - 1);
            }
        }

        private void startConvertBtn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Open File Path
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.DefaultExt = "xlsx";
            fileDialog.CheckFileExists = true;
            fileDialog.CheckPathExists = true;
            if (fileDialog.ShowDialog() == DialogResult.OK) { 
                icdCodesFilePath.Text = fileDialog.FileName;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Open File Path
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.DefaultExt = "xlsx";
            fileDialog.CheckFileExists = true;
            fileDialog.CheckPathExists = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                cptCodesFilePath.Text = fileDialog.FileName;
            }
        }
    }
}
