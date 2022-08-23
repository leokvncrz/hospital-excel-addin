namespace hospitalAddIn.Forms
{
    partial class HighlightConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startHighlightBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startHighlightBtn
            // 
            this.startHighlightBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.startHighlightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startHighlightBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startHighlightBtn.Location = new System.Drawing.Point(12, 252);
            this.startHighlightBtn.Name = "startHighlightBtn";
            this.startHighlightBtn.Size = new System.Drawing.Size(294, 35);
            this.startHighlightBtn.TabIndex = 1;
            this.startHighlightBtn.Text = "HIGHLIGHT KEYWORDS";
            this.startHighlightBtn.UseVisualStyleBackColor = false;
            // 
            // HighlightConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 300);
            this.Controls.Add(this.startHighlightBtn);
            this.Name = "HighlightConfigForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Highlight Keywords Config";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startHighlightBtn;
    }
}