namespace CodeTool
{
    partial class FormMake
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMake));
            this.PanelConect = new System.Windows.Forms.Panel();
            this.listBox_dbType = new System.Windows.Forms.ListBox();
            this.TxtConnectionString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblConnectionString = new System.Windows.Forms.Label();
            this.GbAuthentication = new System.Windows.Forms.GroupBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.RBtnSqlAuthentication = new System.Windows.Forms.RadioButton();
            this.RBtnWinAuthentication = new System.Windows.Forms.RadioButton();
            this.TxtServer = new System.Windows.Forms.TextBox();
            this.LblServer = new System.Windows.Forms.Label();
            this.RBtnProvideConnectionString = new System.Windows.Forms.RadioButton();
            this.RBtnSpecifiyServer = new System.Windows.Forms.RadioButton();
            this.PlSelectDataBase = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.LblOperateTarget = new System.Windows.Forms.Label();
            this.LblSelectDataBase = new System.Windows.Forms.Label();
            this.LbDataBases = new System.Windows.Forms.ListBox();
            this.PlSelectDataItem = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSchemaNext = new System.Windows.Forms.Button();
            this.BtnComplete = new System.Windows.Forms.Button();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.PlSetOption = new System.Windows.Forms.Panel();
            this.PlExecMessage = new System.Windows.Forms.Panel();
            this.TxtExecMessage = new System.Windows.Forms.TextBox();
            this.listBoxSelectDataBaseItems = new System.Windows.Forms.ListBox();
            this.radioBtnModel = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearCode = new System.Windows.Forms.Button();
            this.PanelConect.SuspendLayout();
            this.GbAuthentication.SuspendLayout();
            this.PlSelectDataBase.SuspendLayout();
            this.PlSelectDataItem.SuspendLayout();
            this.PlSetOption.SuspendLayout();
            this.PlExecMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelConect
            // 
            this.PanelConect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelConect.Controls.Add(this.listBox_dbType);
            this.PanelConect.Controls.Add(this.TxtConnectionString);
            this.PanelConect.Controls.Add(this.label1);
            this.PanelConect.Controls.Add(this.LblConnectionString);
            this.PanelConect.Controls.Add(this.GbAuthentication);
            this.PanelConect.Controls.Add(this.TxtServer);
            this.PanelConect.Controls.Add(this.LblServer);
            this.PanelConect.Controls.Add(this.RBtnProvideConnectionString);
            this.PanelConect.Controls.Add(this.RBtnSpecifiyServer);
            this.PanelConect.Font = new System.Drawing.Font("宋体", 12F);
            this.PanelConect.Location = new System.Drawing.Point(28, 35);
            this.PanelConect.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.PanelConect.Name = "PanelConect";
            this.PanelConect.Size = new System.Drawing.Size(1019, 680);
            this.PanelConect.TabIndex = 0;
            this.PanelConect.TabStop = true;
            // 
            // listBox_dbType
            // 
            this.listBox_dbType.FormattingEnabled = true;
            this.listBox_dbType.ItemHeight = 28;
            this.listBox_dbType.Items.AddRange(new object[] {
            "SqlServer",
            "MySql",
            "Oracle"});
            this.listBox_dbType.Location = new System.Drawing.Point(641, 495);
            this.listBox_dbType.Name = "listBox_dbType";
            this.listBox_dbType.Size = new System.Drawing.Size(193, 32);
            this.listBox_dbType.TabIndex = 7;
            this.listBox_dbType.SelectedIndexChanged += new System.EventHandler(this.listBox_dbType_SelectedIndexChanged);
            // 
            // TxtConnectionString
            // 
            this.TxtConnectionString.Enabled = false;
            this.TxtConnectionString.Location = new System.Drawing.Point(84, 542);
            this.TxtConnectionString.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtConnectionString.Multiline = true;
            this.TxtConnectionString.Name = "TxtConnectionString";
            this.TxtConnectionString.Size = new System.Drawing.Size(868, 104);
            this.TxtConnectionString.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(472, 499);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "数据库类型";
            // 
            // LblConnectionString
            // 
            this.LblConnectionString.AutoSize = true;
            this.LblConnectionString.Font = new System.Drawing.Font("宋体", 12F);
            this.LblConnectionString.Location = new System.Drawing.Point(90, 499);
            this.LblConnectionString.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblConnectionString.Name = "LblConnectionString";
            this.LblConnectionString.Size = new System.Drawing.Size(152, 28);
            this.LblConnectionString.TabIndex = 4;
            this.LblConnectionString.Text = "连接字符串";
            // 
            // GbAuthentication
            // 
            this.GbAuthentication.Controls.Add(this.TxtPassword);
            this.GbAuthentication.Controls.Add(this.TxtUserName);
            this.GbAuthentication.Controls.Add(this.LblPassword);
            this.GbAuthentication.Controls.Add(this.LblUserName);
            this.GbAuthentication.Controls.Add(this.RBtnSqlAuthentication);
            this.GbAuthentication.Controls.Add(this.RBtnWinAuthentication);
            this.GbAuthentication.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GbAuthentication.Font = new System.Drawing.Font("宋体", 12F);
            this.GbAuthentication.Location = new System.Drawing.Point(91, 132);
            this.GbAuthentication.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.GbAuthentication.Name = "GbAuthentication";
            this.GbAuthentication.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.GbAuthentication.Size = new System.Drawing.Size(862, 266);
            this.GbAuthentication.TabIndex = 3;
            this.GbAuthentication.TabStop = false;
            this.GbAuthentication.Text = "身份验证";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Enabled = false;
            this.TxtPassword.Font = new System.Drawing.Font("宋体", 12F);
            this.TxtPassword.Location = new System.Drawing.Point(202, 176);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '●';
            this.TxtPassword.Size = new System.Drawing.Size(541, 39);
            this.TxtPassword.TabIndex = 2;
            // 
            // TxtUserName
            // 
            this.TxtUserName.Enabled = false;
            this.TxtUserName.Location = new System.Drawing.Point(202, 118);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(541, 39);
            this.TxtUserName.TabIndex = 2;
            this.TxtUserName.Text = "sa";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("宋体", 12F);
            this.LblPassword.Location = new System.Drawing.Point(66, 186);
            this.LblPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(68, 28);
            this.LblPassword.TabIndex = 1;
            this.LblPassword.Text = "密码";
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("宋体", 12F);
            this.LblUserName.Location = new System.Drawing.Point(66, 128);
            this.LblUserName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(96, 28);
            this.LblUserName.TabIndex = 1;
            this.LblUserName.Text = "用户名";
            // 
            // RBtnSqlAuthentication
            // 
            this.RBtnSqlAuthentication.AutoSize = true;
            this.RBtnSqlAuthentication.Font = new System.Drawing.Font("宋体", 12F);
            this.RBtnSqlAuthentication.Location = new System.Drawing.Point(33, 75);
            this.RBtnSqlAuthentication.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.RBtnSqlAuthentication.Name = "RBtnSqlAuthentication";
            this.RBtnSqlAuthentication.Size = new System.Drawing.Size(345, 32);
            this.RBtnSqlAuthentication.TabIndex = 0;
            this.RBtnSqlAuthentication.Tag = "Authentication";
            this.RBtnSqlAuthentication.Text = "使用SQL Server身份认证";
            this.RBtnSqlAuthentication.UseVisualStyleBackColor = true;
            this.RBtnSqlAuthentication.CheckedChanged += new System.EventHandler(this.RBtnSqlAuthentication_CheckedChanged);
            // 
            // RBtnWinAuthentication
            // 
            this.RBtnWinAuthentication.AutoSize = true;
            this.RBtnWinAuthentication.Checked = true;
            this.RBtnWinAuthentication.Font = new System.Drawing.Font("宋体", 12F);
            this.RBtnWinAuthentication.Location = new System.Drawing.Point(33, 36);
            this.RBtnWinAuthentication.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.RBtnWinAuthentication.Name = "RBtnWinAuthentication";
            this.RBtnWinAuthentication.Size = new System.Drawing.Size(303, 32);
            this.RBtnWinAuthentication.TabIndex = 0;
            this.RBtnWinAuthentication.TabStop = true;
            this.RBtnWinAuthentication.Tag = "Authentication";
            this.RBtnWinAuthentication.Text = "使用Windows身份认证";
            this.RBtnWinAuthentication.UseVisualStyleBackColor = true;
            this.RBtnWinAuthentication.CheckedChanged += new System.EventHandler(this.RBtnWinAuthentication_CheckedChanged);
            // 
            // TxtServer
            // 
            this.TxtServer.Font = new System.Drawing.Font("宋体", 12F);
            this.TxtServer.Location = new System.Drawing.Point(215, 60);
            this.TxtServer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtServer.Name = "TxtServer";
            this.TxtServer.Size = new System.Drawing.Size(737, 39);
            this.TxtServer.TabIndex = 2;
            this.TxtServer.Text = ".";
            // 
            // LblServer
            // 
            this.LblServer.AutoSize = true;
            this.LblServer.Font = new System.Drawing.Font("宋体", 12F);
            this.LblServer.Location = new System.Drawing.Point(90, 70);
            this.LblServer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblServer.Name = "LblServer";
            this.LblServer.Size = new System.Drawing.Size(96, 28);
            this.LblServer.TabIndex = 1;
            this.LblServer.Text = "服务器";
            // 
            // RBtnProvideConnectionString
            // 
            this.RBtnProvideConnectionString.AutoSize = true;
            this.RBtnProvideConnectionString.Font = new System.Drawing.Font("宋体", 12F);
            this.RBtnProvideConnectionString.Location = new System.Drawing.Point(15, 435);
            this.RBtnProvideConnectionString.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.RBtnProvideConnectionString.Name = "RBtnProvideConnectionString";
            this.RBtnProvideConnectionString.Size = new System.Drawing.Size(233, 32);
            this.RBtnProvideConnectionString.TabIndex = 0;
            this.RBtnProvideConnectionString.Tag = "ConnectMode";
            this.RBtnProvideConnectionString.Text = "提供连接字符串";
            this.RBtnProvideConnectionString.UseVisualStyleBackColor = true;
            this.RBtnProvideConnectionString.CheckedChanged += new System.EventHandler(this.RBtnProvideConnectionString_CheckedChanged);
            // 
            // RBtnSpecifiyServer
            // 
            this.RBtnSpecifiyServer.AutoSize = true;
            this.RBtnSpecifiyServer.Checked = true;
            this.RBtnSpecifiyServer.Font = new System.Drawing.Font("宋体", 12F);
            this.RBtnSpecifiyServer.Location = new System.Drawing.Point(15, 21);
            this.RBtnSpecifiyServer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.RBtnSpecifiyServer.Name = "RBtnSpecifiyServer";
            this.RBtnSpecifiyServer.Size = new System.Drawing.Size(317, 32);
            this.RBtnSpecifiyServer.TabIndex = 0;
            this.RBtnSpecifiyServer.TabStop = true;
            this.RBtnSpecifiyServer.Tag = "ConnectMode";
            this.RBtnSpecifiyServer.Text = "指定SQL Server服务器";
            this.RBtnSpecifiyServer.UseVisualStyleBackColor = true;
            this.RBtnSpecifiyServer.CheckedChanged += new System.EventHandler(this.RBtnSpecifiyServer_CheckedChanged);
            // 
            // PlSelectDataBase
            // 
            this.PlSelectDataBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlSelectDataBase.Controls.Add(this.treeView1);
            this.PlSelectDataBase.Controls.Add(this.LblOperateTarget);
            this.PlSelectDataBase.Controls.Add(this.LblSelectDataBase);
            this.PlSelectDataBase.Controls.Add(this.LbDataBases);
            this.PlSelectDataBase.Font = new System.Drawing.Font("宋体", 12F);
            this.PlSelectDataBase.Location = new System.Drawing.Point(28, 35);
            this.PlSelectDataBase.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.PlSelectDataBase.Name = "PlSelectDataBase";
            this.PlSelectDataBase.Size = new System.Drawing.Size(1019, 680);
            this.PlSelectDataBase.TabIndex = 1;
            this.PlSelectDataBase.TabStop = true;
            this.PlSelectDataBase.Visible = false;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(533, 66);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(400, 592);
            this.treeView1.TabIndex = 5;
            // 
            // LblOperateTarget
            // 
            this.LblOperateTarget.AutoSize = true;
            this.LblOperateTarget.Location = new System.Drawing.Point(528, 26);
            this.LblOperateTarget.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblOperateTarget.Name = "LblOperateTarget";
            this.LblOperateTarget.Size = new System.Drawing.Size(124, 28);
            this.LblOperateTarget.TabIndex = 4;
            this.LblOperateTarget.Text = "操作对象";
            // 
            // LblSelectDataBase
            // 
            this.LblSelectDataBase.AutoSize = true;
            this.LblSelectDataBase.Location = new System.Drawing.Point(66, 26);
            this.LblSelectDataBase.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblSelectDataBase.Name = "LblSelectDataBase";
            this.LblSelectDataBase.Size = new System.Drawing.Size(152, 28);
            this.LblSelectDataBase.TabIndex = 2;
            this.LblSelectDataBase.Text = "选择数据库";
            // 
            // LbDataBases
            // 
            this.LbDataBases.FormattingEnabled = true;
            this.LbDataBases.ItemHeight = 28;
            this.LbDataBases.Location = new System.Drawing.Point(66, 66);
            this.LbDataBases.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.LbDataBases.Name = "LbDataBases";
            this.LbDataBases.Size = new System.Drawing.Size(400, 592);
            this.LbDataBases.TabIndex = 1;
            this.LbDataBases.SelectedValueChanged += new System.EventHandler(this.LbDataBases_SelectedValueChanged);
            // 
            // PlSelectDataItem
            // 
            this.PlSelectDataItem.Controls.Add(this.radioButton9);
            this.PlSelectDataItem.Controls.Add(this.radioButton8);
            this.PlSelectDataItem.Controls.Add(this.radioButton7);
            this.PlSelectDataItem.Controls.Add(this.radioButton6);
            this.PlSelectDataItem.Controls.Add(this.radioButton5);
            this.PlSelectDataItem.Controls.Add(this.radioButton4);
            this.PlSelectDataItem.Controls.Add(this.radioButton3);
            this.PlSelectDataItem.Controls.Add(this.radioButton2);
            this.PlSelectDataItem.Controls.Add(this.radioBtnModel);
            this.PlSelectDataItem.Controls.Add(this.listBoxSelectDataBaseItems);
            this.PlSelectDataItem.Controls.Add(this.label3);
            this.PlSelectDataItem.Controls.Add(this.label2);
            this.PlSelectDataItem.Font = new System.Drawing.Font("宋体", 12F);
            this.PlSelectDataItem.Location = new System.Drawing.Point(28, 35);
            this.PlSelectDataItem.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.PlSelectDataItem.Name = "PlSelectDataItem";
            this.PlSelectDataItem.Size = new System.Drawing.Size(1018, 680);
            this.PlSelectDataItem.TabIndex = 3;
            this.PlSelectDataItem.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "选择数据表";
            // 
            // BtnSchemaNext
            // 
            this.BtnSchemaNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSchemaNext.Location = new System.Drawing.Point(733, 744);
            this.BtnSchemaNext.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BtnSchemaNext.Name = "BtnSchemaNext";
            this.BtnSchemaNext.Size = new System.Drawing.Size(138, 40);
            this.BtnSchemaNext.TabIndex = 8;
            this.BtnSchemaNext.Text = "下一步》";
            this.BtnSchemaNext.UseVisualStyleBackColor = true;
            this.BtnSchemaNext.Click += new System.EventHandler(this.BtnSchemaNext_Click);
            // 
            // BtnComplete
            // 
            this.BtnComplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnComplete.Location = new System.Drawing.Point(898, 744);
            this.BtnComplete.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BtnComplete.Name = "BtnComplete";
            this.BtnComplete.Size = new System.Drawing.Size(138, 40);
            this.BtnComplete.TabIndex = 7;
            this.BtnComplete.Text = "退出";
            this.BtnComplete.UseVisualStyleBackColor = true;
            this.BtnComplete.Click += new System.EventHandler(this.BtnComplete_Click);
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPrevious.Location = new System.Drawing.Point(562, 744);
            this.BtnPrevious.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(138, 40);
            this.BtnPrevious.TabIndex = 8;
            this.BtnPrevious.Text = "《上一步";
            this.BtnPrevious.UseVisualStyleBackColor = true;
            this.BtnPrevious.Visible = false;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // PlSetOption
            // 
            this.PlSetOption.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlSetOption.Controls.Add(this.groupBox1);
            this.PlSetOption.Location = new System.Drawing.Point(28, 35);
            this.PlSetOption.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.PlSetOption.Name = "PlSetOption";
            this.PlSetOption.Size = new System.Drawing.Size(1018, 680);
            this.PlSetOption.TabIndex = 9;
            this.PlSetOption.Visible = false;
            // 
            // PlExecMessage
            // 
            this.PlExecMessage.Controls.Add(this.TxtExecMessage);
            this.PlExecMessage.Location = new System.Drawing.Point(28, 35);
            this.PlExecMessage.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.PlExecMessage.Name = "PlExecMessage";
            this.PlExecMessage.Size = new System.Drawing.Size(1018, 680);
            this.PlExecMessage.TabIndex = 10;
            this.PlExecMessage.Visible = false;
            // 
            // TxtExecMessage
            // 
            this.TxtExecMessage.Location = new System.Drawing.Point(40, 38);
            this.TxtExecMessage.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtExecMessage.Multiline = true;
            this.TxtExecMessage.Name = "TxtExecMessage";
            this.TxtExecMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtExecMessage.Size = new System.Drawing.Size(902, 609);
            this.TxtExecMessage.TabIndex = 0;
            // 
            // listBoxSelectDataBaseItems
            // 
            this.listBoxSelectDataBaseItems.FormattingEnabled = true;
            this.listBoxSelectDataBaseItems.ItemHeight = 28;
            this.listBoxSelectDataBaseItems.Location = new System.Drawing.Point(68, 66);
            this.listBoxSelectDataBaseItems.Name = "listBoxSelectDataBaseItems";
            this.listBoxSelectDataBaseItems.Size = new System.Drawing.Size(400, 592);
            this.listBoxSelectDataBaseItems.TabIndex = 4;
            // 
            // radioBtnModel
            // 
            this.radioBtnModel.AccessibleName = "radioBtnMakeDbType";
            this.radioBtnModel.AutoSize = true;
            this.radioBtnModel.Location = new System.Drawing.Point(534, 69);
            this.radioBtnModel.Name = "radioBtnModel";
            this.radioBtnModel.Size = new System.Drawing.Size(149, 32);
            this.radioBtnModel.TabIndex = 5;
            this.radioBtnModel.TabStop = true;
            this.radioBtnModel.Text = "实体生成";
            this.radioBtnModel.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AccessibleName = "radioBtnModel";
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(534, 132);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(93, 32);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Resp";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AccessibleName = "radioBtnModel";
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(534, 195);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(205, 32);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton1";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AccessibleName = "radioBtnModel";
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(534, 258);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(205, 32);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton1";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(534, 321);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(205, 32);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "radioButton1";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(534, 384);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(205, 32);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "radioButton1";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(534, 447);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(205, 32);
            this.radioButton7.TabIndex = 5;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "radioButton1";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(534, 510);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(205, 32);
            this.radioButton8.TabIndex = 5;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "radioButton1";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(534, 573);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(205, 32);
            this.radioButton9.TabIndex = 5;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "radioButton1";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "选择模板";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(16, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 621);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑器";
            // 
            // btnClearCode
            // 
            this.btnClearCode.Font = new System.Drawing.Font("宋体", 9F);
            this.btnClearCode.Location = new System.Drawing.Point(415, 744);
            this.btnClearCode.Name = "btnClearCode";
            this.btnClearCode.Size = new System.Drawing.Size(138, 40);
            this.btnClearCode.TabIndex = 11;
            this.btnClearCode.Text = "格式化";
            this.btnClearCode.UseVisualStyleBackColor = true;
            this.btnClearCode.Visible = false;
            this.btnClearCode.Click += new System.EventHandler(this.btnClearCode_Click);
            // 
            // FormMake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 802);
            this.Controls.Add(this.btnClearCode);
            this.Controls.Add(this.BtnPrevious);
            this.Controls.Add(this.BtnSchemaNext);
            this.Controls.Add(this.BtnComplete);
            this.Controls.Add(this.PlSetOption);
            this.Controls.Add(this.PlExecMessage);
            this.Controls.Add(this.PanelConect);
            this.Controls.Add(this.PlSelectDataBase);
            this.Controls.Add(this.PlSelectDataItem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimumSize = new System.Drawing.Size(1102, 866);
            this.Name = "FormMake";
            this.Text = "Sop数据库V1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMake_FormClosing);
            this.Load += new System.EventHandler(this.FormMake_Load);
            this.PanelConect.ResumeLayout(false);
            this.PanelConect.PerformLayout();
            this.GbAuthentication.ResumeLayout(false);
            this.GbAuthentication.PerformLayout();
            this.PlSelectDataBase.ResumeLayout(false);
            this.PlSelectDataBase.PerformLayout();
            this.PlSelectDataItem.ResumeLayout(false);
            this.PlSelectDataItem.PerformLayout();
            this.PlSetOption.ResumeLayout(false);
            this.PlExecMessage.ResumeLayout(false);
            this.PlExecMessage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelConect;
        private System.Windows.Forms.RadioButton RBtnSpecifiyServer;
        private System.Windows.Forms.Label LblServer;
        private System.Windows.Forms.GroupBox GbAuthentication;
        private System.Windows.Forms.TextBox TxtServer;
        private System.Windows.Forms.RadioButton RBtnWinAuthentication;
        private System.Windows.Forms.RadioButton RBtnSqlAuthentication;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.RadioButton RBtnProvideConnectionString;
        private System.Windows.Forms.Label LblConnectionString;
        private System.Windows.Forms.TextBox TxtConnectionString;
        private System.Windows.Forms.Button BtnSchemaNext;
        private System.Windows.Forms.Button BtnComplete;
        private System.Windows.Forms.Panel PlSelectDataBase;
        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.ListBox LbDataBases;
        private System.Windows.Forms.Label LblSelectDataBase;
        private System.Windows.Forms.Panel PlSelectDataItem;
        private System.Windows.Forms.Label LblOperateTarget;
        private System.Windows.Forms.Panel PlSetOption;
        private System.Windows.Forms.Panel PlExecMessage;
        private System.Windows.Forms.TextBox TxtExecMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_dbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioBtnModel;
        private System.Windows.Forms.ListBox listBoxSelectDataBaseItems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClearCode;
    }
}

