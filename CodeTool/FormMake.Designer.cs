﻿namespace CodeTool
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
            this.LblOperateTarget = new System.Windows.Forms.Label();
            this.ChkOperateView = new System.Windows.Forms.CheckBox();
            this.ChkOperateTable = new System.Windows.Forms.CheckBox();
            this.LblSelectDataBase = new System.Windows.Forms.Label();
            this.LbDataBases = new System.Windows.Forms.ListBox();
            this.PlSelectDataItem = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxSelectDataBaseItems = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSchemaNext = new System.Windows.Forms.Button();
            this.BtnComplete = new System.Windows.Forms.Button();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.PlSetOption = new System.Windows.Forms.Panel();
            this.PlExecMessage = new System.Windows.Forms.Panel();
            this.TxtExecMessage = new System.Windows.Forms.TextBox();
            this.PanelConect.SuspendLayout();
            this.GbAuthentication.SuspendLayout();
            this.PlSelectDataBase.SuspendLayout();
            this.PlSelectDataItem.SuspendLayout();
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
            this.PanelConect.Location = new System.Drawing.Point(30, 40);
            this.PanelConect.Margin = new System.Windows.Forms.Padding(6);
            this.PanelConect.Name = "PanelConect";
            this.PanelConect.Size = new System.Drawing.Size(1166, 777);
            this.PanelConect.TabIndex = 0;
            this.PanelConect.TabStop = true;
            // 
            // listBox_dbType
            // 
            this.listBox_dbType.FormattingEnabled = true;
            this.listBox_dbType.ItemHeight = 33;
            this.listBox_dbType.Items.AddRange(new object[] {
            "SqlServer",
            "MySql",
            "Oracle"});
            this.listBox_dbType.Location = new System.Drawing.Point(699, 566);
            this.listBox_dbType.Name = "listBox_dbType";
            this.listBox_dbType.Size = new System.Drawing.Size(210, 37);
            this.listBox_dbType.TabIndex = 7;
            // 
            // TxtConnectionString
            // 
            this.TxtConnectionString.Enabled = false;
            this.TxtConnectionString.Location = new System.Drawing.Point(92, 620);
            this.TxtConnectionString.Margin = new System.Windows.Forms.Padding(6);
            this.TxtConnectionString.Multiline = true;
            this.TxtConnectionString.Name = "TxtConnectionString";
            this.TxtConnectionString.Size = new System.Drawing.Size(947, 118);
            this.TxtConnectionString.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(515, 570);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "数据库类型";
            // 
            // LblConnectionString
            // 
            this.LblConnectionString.AutoSize = true;
            this.LblConnectionString.Font = new System.Drawing.Font("宋体", 12F);
            this.LblConnectionString.Location = new System.Drawing.Point(98, 570);
            this.LblConnectionString.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblConnectionString.Name = "LblConnectionString";
            this.LblConnectionString.Size = new System.Drawing.Size(175, 33);
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
            this.GbAuthentication.Location = new System.Drawing.Point(99, 151);
            this.GbAuthentication.Margin = new System.Windows.Forms.Padding(6);
            this.GbAuthentication.Name = "GbAuthentication";
            this.GbAuthentication.Padding = new System.Windows.Forms.Padding(6);
            this.GbAuthentication.Size = new System.Drawing.Size(940, 304);
            this.GbAuthentication.TabIndex = 3;
            this.GbAuthentication.TabStop = false;
            this.GbAuthentication.Text = "身份验证";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Enabled = false;
            this.TxtPassword.Font = new System.Drawing.Font("宋体", 12F);
            this.TxtPassword.Location = new System.Drawing.Point(220, 201);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(6);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '●';
            this.TxtPassword.Size = new System.Drawing.Size(590, 44);
            this.TxtPassword.TabIndex = 2;
            // 
            // TxtUserName
            // 
            this.TxtUserName.Enabled = false;
            this.TxtUserName.Location = new System.Drawing.Point(220, 135);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(6);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(590, 44);
            this.TxtUserName.TabIndex = 2;
            this.TxtUserName.Text = "sa";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("宋体", 12F);
            this.LblPassword.Location = new System.Drawing.Point(72, 212);
            this.LblPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(79, 33);
            this.LblPassword.TabIndex = 1;
            this.LblPassword.Text = "密码";
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("宋体", 12F);
            this.LblUserName.Location = new System.Drawing.Point(72, 146);
            this.LblUserName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(111, 33);
            this.LblUserName.TabIndex = 1;
            this.LblUserName.Text = "用户名";
            // 
            // RBtnSqlAuthentication
            // 
            this.RBtnSqlAuthentication.AutoSize = true;
            this.RBtnSqlAuthentication.Font = new System.Drawing.Font("宋体", 12F);
            this.RBtnSqlAuthentication.Location = new System.Drawing.Point(36, 86);
            this.RBtnSqlAuthentication.Margin = new System.Windows.Forms.Padding(6);
            this.RBtnSqlAuthentication.Name = "RBtnSqlAuthentication";
            this.RBtnSqlAuthentication.Size = new System.Drawing.Size(398, 37);
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
            this.RBtnWinAuthentication.Location = new System.Drawing.Point(36, 41);
            this.RBtnWinAuthentication.Margin = new System.Windows.Forms.Padding(6);
            this.RBtnWinAuthentication.Name = "RBtnWinAuthentication";
            this.RBtnWinAuthentication.Size = new System.Drawing.Size(350, 37);
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
            this.TxtServer.Location = new System.Drawing.Point(235, 69);
            this.TxtServer.Margin = new System.Windows.Forms.Padding(6);
            this.TxtServer.Name = "TxtServer";
            this.TxtServer.Size = new System.Drawing.Size(804, 44);
            this.TxtServer.TabIndex = 2;
            this.TxtServer.Text = ".";
            // 
            // LblServer
            // 
            this.LblServer.AutoSize = true;
            this.LblServer.Font = new System.Drawing.Font("宋体", 12F);
            this.LblServer.Location = new System.Drawing.Point(98, 80);
            this.LblServer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblServer.Name = "LblServer";
            this.LblServer.Size = new System.Drawing.Size(111, 33);
            this.LblServer.TabIndex = 1;
            this.LblServer.Text = "服务器";
            // 
            // RBtnProvideConnectionString
            // 
            this.RBtnProvideConnectionString.AutoSize = true;
            this.RBtnProvideConnectionString.Font = new System.Drawing.Font("宋体", 12F);
            this.RBtnProvideConnectionString.Location = new System.Drawing.Point(16, 497);
            this.RBtnProvideConnectionString.Margin = new System.Windows.Forms.Padding(6);
            this.RBtnProvideConnectionString.Name = "RBtnProvideConnectionString";
            this.RBtnProvideConnectionString.Size = new System.Drawing.Size(270, 37);
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
            this.RBtnSpecifiyServer.Location = new System.Drawing.Point(16, 24);
            this.RBtnSpecifiyServer.Margin = new System.Windows.Forms.Padding(6);
            this.RBtnSpecifiyServer.Name = "RBtnSpecifiyServer";
            this.RBtnSpecifiyServer.Size = new System.Drawing.Size(206, 37);
            this.RBtnSpecifiyServer.TabIndex = 0;
            this.RBtnSpecifiyServer.TabStop = true;
            this.RBtnSpecifiyServer.Tag = "ConnectMode";
            this.RBtnSpecifiyServer.Text = "指定服务器";
            this.RBtnSpecifiyServer.UseVisualStyleBackColor = true;
            this.RBtnSpecifiyServer.CheckedChanged += new System.EventHandler(this.RBtnSpecifiyServer_CheckedChanged);
            // 
            // PlSelectDataBase
            // 
            this.PlSelectDataBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlSelectDataBase.Controls.Add(this.LblOperateTarget);
            this.PlSelectDataBase.Controls.Add(this.ChkOperateView);
            this.PlSelectDataBase.Controls.Add(this.ChkOperateTable);
            this.PlSelectDataBase.Controls.Add(this.LblSelectDataBase);
            this.PlSelectDataBase.Controls.Add(this.LbDataBases);
            this.PlSelectDataBase.Font = new System.Drawing.Font("宋体", 12F);
            this.PlSelectDataBase.Location = new System.Drawing.Point(30, 40);
            this.PlSelectDataBase.Margin = new System.Windows.Forms.Padding(6);
            this.PlSelectDataBase.Name = "PlSelectDataBase";
            this.PlSelectDataBase.Size = new System.Drawing.Size(1166, 777);
            this.PlSelectDataBase.TabIndex = 1;
            this.PlSelectDataBase.TabStop = true;
            this.PlSelectDataBase.Visible = false;
            // 
            // LblOperateTarget
            // 
            this.LblOperateTarget.AutoSize = true;
            this.LblOperateTarget.Location = new System.Drawing.Point(74, 714);
            this.LblOperateTarget.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblOperateTarget.Name = "LblOperateTarget";
            this.LblOperateTarget.Size = new System.Drawing.Size(143, 33);
            this.LblOperateTarget.TabIndex = 4;
            this.LblOperateTarget.Text = "操作对象";
            this.LblOperateTarget.Visible = false;
            // 
            // ChkOperateView
            // 
            this.ChkOperateView.AutoSize = true;
            this.ChkOperateView.Enabled = false;
            this.ChkOperateView.Location = new System.Drawing.Point(372, 714);
            this.ChkOperateView.Margin = new System.Windows.Forms.Padding(6);
            this.ChkOperateView.Name = "ChkOperateView";
            this.ChkOperateView.Size = new System.Drawing.Size(111, 37);
            this.ChkOperateView.TabIndex = 3;
            this.ChkOperateView.Text = "视图";
            this.ChkOperateView.UseVisualStyleBackColor = true;
            this.ChkOperateView.Visible = false;
            // 
            // ChkOperateTable
            // 
            this.ChkOperateTable.AutoSize = true;
            this.ChkOperateTable.Enabled = false;
            this.ChkOperateTable.Location = new System.Drawing.Point(252, 712);
            this.ChkOperateTable.Margin = new System.Windows.Forms.Padding(6);
            this.ChkOperateTable.Name = "ChkOperateTable";
            this.ChkOperateTable.Size = new System.Drawing.Size(79, 37);
            this.ChkOperateTable.TabIndex = 3;
            this.ChkOperateTable.Text = "表";
            this.ChkOperateTable.UseVisualStyleBackColor = true;
            this.ChkOperateTable.Visible = false;
            // 
            // LblSelectDataBase
            // 
            this.LblSelectDataBase.AutoSize = true;
            this.LblSelectDataBase.Location = new System.Drawing.Point(66, 30);
            this.LblSelectDataBase.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblSelectDataBase.Name = "LblSelectDataBase";
            this.LblSelectDataBase.Size = new System.Drawing.Size(175, 33);
            this.LblSelectDataBase.TabIndex = 2;
            this.LblSelectDataBase.Text = "选择数据库";
            // 
            // LbDataBases
            // 
            this.LbDataBases.FormattingEnabled = true;
            this.LbDataBases.ItemHeight = 33;
            this.LbDataBases.Location = new System.Drawing.Point(70, 78);
            this.LbDataBases.Margin = new System.Windows.Forms.Padding(6);
            this.LbDataBases.Name = "LbDataBases";
            this.LbDataBases.Size = new System.Drawing.Size(534, 598);
            this.LbDataBases.TabIndex = 1;
            this.LbDataBases.Click += new System.EventHandler(this.LbDataBases_Click);
            this.LbDataBases.SelectedValueChanged += new System.EventHandler(this.LbDataBases_SelectedValueChanged);
            // 
            // PlSelectDataItem
            // 
            this.PlSelectDataItem.Controls.Add(this.button1);
            this.PlSelectDataItem.Controls.Add(this.listBoxSelectDataBaseItems);
            this.PlSelectDataItem.Controls.Add(this.label2);
            this.PlSelectDataItem.Font = new System.Drawing.Font("宋体", 12F);
            this.PlSelectDataItem.Location = new System.Drawing.Point(30, 40);
            this.PlSelectDataItem.Margin = new System.Windows.Forms.Padding(6);
            this.PlSelectDataItem.Name = "PlSelectDataItem";
            this.PlSelectDataItem.Size = new System.Drawing.Size(1166, 777);
            this.PlSelectDataItem.TabIndex = 3;
            this.PlSelectDataItem.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(978, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "实体类生成";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBoxSelectDataBaseItems
            // 
            this.listBoxSelectDataBaseItems.FormattingEnabled = true;
            this.listBoxSelectDataBaseItems.ItemHeight = 33;
            this.listBoxSelectDataBaseItems.Location = new System.Drawing.Point(73, 67);
            this.listBoxSelectDataBaseItems.Name = "listBoxSelectDataBaseItems";
            this.listBoxSelectDataBaseItems.Size = new System.Drawing.Size(821, 598);
            this.listBoxSelectDataBaseItems.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "选择数据表";
            // 
            // BtnSchemaNext
            // 
            this.BtnSchemaNext.Location = new System.Drawing.Point(840, 838);
            this.BtnSchemaNext.Margin = new System.Windows.Forms.Padding(6);
            this.BtnSchemaNext.Name = "BtnSchemaNext";
            this.BtnSchemaNext.Size = new System.Drawing.Size(150, 46);
            this.BtnSchemaNext.TabIndex = 8;
            this.BtnSchemaNext.Text = "下一步》";
            this.BtnSchemaNext.UseVisualStyleBackColor = true;
            this.BtnSchemaNext.Click += new System.EventHandler(this.BtnSchemaNext_Click);
            // 
            // BtnComplete
            // 
            this.BtnComplete.Location = new System.Drawing.Point(1020, 838);
            this.BtnComplete.Margin = new System.Windows.Forms.Padding(6);
            this.BtnComplete.Name = "BtnComplete";
            this.BtnComplete.Size = new System.Drawing.Size(150, 46);
            this.BtnComplete.TabIndex = 7;
            this.BtnComplete.Text = "退出";
            this.BtnComplete.UseVisualStyleBackColor = true;
            this.BtnComplete.Click += new System.EventHandler(this.BtnComplete_Click);
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Location = new System.Drawing.Point(656, 838);
            this.BtnPrevious.Margin = new System.Windows.Forms.Padding(6);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(150, 46);
            this.BtnPrevious.TabIndex = 8;
            this.BtnPrevious.Text = "《上一步";
            this.BtnPrevious.UseVisualStyleBackColor = true;
            this.BtnPrevious.Visible = false;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // PlSetOption
            // 
            this.PlSetOption.Location = new System.Drawing.Point(30, 40);
            this.PlSetOption.Margin = new System.Windows.Forms.Padding(6);
            this.PlSetOption.Name = "PlSetOption";
            this.PlSetOption.Size = new System.Drawing.Size(1166, 777);
            this.PlSetOption.TabIndex = 9;
            this.PlSetOption.Visible = false;
            // 
            // PlExecMessage
            // 
            this.PlExecMessage.Controls.Add(this.TxtExecMessage);
            this.PlExecMessage.Location = new System.Drawing.Point(30, 40);
            this.PlExecMessage.Margin = new System.Windows.Forms.Padding(6);
            this.PlExecMessage.Name = "PlExecMessage";
            this.PlExecMessage.Size = new System.Drawing.Size(1166, 777);
            this.PlExecMessage.TabIndex = 10;
            this.PlExecMessage.Visible = false;
            // 
            // TxtExecMessage
            // 
            this.TxtExecMessage.Location = new System.Drawing.Point(44, 44);
            this.TxtExecMessage.Margin = new System.Windows.Forms.Padding(6);
            this.TxtExecMessage.Multiline = true;
            this.TxtExecMessage.Name = "TxtExecMessage";
            this.TxtExecMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtExecMessage.Size = new System.Drawing.Size(1066, 700);
            this.TxtExecMessage.TabIndex = 0;
            // 
            // FormMake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 915);
            this.Controls.Add(this.BtnPrevious);
            this.Controls.Add(this.BtnSchemaNext);
            this.Controls.Add(this.BtnComplete);
            this.Controls.Add(this.PlSetOption);
            this.Controls.Add(this.PlExecMessage);
            this.Controls.Add(this.PanelConect);
            this.Controls.Add(this.PlSelectDataBase);
            this.Controls.Add(this.PlSelectDataItem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormMake";
            this.Text = "Sop数据库 V1.0";
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
        private System.Windows.Forms.CheckBox ChkOperateTable;
        private System.Windows.Forms.CheckBox ChkOperateView;
        private System.Windows.Forms.Panel PlSetOption;
        private System.Windows.Forms.Panel PlExecMessage;
        private System.Windows.Forms.TextBox TxtExecMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_dbType;
        private System.Windows.Forms.ListBox listBoxSelectDataBaseItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}
