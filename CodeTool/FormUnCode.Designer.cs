namespace CodeTool
{
    partial class FormUnCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUnCode));
            this.richTextBoxBefore = new System.Windows.Forms.RichTextBox();
            this.richTextBoxAfter = new System.Windows.Forms.RichTextBox();
            this.btnStringBuilder_AppendFormat = new System.Windows.Forms.Button();
            this.btnCleanRN = new System.Windows.Forms.Button();
            this.btnClearSpChar = new System.Windows.Forms.Button();
            this.textBox_clernstr = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxBefore
            // 
            this.richTextBoxBefore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxBefore.Location = new System.Drawing.Point(2, 6);
            this.richTextBoxBefore.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxBefore.Name = "richTextBoxBefore";
            this.richTextBoxBefore.Size = new System.Drawing.Size(869, 254);
            this.richTextBoxBefore.TabIndex = 0;
            this.richTextBoxBefore.Text = "";
            // 
            // richTextBoxAfter
            // 
            this.richTextBoxAfter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxAfter.Location = new System.Drawing.Point(1, 399);
            this.richTextBoxAfter.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxAfter.Name = "richTextBoxAfter";
            this.richTextBoxAfter.Size = new System.Drawing.Size(870, 254);
            this.richTextBoxAfter.TabIndex = 0;
            this.richTextBoxAfter.Text = "";
            // 
            // btnStringBuilder_AppendFormat
            // 
            this.btnStringBuilder_AppendFormat.Location = new System.Drawing.Point(2, 272);
            this.btnStringBuilder_AppendFormat.Margin = new System.Windows.Forms.Padding(4);
            this.btnStringBuilder_AppendFormat.Name = "btnStringBuilder_AppendFormat";
            this.btnStringBuilder_AppendFormat.Size = new System.Drawing.Size(368, 34);
            this.btnStringBuilder_AppendFormat.TabIndex = 2;
            this.btnStringBuilder_AppendFormat.Text = "StringBuilder编码AppendFormat";
            this.btnStringBuilder_AppendFormat.UseVisualStyleBackColor = true;
            this.btnStringBuilder_AppendFormat.Click += new System.EventHandler(this.btnStringBuilder_AppendFormat_Click);
            // 
            // btnCleanRN
            // 
            this.btnCleanRN.Location = new System.Drawing.Point(2, 357);
            this.btnCleanRN.Margin = new System.Windows.Forms.Padding(4);
            this.btnCleanRN.Name = "btnCleanRN";
            this.btnCleanRN.Size = new System.Drawing.Size(180, 34);
            this.btnCleanRN.TabIndex = 2;
            this.btnCleanRN.Text = "字符串压缩";
            this.btnCleanRN.UseVisualStyleBackColor = true;
            this.btnCleanRN.Click += new System.EventHandler(this.btnCleanRN_Click);
            // 
            // btnClearSpChar
            // 
            this.btnClearSpChar.Location = new System.Drawing.Point(378, 270);
            this.btnClearSpChar.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearSpChar.Name = "btnClearSpChar";
            this.btnClearSpChar.Size = new System.Drawing.Size(180, 34);
            this.btnClearSpChar.TabIndex = 2;
            this.btnClearSpChar.Text = "清除指定字符";
            this.btnClearSpChar.UseVisualStyleBackColor = true;
            this.btnClearSpChar.Click += new System.EventHandler(this.btnClearSpChar_Click);
            // 
            // textBox_clernstr
            // 
            this.textBox_clernstr.Location = new System.Drawing.Point(566, 272);
            this.textBox_clernstr.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_clernstr.Name = "textBox_clernstr";
            this.textBox_clernstr.Size = new System.Drawing.Size(254, 28);
            this.textBox_clernstr.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 314);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "数据库解密";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 357);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "加密";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(2, 314);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(368, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "StringBuilder编码";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnStringBuilder1_Click);
            // 
            // FormUnCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 674);
            this.Controls.Add(this.textBox_clernstr);
            this.Controls.Add(this.btnClearSpChar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCleanRN);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnStringBuilder_AppendFormat);
            this.Controls.Add(this.richTextBoxAfter);
            this.Controls.Add(this.richTextBoxBefore);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(906, 730);
            this.Name = "FormUnCode";
            this.Text = "编码生成";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBoxBefore;
        private System.Windows.Forms.RichTextBox richTextBoxAfter;
        private System.Windows.Forms.Button btnStringBuilder_AppendFormat;
        private System.Windows.Forms.Button btnCleanRN;
        private System.Windows.Forms.Button btnClearSpChar;
        private System.Windows.Forms.TextBox textBox_clernstr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}