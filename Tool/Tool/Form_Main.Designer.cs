using System.Windows.Forms;

namespace Tool
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private GroupBox groupBox_UserInput;

        private ProgressBar progressBar_Schedule;

        private Button Button_Start;

        private Button button_ChooseOutPath;

        private TextBox textBox_OutPath;

        private TextBox textBox_info;

        private Label label_OutPath;

        private Label label_AppName;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.groupBox_UserInput = new System.Windows.Forms.GroupBox();
            this.button_ChooseOutPath = new System.Windows.Forms.Button();
            this.textBox_OutPath = new System.Windows.Forms.TextBox();
            this.textBox_namespace = new System.Windows.Forms.TextBox();
            this.textBox_Table = new System.Windows.Forms.TextBox();
            this.textBox_info = new System.Windows.Forms.TextBox();
            this.lab_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_OutPath = new System.Windows.Forms.Label();
            this.label_AppName = new System.Windows.Forms.Label();
            this.progressBar_Schedule = new System.Windows.Forms.ProgressBar();
            this.Button_Start = new System.Windows.Forms.Button();
            this.groupBox_UserInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_UserInput
            // 
            this.groupBox_UserInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_UserInput.Controls.Add(this.button_ChooseOutPath);
            this.groupBox_UserInput.Controls.Add(this.textBox_OutPath);
            this.groupBox_UserInput.Controls.Add(this.textBox_namespace);
            this.groupBox_UserInput.Controls.Add(this.textBox_Table);
            this.groupBox_UserInput.Controls.Add(this.textBox_info);
            this.groupBox_UserInput.Controls.Add(this.lab_name);
            this.groupBox_UserInput.Controls.Add(this.label1);
            this.groupBox_UserInput.Controls.Add(this.label_OutPath);
            this.groupBox_UserInput.Controls.Add(this.label_AppName);
            this.groupBox_UserInput.Location = new System.Drawing.Point(18, 18);
            this.groupBox_UserInput.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_UserInput.Name = "groupBox_UserInput";
            this.groupBox_UserInput.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_UserInput.Size = new System.Drawing.Size(556, 627);
            this.groupBox_UserInput.TabIndex = 0;
            this.groupBox_UserInput.TabStop = false;
            this.groupBox_UserInput.Text = "项目信息";
            // 
            // button_ChooseOutPath
            // 
            this.button_ChooseOutPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ChooseOutPath.Location = new System.Drawing.Point(444, 569);
            this.button_ChooseOutPath.Margin = new System.Windows.Forms.Padding(4);
            this.button_ChooseOutPath.Name = "button_ChooseOutPath";
            this.button_ChooseOutPath.Size = new System.Drawing.Size(112, 34);
            this.button_ChooseOutPath.TabIndex = 3;
            this.button_ChooseOutPath.Text = "选择";
            this.button_ChooseOutPath.UseVisualStyleBackColor = true;
            this.button_ChooseOutPath.Click += new System.EventHandler(this.button_ChooseOutPath_Click);
            // 
            // textBox_OutPath
            // 
            this.textBox_OutPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_OutPath.Location = new System.Drawing.Point(125, 572);
            this.textBox_OutPath.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_OutPath.Name = "textBox_OutPath";
            this.textBox_OutPath.Size = new System.Drawing.Size(308, 28);
            this.textBox_OutPath.TabIndex = 2;
            // 
            // textBox_namespace
            // 
            this.textBox_namespace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_namespace.Location = new System.Drawing.Point(117, 33);
            this.textBox_namespace.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_namespace.Name = "textBox_namespace";
            this.textBox_namespace.Size = new System.Drawing.Size(430, 28);
            this.textBox_namespace.TabIndex = 1;
            this.textBox_namespace.Text = "namespace";
            // 
            // textBox_Table
            // 
            this.textBox_Table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Table.Location = new System.Drawing.Point(117, 133);
            this.textBox_Table.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Table.Name = "textBox_Table";
            this.textBox_Table.Size = new System.Drawing.Size(430, 28);
            this.textBox_Table.TabIndex = 1;
            this.textBox_Table.Text = "table";
            // 
            // textBox_info
            // 
            this.textBox_info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_info.Location = new System.Drawing.Point(116, 80);
            this.textBox_info.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_info.Name = "textBox_info";
            this.textBox_info.Size = new System.Drawing.Size(430, 28);
            this.textBox_info.TabIndex = 1;
            this.textBox_info.Text = "info";
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Location = new System.Drawing.Point(10, 40);
            this.lab_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(98, 18);
            this.lab_name.TabIndex = 0;
            this.lab_name.Text = "空间名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "表名称：";
            // 
            // label_OutPath
            // 
            this.label_OutPath.AutoSize = true;
            this.label_OutPath.Location = new System.Drawing.Point(18, 581);
            this.label_OutPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_OutPath.Name = "label_OutPath";
            this.label_OutPath.Size = new System.Drawing.Size(98, 18);
            this.label_OutPath.TabIndex = 0;
            this.label_OutPath.Text = "输出目录：";
            // 
            // label_AppName
            // 
            this.label_AppName.AutoSize = true;
            this.label_AppName.Location = new System.Drawing.Point(9, 85);
            this.label_AppName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_AppName.Name = "label_AppName";
            this.label_AppName.Size = new System.Drawing.Size(98, 18);
            this.label_AppName.TabIndex = 0;
            this.label_AppName.Text = "实体名称：";
            // 
            // progressBar_Schedule
            // 
            this.progressBar_Schedule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar_Schedule.Location = new System.Drawing.Point(18, 670);
            this.progressBar_Schedule.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar_Schedule.Name = "progressBar_Schedule";
            this.progressBar_Schedule.Size = new System.Drawing.Size(435, 34);
            this.progressBar_Schedule.TabIndex = 1;
            // 
            // Button_Start
            // 
            this.Button_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Start.Location = new System.Drawing.Point(462, 670);
            this.Button_Start.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(112, 34);
            this.Button_Start.TabIndex = 2;
            this.Button_Start.Text = "开始";
            this.Button_Start.UseVisualStyleBackColor = true;
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 723);
            this.Controls.Add(this.Button_Start);
            this.Controls.Add(this.progressBar_Schedule);
            this.Controls.Add(this.groupBox_UserInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Main";
            this.Text = "代码模板生成器";
            this.groupBox_UserInput.ResumeLayout(false);
            this.groupBox_UserInput.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private TextBox textBox_namespace;
        private Label lab_name;
        private TextBox textBox_Table;
        private Label label1;
    }
}

