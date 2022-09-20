namespace hospitalAddIn.Forms
{
    partial class ConvertConfigForm
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
            this.startConvertBtn = new System.Windows.Forms.Button();
            this.icdCodesFilePath = new System.Windows.Forms.TextBox();
            this.icdFilePathLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.icdRowEnd = new System.Windows.Forms.TextBox();
            this.icdRowStart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.icdTextColumn = new System.Windows.Forms.TextBox();
            this.icdCodeColumn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cptRowEnd = new System.Windows.Forms.TextBox();
            this.cptRowStart = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cptTextColumn = new System.Windows.Forms.TextBox();
            this.cptCodeColumn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cptCodesFilePath = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cbICDMultiple = new System.Windows.Forms.CheckBox();
            this.cbCPTMultiple = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // startConvertBtn
            // 
            this.startConvertBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.startConvertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startConvertBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startConvertBtn.Location = new System.Drawing.Point(12, 342);
            this.startConvertBtn.Name = "startConvertBtn";
            this.startConvertBtn.Size = new System.Drawing.Size(337, 35);
            this.startConvertBtn.TabIndex = 0;
            this.startConvertBtn.Text = "CONVERT CODES";
            this.startConvertBtn.UseVisualStyleBackColor = false;
            this.startConvertBtn.Click += new System.EventHandler(this.startConvertBtn_Click);
            // 
            // icdCodesFilePath
            // 
            this.icdCodesFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.icdCodesFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icdCodesFilePath.Location = new System.Drawing.Point(6, 45);
            this.icdCodesFilePath.Name = "icdCodesFilePath";
            this.icdCodesFilePath.Size = new System.Drawing.Size(296, 20);
            this.icdCodesFilePath.TabIndex = 1;
            // 
            // icdFilePathLabel
            // 
            this.icdFilePathLabel.AutoSize = true;
            this.icdFilePathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icdFilePathLabel.Location = new System.Drawing.Point(6, 25);
            this.icdFilePathLabel.Name = "icdFilePathLabel";
            this.icdFilePathLabel.Size = new System.Drawing.Size(77, 13);
            this.icdFilePathLabel.TabIndex = 2;
            this.icdFilePathLabel.Text = "ICD Codes File";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbICDMultiple);
            this.groupBox1.Controls.Add(this.icdRowEnd);
            this.groupBox1.Controls.Add(this.icdRowStart);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.icdTextColumn);
            this.groupBox1.Controls.Add(this.icdCodeColumn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.icdFilePathLabel);
            this.groupBox1.Controls.Add(this.icdCodesFilePath);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 145);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ICD Code Config";
            // 
            // icdRowEnd
            // 
            this.icdRowEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.icdRowEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icdRowEnd.Location = new System.Drawing.Point(244, 104);
            this.icdRowEnd.Name = "icdRowEnd";
            this.icdRowEnd.Size = new System.Drawing.Size(58, 20);
            this.icdRowEnd.TabIndex = 11;
            this.icdRowEnd.TextChanged += new System.EventHandler(this.checkNumberOnly_TextChanged);
            // 
            // icdRowStart
            // 
            this.icdRowStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.icdRowStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icdRowStart.Location = new System.Drawing.Point(244, 81);
            this.icdRowStart.Name = "icdRowStart";
            this.icdRowStart.Size = new System.Drawing.Size(58, 20);
            this.icdRowStart.TabIndex = 10;
            this.icdRowStart.TextChanged += new System.EventHandler(this.checkNumberOnly_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "End Row";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(184, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Start Row";
            // 
            // icdTextColumn
            // 
            this.icdTextColumn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.icdTextColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icdTextColumn.Location = new System.Drawing.Point(103, 104);
            this.icdTextColumn.Name = "icdTextColumn";
            this.icdTextColumn.Size = new System.Drawing.Size(48, 20);
            this.icdTextColumn.TabIndex = 7;
            // 
            // icdCodeColumn
            // 
            this.icdCodeColumn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.icdCodeColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icdCodeColumn.Location = new System.Drawing.Point(103, 81);
            this.icdCodeColumn.Name = "icdCodeColumn";
            this.icdCodeColumn.Size = new System.Drawing.Size(48, 20);
            this.icdCodeColumn.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ICD Text Column";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ICD Code Column";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbCPTMultiple);
            this.groupBox2.Controls.Add(this.cptRowEnd);
            this.groupBox2.Controls.Add(this.cptRowStart);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cptTextColumn);
            this.groupBox2.Controls.Add(this.cptCodeColumn);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cptCodesFilePath);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 145);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CPT Code Config";
            this.groupBox2.TextChanged += new System.EventHandler(this.checkNumberOnly_TextChanged);
            // 
            // cptRowEnd
            // 
            this.cptRowEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cptRowEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cptRowEnd.Location = new System.Drawing.Point(244, 104);
            this.cptRowEnd.Name = "cptRowEnd";
            this.cptRowEnd.Size = new System.Drawing.Size(58, 20);
            this.cptRowEnd.TabIndex = 11;
            // 
            // cptRowStart
            // 
            this.cptRowStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cptRowStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cptRowStart.Location = new System.Drawing.Point(244, 81);
            this.cptRowStart.Name = "cptRowStart";
            this.cptRowStart.Size = new System.Drawing.Size(58, 20);
            this.cptRowStart.TabIndex = 10;
            this.cptRowStart.TextChanged += new System.EventHandler(this.checkNumberOnly_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(187, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "End Row";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(184, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Start Row";
            // 
            // cptTextColumn
            // 
            this.cptTextColumn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cptTextColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cptTextColumn.Location = new System.Drawing.Point(103, 104);
            this.cptTextColumn.Name = "cptTextColumn";
            this.cptTextColumn.Size = new System.Drawing.Size(48, 20);
            this.cptTextColumn.TabIndex = 7;
            // 
            // cptCodeColumn
            // 
            this.cptCodeColumn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cptCodeColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cptCodeColumn.Location = new System.Drawing.Point(103, 81);
            this.cptCodeColumn.Name = "cptCodeColumn";
            this.cptCodeColumn.Size = new System.Drawing.Size(48, 20);
            this.cptCodeColumn.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "CPT Text Column";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "CPT Code Column";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "CPT Codes File";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // cptCodesFilePath
            // 
            this.cptCodesFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cptCodesFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cptCodesFilePath.Location = new System.Drawing.Point(6, 45);
            this.cptCodesFilePath.Name = "cptCodesFilePath";
            this.cptCodesFilePath.Size = new System.Drawing.Size(296, 20);
            this.cptCodesFilePath.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 20);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbICDMultiple
            // 
            this.cbICDMultiple.AutoSize = true;
            this.cbICDMultiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbICDMultiple.Location = new System.Drawing.Point(237, 0);
            this.cbICDMultiple.Name = "cbICDMultiple";
            this.cbICDMultiple.Size = new System.Drawing.Size(100, 17);
            this.cbICDMultiple.TabIndex = 12;
            this.cbICDMultiple.Text = "Multiple codes?";
            this.cbICDMultiple.UseVisualStyleBackColor = true;
            // 
            // cbCPTMultiple
            // 
            this.cbCPTMultiple.AutoSize = true;
            this.cbCPTMultiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCPTMultiple.Location = new System.Drawing.Point(237, 0);
            this.cbCPTMultiple.Name = "cbCPTMultiple";
            this.cbCPTMultiple.Size = new System.Drawing.Size(100, 17);
            this.cbCPTMultiple.TabIndex = 12;
            this.cbCPTMultiple.Text = "Multiple codes?";
            this.cbCPTMultiple.UseVisualStyleBackColor = true;
            // 
            // ConvertConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 391);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.startConvertBtn);
            this.Name = "ConvertConfigForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Convert ICD and CPT Codes Config";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label icdFilePathLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox icdCodesFilePath;
        public System.Windows.Forms.TextBox icdCodeColumn;
        public System.Windows.Forms.TextBox icdTextColumn;
        public System.Windows.Forms.TextBox icdRowStart;
        public System.Windows.Forms.TextBox icdRowEnd;
        public System.Windows.Forms.TextBox cptCodesFilePath;
        public System.Windows.Forms.TextBox cptCodeColumn;
        public System.Windows.Forms.TextBox cptTextColumn;
        public System.Windows.Forms.TextBox cptRowStart;
        public System.Windows.Forms.TextBox cptRowEnd;
        public System.Windows.Forms.Button startConvertBtn;
        public System.Windows.Forms.CheckBox cbICDMultiple;
        public System.Windows.Forms.CheckBox cbCPTMultiple;
    }
}