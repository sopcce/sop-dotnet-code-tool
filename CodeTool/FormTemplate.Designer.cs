namespace CodeTool
{
    partial class FormTemplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTemplate));
            this.comboBox_providerName = new System.Windows.Forms.ComboBox();
            this.btnOpenDB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_dbType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.richTextBox_code = new System.Windows.Forms.RichTextBox();
            this.btn_model = new System.Windows.Forms.Button();
            this.comboBox_Connstring = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox_providerName
            // 
            this.comboBox_providerName.FormattingEnabled = true;
            this.comboBox_providerName.Items.AddRange(new object[] {
            "System.Data.SqlClient",
            "System.Data.SqlLite",
            "System.Data.OracleClient",
            "MySql.Data.MySqlClien"});
            this.comboBox_providerName.Location = new System.Drawing.Point(183, 38);
            this.comboBox_providerName.Name = "comboBox_providerName";
            this.comboBox_providerName.Size = new System.Drawing.Size(149, 20);
            this.comboBox_providerName.TabIndex = 0;
            this.comboBox_providerName.Text = "System.Data.SqlClient";
            // 
            // btnOpenDB
            // 
            this.btnOpenDB.Location = new System.Drawing.Point(15, 57);
            this.btnOpenDB.Name = "btnOpenDB";
            this.btnOpenDB.Size = new System.Drawing.Size(145, 35);
            this.btnOpenDB.TabIndex = 1;
            this.btnOpenDB.Text = "链接数据库";
            this.btnOpenDB.UseVisualStyleBackColor = true;
            this.btnOpenDB.Click += new System.EventHandler(this.btnOpenDB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ConnectionStrings：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(45, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ProviderName：";
            // 
            // comboBox_dbType
            // 
            this.comboBox_dbType.FormattingEnabled = true;
            this.comboBox_dbType.Items.AddRange(new object[] {
            "System.Data.SqlClient"});
            this.comboBox_dbType.Location = new System.Drawing.Point(443, 36);
            this.comboBox_dbType.Name = "comboBox_dbType";
            this.comboBox_dbType.Size = new System.Drawing.Size(149, 20);
            this.comboBox_dbType.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Path：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(361, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "数据库：";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(15, 103);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(145, 35);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "存储过程生成";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // richTextBox_code
            // 
            this.richTextBox_code.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.richTextBox_code.Location = new System.Drawing.Point(183, 65);
            this.richTextBox_code.Name = "richTextBox_code";
            this.richTextBox_code.Size = new System.Drawing.Size(409, 392);
            this.richTextBox_code.TabIndex = 4;
            this.richTextBox_code.Text = "";
            // 
            // btn_model
            // 
            this.btn_model.Location = new System.Drawing.Point(15, 144);
            this.btn_model.Name = "btn_model";
            this.btn_model.Size = new System.Drawing.Size(145, 35);
            this.btn_model.TabIndex = 1;
            this.btn_model.Text = "Model生成";
            this.btn_model.UseVisualStyleBackColor = true;
            this.btn_model.Click += new System.EventHandler(this.btn_model_Click);
            // 
            // comboBox_Connstring
            // 
            this.comboBox_Connstring.FormattingEnabled = true;
            this.comboBox_Connstring.Items.AddRange(new object[] {
            "Data Source=.;Initial Catalog=test_528;User ID=sa;Password=sa123.",
            "server=.;uid=Sa;pwd=sa123.;database=Sop;",
            "server=.;uid=Sa;pwd=sa123.;database=Sop1;"});
            this.comboBox_Connstring.Location = new System.Drawing.Point(183, 8);
            this.comboBox_Connstring.Name = "comboBox_Connstring";
            this.comboBox_Connstring.Size = new System.Drawing.Size(400, 20);
            this.comboBox_Connstring.TabIndex = 0;
            // 
            // FormTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 478);
            this.Controls.Add(this.richTextBox_code);
            this.Controls.Add(this.btn_model);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnOpenDB);
            this.Controls.Add(this.comboBox_Connstring);
            this.Controls.Add(this.comboBox_dbType);
            this.Controls.Add(this.comboBox_providerName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(611, 505);
            this.Name = "FormTemplate";
            this.Text = "模板生成工具v0.2";
            this.Load += new System.EventHandler(this.btnOpen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_providerName;
        private System.Windows.Forms.Button btnOpenDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_dbType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.RichTextBox richTextBox_code;
        private System.Windows.Forms.Button btn_model;
        private System.Windows.Forms.ComboBox comboBox_Connstring;
    }
}