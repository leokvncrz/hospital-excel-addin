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
            this.icdFilePathLabel = new System.Windows.Forms.Label();
            this.keywordsFilePath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startHighlightBtn
            // 
            this.startHighlightBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.startHighlightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startHighlightBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startHighlightBtn.Location = new System.Drawing.Point(12, 78);
            this.startHighlightBtn.Name = "startHighlightBtn";
            this.startHighlightBtn.Size = new System.Drawing.Size(294, 35);
            this.startHighlightBtn.TabIndex = 1;
            this.startHighlightBtn.Text = "HIGHLIGHT KEYWORDS";
            this.startHighlightBtn.UseVisualStyleBackColor = false;
            // 
            // icdFilePathLabel
            // 
            this.icdFilePathLabel.AutoSize = true;
            this.icdFilePathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icdFilePathLabel.Location = new System.Drawing.Point(9, 21);
            this.icdFilePathLabel.Name = "icdFilePathLabel";
            this.icdFilePathLabel.Size = new System.Drawing.Size(86, 13);
            this.icdFilePathLabel.TabIndex = 5;
            this.icdFilePathLabel.Text = "Keyword List File";
            // 
            // keywordsFilePath
            // 
            this.keywordsFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keywordsFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keywordsFilePath.Location = new System.Drawing.Point(12, 39);
            this.keywordsFilePath.Name = "keywordsFilePath";
            this.keywordsFilePath.Size = new System.Drawing.Size(268, 20);
            this.keywordsFilePath.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HighlightConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 126);
            this.Controls.Add(this.icdFilePathLabel);
            this.Controls.Add(this.keywordsFilePath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.startHighlightBtn);
            this.Name = "HighlightConfigForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Highlight Keywords Config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label icdFilePathLabel;
        public System.Windows.Forms.TextBox keywordsFilePath;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button startHighlightBtn;
    }
}