using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospitalAddIn.Forms
{
    public partial class HighlightConfigForm : Form
    {
        public HighlightConfigForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Open File Path
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.DefaultExt = "xlsx";
            fileDialog.CheckFileExists = true;
            fileDialog.CheckPathExists = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                keywordsFilePath.Text = fileDialog.FileName;
            }
        }
    }
}
