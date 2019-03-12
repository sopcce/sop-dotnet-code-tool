namespace RandomCheck
{
    partial class AddStdInfo
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
            this.NamesView = new System.Windows.Forms.DataGridView();
            this.StdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.butModify = new System.Windows.Forms.Button();
            this.cboxFileDb = new System.Windows.Forms.ComboBox();
            this.butSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxfilename = new System.Windows.Forms.TextBox();
            this.butDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NamesView)).BeginInit();
            this.SuspendLayout();
            // 
            // NamesView
            // 
            this.NamesView.AllowDrop = true;
            this.NamesView.AllowUserToResizeColumns = false;
            this.NamesView.AllowUserToResizeRows = false;
            this.NamesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NamesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StdName,
            this.Del});
            this.NamesView.Location = new System.Drawing.Point(10, 44);
            this.NamesView.Name = "NamesView";
            this.NamesView.RowTemplate.Height = 23;
            this.NamesView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.NamesView.Size = new System.Drawing.Size(283, 379);
            this.NamesView.TabIndex = 0;
            this.NamesView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.NamesView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.NamesView_CellEndEdit);
            // 
            // StdName
            // 
            this.StdName.HeaderText = "学员姓名";
            this.StdName.Name = "StdName";
            this.StdName.Width = 200;
            // 
            // Del
            // 
            this.Del.HeaderText = "删除";
            this.Del.Name = "Del";
            this.Del.ReadOnly = true;
            this.Del.Text = "删除";
            this.Del.UseColumnTextForButtonValue = true;
            this.Del.Width = 40;
            // 
            // butModify
            // 
            this.butModify.Location = new System.Drawing.Point(237, 4);
            this.butModify.Name = "butModify";
            this.butModify.Size = new System.Drawing.Size(56, 23);
            this.butModify.TabIndex = 1;
            this.butModify.Text = "修改";
            this.butModify.UseVisualStyleBackColor = true;
            this.butModify.Click += new System.EventHandler(this.butModify_Click);
            // 
            // cboxFileDb
            // 
            this.cboxFileDb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxFileDb.FormattingEnabled = true;
            this.cboxFileDb.Location = new System.Drawing.Point(10, 4);
            this.cboxFileDb.Name = "cboxFileDb";
            this.cboxFileDb.Size = new System.Drawing.Size(155, 20);
            this.cboxFileDb.TabIndex = 2;
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(216, 429);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(77, 23);
            this.butSave.TabIndex = 3;
            this.butSave.Text = "保存";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "系统名：";
            // 
            // tboxfilename
            // 
            this.tboxfilename.Location = new System.Drawing.Point(67, 430);
            this.tboxfilename.Name = "tboxfilename";
            this.tboxfilename.Size = new System.Drawing.Size(143, 21);
            this.tboxfilename.TabIndex = 5;
            // 
            // butDel
            // 
            this.butDel.Location = new System.Drawing.Point(171, 4);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(56, 23);
            this.butDel.TabIndex = 6;
            this.butDel.Text = "删除";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // AddStdInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 464);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.tboxfilename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.cboxFileDb);
            this.Controls.Add(this.butModify);
            this.Controls.Add(this.NamesView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddStdInfo";
            this.ShowIcon = false;
            this.Text = "AddStdInfo";
            this.Load += new System.EventHandler(this.AddStdInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NamesView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView NamesView;
        private System.Windows.Forms.Button butModify;
        private System.Windows.Forms.ComboBox cboxFileDb;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxfilename;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn StdName;
        private System.Windows.Forms.DataGridViewButtonColumn Del;
    }
}