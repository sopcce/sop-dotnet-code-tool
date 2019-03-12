namespace RandomCheck
{
    partial class Form1
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
            this.lboxHaveNot = new System.Windows.Forms.ListBox();
            this.lboxHave = new System.Windows.Forms.ListBox();
            this.rdmcheck = new System.Windows.Forms.Button();
            this.StdName = new System.Windows.Forms.Label();
            this.butreset = new System.Windows.Forms.Button();
            this.cboxStdSys = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butAddSys = new System.Windows.Forms.Button();
            this.lbSever = new System.Windows.Forms.ListBox();
            this.lbSelect = new System.Windows.Forms.ListBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.labItems = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lboxHaveNot
            // 
            this.lboxHaveNot.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lboxHaveNot.ForeColor = System.Drawing.Color.LimeGreen;
            this.lboxHaveNot.FormattingEnabled = true;
            this.lboxHaveNot.ItemHeight = 16;
            this.lboxHaveNot.Location = new System.Drawing.Point(12, 49);
            this.lboxHaveNot.Name = "lboxHaveNot";
            this.lboxHaveNot.Size = new System.Drawing.Size(164, 196);
            this.lboxHaveNot.TabIndex = 0;
            this.lboxHaveNot.SelectedIndexChanged += new System.EventHandler(this.lboxHaveNot_SelectedIndexChanged);
            // 
            // lboxHave
            // 
            this.lboxHave.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lboxHave.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lboxHave.FormattingEnabled = true;
            this.lboxHave.ItemHeight = 16;
            this.lboxHave.Location = new System.Drawing.Point(246, 49);
            this.lboxHave.Name = "lboxHave";
            this.lboxHave.Size = new System.Drawing.Size(164, 196);
            this.lboxHave.TabIndex = 3;
            // 
            // rdmcheck
            // 
            this.rdmcheck.Font = new System.Drawing.Font("黑体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdmcheck.Location = new System.Drawing.Point(182, 49);
            this.rdmcheck.Name = "rdmcheck";
            this.rdmcheck.Size = new System.Drawing.Size(58, 453);
            this.rdmcheck.TabIndex = 4;
            this.rdmcheck.Text = "下一位";
            this.rdmcheck.UseVisualStyleBackColor = true;
            this.rdmcheck.Click += new System.EventHandler(this.rdmcheck_Click);
            // 
            // StdName
            // 
            this.StdName.AutoSize = true;
            this.StdName.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StdName.ForeColor = System.Drawing.Color.Red;
            this.StdName.Location = new System.Drawing.Point(12, 12);
            this.StdName.Name = "StdName";
            this.StdName.Size = new System.Drawing.Size(54, 21);
            this.StdName.TabIndex = 5;
            this.StdName.Text = "name";
            // 
            // butreset
            // 
            this.butreset.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butreset.Location = new System.Drawing.Point(335, 12);
            this.butreset.Name = "butreset";
            this.butreset.Size = new System.Drawing.Size(75, 23);
            this.butreset.TabIndex = 6;
            this.butreset.Text = "重置";
            this.butreset.UseVisualStyleBackColor = true;
            this.butreset.Click += new System.EventHandler(this.butreset_Click);
            // 
            // cboxStdSys
            // 
            this.cboxStdSys.FormattingEnabled = true;
            this.cboxStdSys.Location = new System.Drawing.Point(108, 522);
            this.cboxStdSys.Name = "cboxStdSys";
            this.cboxStdSys.Size = new System.Drawing.Size(197, 20);
            this.cboxStdSys.TabIndex = 8;
            this.cboxStdSys.SelectionChangeCommitted += new System.EventHandler(this.cboxStdSys_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 527);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "可选学员系统：";
            // 
            // butAddSys
            // 
            this.butAddSys.Location = new System.Drawing.Point(335, 520);
            this.butAddSys.Name = "butAddSys";
            this.butAddSys.Size = new System.Drawing.Size(75, 23);
            this.butAddSys.TabIndex = 10;
            this.butAddSys.Text = "增加学员系统";
            this.butAddSys.UseVisualStyleBackColor = true;
            this.butAddSys.Click += new System.EventHandler(this.butAddSys_Click);
            // 
            // lbSever
            // 
            this.lbSever.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSever.ForeColor = System.Drawing.Color.Lime;
            this.lbSever.FormattingEnabled = true;
            this.lbSever.ItemHeight = 16;
            this.lbSever.Location = new System.Drawing.Point(12, 290);
            this.lbSever.Name = "lbSever";
            this.lbSever.Size = new System.Drawing.Size(164, 212);
            this.lbSever.TabIndex = 11;

            // 
            // lbSelect
            // 
            this.lbSelect.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSelect.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbSelect.FormattingEnabled = true;
            this.lbSelect.ItemHeight = 16;
            this.lbSelect.Location = new System.Drawing.Point(241, 290);
            this.lbSelect.Name = "lbSelect";
            this.lbSelect.Size = new System.Drawing.Size(164, 212);
            this.lbSelect.TabIndex = 12;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReset.Location = new System.Drawing.Point(325, 261);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 23);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "启用试题";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // labItems
            // 
            this.labItems.AutoSize = true;
            this.labItems.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labItems.ForeColor = System.Drawing.Color.Red;
            this.labItems.Location = new System.Drawing.Point(12, 261);
            this.labItems.Name = "labItems";
            this.labItems.Size = new System.Drawing.Size(54, 21);
            this.labItems.TabIndex = 14;
            this.labItems.Text = "name";
            // 
            // Form1
            // 
            this.AcceptButton = this.rdmcheck;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 548);
            this.Controls.Add(this.labItems);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lbSelect);
            this.Controls.Add(this.lbSever);
            this.Controls.Add(this.butAddSys);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxStdSys);
            this.Controls.Add(this.butreset);
            this.Controls.Add(this.StdName);
            this.Controls.Add(this.rdmcheck);
            this.Controls.Add(this.lboxHave);
            this.Controls.Add(this.lboxHaveNot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "随机提问系统V2.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxHaveNot;
        private System.Windows.Forms.ListBox lboxHave;
        private System.Windows.Forms.Button rdmcheck;
        private System.Windows.Forms.Label StdName;
        private System.Windows.Forms.Button butreset;
        private System.Windows.Forms.ComboBox cboxStdSys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butAddSys;
        private System.Windows.Forms.ListBox lbSever;
        private System.Windows.Forms.ListBox lbSelect;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label labItems;
    }
}

