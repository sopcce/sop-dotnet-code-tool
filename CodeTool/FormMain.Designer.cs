namespace CodeTool
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnUnicode = new System.Windows.Forms.Button();
            this.btnTemp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUnicode
            // 
            this.btnUnicode.Font = new System.Drawing.Font("宋体", 22F);
            this.btnUnicode.Location = new System.Drawing.Point(24, 24);
            this.btnUnicode.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnUnicode.Name = "btnUnicode";
            this.btnUnicode.Size = new System.Drawing.Size(290, 124);
            this.btnUnicode.TabIndex = 0;
            this.btnUnicode.Text = "编码";
            this.btnUnicode.UseVisualStyleBackColor = true;
            this.btnUnicode.Click += new System.EventHandler(this.btnUnicode_Click);
            // 
            // btnTemp
            // 
            this.btnTemp.Font = new System.Drawing.Font("宋体", 22F);
            this.btnTemp.Location = new System.Drawing.Point(330, 24);
            this.btnTemp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTemp.Name = "btnTemp";
            this.btnTemp.Size = new System.Drawing.Size(290, 124);
            this.btnTemp.TabIndex = 0;
            this.btnTemp.Text = "模板生成";
            this.btnTemp.UseVisualStyleBackColor = true;
            this.btnTemp.Click += new System.EventHandler(this.btnTemp_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 868);
            this.Controls.Add(this.btnTemp);
            this.Controls.Add(this.btnUnicode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1196, 939);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1196, 939);
            this.Name = "FormMain";
            this.Text = "Sop代码生成工具v0.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUnicode;
        private System.Windows.Forms.Button btnTemp;
    }
}