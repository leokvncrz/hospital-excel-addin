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
    }
}
