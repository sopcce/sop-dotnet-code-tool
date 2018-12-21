using CodeTool.UserControls;

namespace CodeTool
{
    partial class OutputCodeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutputCodeForm));
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.btnOutputCode = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.selectTableUserControl1 = new CodeTool.UserControls.SelectTableUserControl();
            this.selectTemplateUserControl1 = new CodeTool.UserControls.SelectTemplateUserControl();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(30, 48);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(847, 28);
            this.txtPath.TabIndex = 0;
            this.txtPath.Text = "C:\\";
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSelectPath.Location = new System.Drawing.Point(880, 45);
            this.btnSelectPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(51, 34);
            this.btnSelectPath.TabIndex = 1;
            this.btnSelectPath.Text = "...";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // btnOutputCode
            // 
            this.btnOutputCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOutputCode.Location = new System.Drawing.Point(940, 45);
            this.btnOutputCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOutputCode.Name = "btnOutputCode";
            this.btnOutputCode.Size = new System.Drawing.Size(112, 34);
            this.btnOutputCode.TabIndex = 2;
            this.btnOutputCode.Text = "输出代码";
            this.btnOutputCode.UseVisualStyleBackColor = true;
            this.btnOutputCode.Click += new System.EventHandler(this.btnOutputCode_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 689);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1062, 28);
            this.progressBar1.TabIndex = 21;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPath);
            this.groupBox4.Controls.Add(this.btnOutputCode);
            this.groupBox4.Controls.Add(this.btnSelectPath);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(1062, 116);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "输出路径";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 573);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 116);
            this.panel1.TabIndex = 37;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.selectTableUserControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.selectTemplateUserControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1062, 573);
            this.splitContainer1.SplitterDistance = 700;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 39;
            // 
            // selectTableUserControl1
            // 
            this.selectTableUserControl1.Db = null;
            this.selectTableUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectTableUserControl1.Location = new System.Drawing.Point(0, 0);
            this.selectTableUserControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.selectTableUserControl1.Name = "selectTableUserControl1";
            this.selectTableUserControl1.Size = new System.Drawing.Size(700, 573);
            this.selectTableUserControl1.TabIndex = 4;
            // 
            // selectTemplateUserControl1
            // 
            this.selectTemplateUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectTemplateUserControl1.Location = new System.Drawing.Point(0, 0);
            this.selectTemplateUserControl1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.selectTemplateUserControl1.Name = "selectTemplateUserControl1";
            this.selectTemplateUserControl1.Size = new System.Drawing.Size(356, 573);
            this.selectTemplateUserControl1.TabIndex = 0;
            this.selectTemplateUserControl1.ShowReadmeOfTemplate += new System.Action<string>(this.selectTemplateUserControl1_ShowReadmeOfTemplate);
            // 
            // OutputCodeForm
            // 
            this.AcceptButton = this.btnOutputCode;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 717);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OutputCodeForm";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.Document;
            this.TabText = "输出代码";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.Button btnOutputCode;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
        private SelectTableUserControl selectTableUserControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private SelectTemplateUserControl selectTemplateUserControl1;
    }
}

