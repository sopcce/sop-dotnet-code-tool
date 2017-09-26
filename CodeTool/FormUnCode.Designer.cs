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
            this.btnStringBuilder1 = new System.Windows.Forms.Button();
            this.btnCleanRN = new System.Windows.Forms.Button();
            this.btnClearSpChar = new System.Windows.Forms.Button();
            this.textBox_clernstr = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxBefore
            // 
            this.richTextBoxBefore.Location = new System.Drawing.Point(1, 4);
            this.richTextBoxBefore.Name = "richTextBoxBefore";
            this.richTextBoxBefore.Size = new System.Drawing.Size(600, 171);
            this.richTextBoxBefore.TabIndex = 0;
            this.richTextBoxBefore.Text = "";
            // 
            // richTextBoxAfter
            // 
            this.richTextBoxAfter.Location = new System.Drawing.Point(1, 302);
            this.richTextBoxAfter.Name = "richTextBoxAfter";
            this.richTextBoxAfter.Size = new System.Drawing.Size(600, 171);
            this.richTextBoxAfter.TabIndex = 0;
            this.richTextBoxAfter.Text = "";
            // 
            // btnStringBuilder1
            // 
            this.btnStringBuilder1.Location = new System.Drawing.Point(1, 181);
            this.btnStringBuilder1.Name = "btnStringBuilder1";
            this.btnStringBuilder1.Size = new System.Drawing.Size(120, 23);
            this.btnStringBuilder1.TabIndex = 2;
            this.btnStringBuilder1.Text = "StringBuilder编码";
            this.btnStringBuilder1.UseVisualStyleBackColor = true;
            this.btnStringBuilder1.Click += new System.EventHandler(this.btnStringBuilder1_Click);
            // 
            // btnCleanRN
            // 
            this.btnCleanRN.Location = new System.Drawing.Point(1, 210);
            this.btnCleanRN.Name = "btnCleanRN";
            this.btnCleanRN.Size = new System.Drawing.Size(120, 23);
            this.btnCleanRN.TabIndex = 2;
            this.btnCleanRN.Text = "字符串压缩";
            this.btnCleanRN.UseVisualStyleBackColor = true;
            this.btnCleanRN.Click += new System.EventHandler(this.btnCleanRN_Click);
            // 
            // btnClearSpChar
            // 
            this.btnClearSpChar.Location = new System.Drawing.Point(304, 183);
            this.btnClearSpChar.Name = "btnClearSpChar";
            this.btnClearSpChar.Size = new System.Drawing.Size(120, 23);
            this.btnClearSpChar.TabIndex = 2;
            this.btnClearSpChar.Text = "清除指定字符";
            this.btnClearSpChar.UseVisualStyleBackColor = true;
            this.btnClearSpChar.Click += new System.EventHandler(this.btnClearSpChar_Click);
            // 
            // textBox_clernstr
            // 
            this.textBox_clernstr.Location = new System.Drawing.Point(430, 183);
            this.textBox_clernstr.Name = "textBox_clernstr";
            this.textBox_clernstr.Size = new System.Drawing.Size(171, 21);
            this.textBox_clernstr.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "数据库解密";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(127, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "加密";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormUnCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 478);
            this.Controls.Add(this.textBox_clernstr);
            this.Controls.Add(this.btnClearSpChar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCleanRN);
            this.Controls.Add(this.btnStringBuilder1);
            this.Controls.Add(this.richTextBoxAfter);
            this.Controls.Add(this.richTextBoxBefore);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(611, 505);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(611, 505);
            this.Name = "FormUnCode";
            this.Text = "编码生成";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBoxBefore;
        private System.Windows.Forms.RichTextBox richTextBoxAfter;
        private System.Windows.Forms.Button btnStringBuilder1;
        private System.Windows.Forms.Button btnCleanRN;
        private System.Windows.Forms.Button btnClearSpChar;
        private System.Windows.Forms.TextBox textBox_clernstr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}