namespace CodeTool.Forms
{
    partial class DatabaseForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddDatabase = new System.Windows.Forms.ToolStripLabel();
            this.btnRemoveDatabase = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tvDatabase = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmsTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuRunSql = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeleteClickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增肌记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCreateCode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.cmsDB = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuBrowseDB = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeleteDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生成存储过程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生成数据脚本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生成数据库文档ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出数据库脚本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.结构文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据结构文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuCreateCode1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSelect1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUpdate1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelete1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInsert1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.cmsTable.SuspendLayout();
            this.cmsDB.SuspendLayout();
            this.cmsView.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddDatabase,
            this.btnRemoveDatabase,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(378, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddDatabase
            // 
            this.btnAddDatabase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddDatabase.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.btnAddDatabase.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDatabase.Image")));
            this.btnAddDatabase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddDatabase.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddDatabase.Name = "btnAddDatabase";
            this.btnAddDatabase.Size = new System.Drawing.Size(24, 31);
            this.btnAddDatabase.ToolTipText = "添加数据库";
            this.btnAddDatabase.Click += new System.EventHandler(this.btnAddDatabase_Click);
            // 
            // btnRemoveDatabase
            // 
            this.btnRemoveDatabase.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.btnRemoveDatabase.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveDatabase.Image")));
            this.btnRemoveDatabase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemoveDatabase.Name = "btnRemoveDatabase";
            this.btnRemoveDatabase.Size = new System.Drawing.Size(28, 28);
            this.btnRemoveDatabase.ToolTipText = "移除数据库";
            this.btnRemoveDatabase.Click += new System.EventHandler(this.btnRemoveDatabase_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // tvDatabase
            // 
            this.tvDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvDatabase.ImageIndex = 0;
            this.tvDatabase.ImageList = this.imageList1;
            this.tvDatabase.Location = new System.Drawing.Point(0, 31);
            this.tvDatabase.Margin = new System.Windows.Forms.Padding(5);
            this.tvDatabase.Name = "tvDatabase";
            this.tvDatabase.SelectedImageIndex = 0;
            this.tvDatabase.Size = new System.Drawing.Size(378, 863);
            this.tvDatabase.TabIndex = 1;
            this.tvDatabase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tvDatabase_MouseDown);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "close-data.png");
            this.imageList1.Images.SetKeyName(1, "close-database.png");
            this.imageList1.Images.SetKeyName(2, "close-field.png");
            this.imageList1.Images.SetKeyName(3, "close-folder.png");
            this.imageList1.Images.SetKeyName(4, "close-function.png");
            this.imageList1.Images.SetKeyName(5, "close-parameter.png");
            this.imageList1.Images.SetKeyName(6, "close-table.png");
            this.imageList1.Images.SetKeyName(7, "close-tables.png");
            this.imageList1.Images.SetKeyName(8, "close-view.png");
            this.imageList1.Images.SetKeyName(9, "close-zz.png");
            this.imageList1.Images.SetKeyName(10, "open-data.png");
            this.imageList1.Images.SetKeyName(11, "open-database.png");
            this.imageList1.Images.SetKeyName(12, "open-field.png");
            this.imageList1.Images.SetKeyName(13, "open-folder.png");
            this.imageList1.Images.SetKeyName(14, "open-function.png");
            this.imageList1.Images.SetKeyName(15, "open-parameter.png");
            this.imageList1.Images.SetKeyName(16, "open-table.png");
            this.imageList1.Images.SetKeyName(17, "open-tables.png");
            this.imageList1.Images.SetKeyName(18, "open-view.png");
            this.imageList1.Images.SetKeyName(19, "open-zz.png");
            // 
            // cmsTable
            // 
            this.cmsTable.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRunSql,
            this.menuCreateCode});
            this.cmsTable.Name = "contextMenuStrip1";
            this.cmsTable.Size = new System.Drawing.Size(153, 60);
            // 
            // menuRunSql
            // 
            this.menuRunSql.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSelect,
            this.menuUpdateToolStripMenuItem,
            this.menuDeleteClickToolStripMenuItem,
            this.增肌记录ToolStripMenuItem});
            this.menuRunSql.Name = "menuRunSql";
            this.menuRunSql.Size = new System.Drawing.Size(152, 28);
            this.menuRunSql.Text = "执行SQL";
            this.menuRunSql.Click += new System.EventHandler(this.menuRunSql_Click);
            // 
            // menuSelect
            // 
            this.menuSelect.Name = "menuSelect";
            this.menuSelect.Size = new System.Drawing.Size(164, 30);
            this.menuSelect.Text = "查询记录";
            this.menuSelect.Click += new System.EventHandler(this.menuSelect_Click);
            // 
            // menuUpdateToolStripMenuItem
            // 
            this.menuUpdateToolStripMenuItem.Name = "menuUpdateToolStripMenuItem";
            this.menuUpdateToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.menuUpdateToolStripMenuItem.Text = "修改记录";
            this.menuUpdateToolStripMenuItem.Click += new System.EventHandler(this.menuUpdate_Click);
            // 
            // menuDeleteClickToolStripMenuItem
            // 
            this.menuDeleteClickToolStripMenuItem.Name = "menuDeleteClickToolStripMenuItem";
            this.menuDeleteClickToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.menuDeleteClickToolStripMenuItem.Text = "删除记录";
            this.menuDeleteClickToolStripMenuItem.Click += new System.EventHandler(this.menuDelete_Click);
            // 
            // 增肌记录ToolStripMenuItem
            // 
            this.增肌记录ToolStripMenuItem.Name = "增肌记录ToolStripMenuItem";
            this.增肌记录ToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.增肌记录ToolStripMenuItem.Text = "增肌记录";
            this.增肌记录ToolStripMenuItem.Click += new System.EventHandler(this.menuInsert_Click);
            // 
            // menuCreateCode
            // 
            this.menuCreateCode.Name = "menuCreateCode";
            this.menuCreateCode.Size = new System.Drawing.Size(152, 28);
            this.menuCreateCode.Text = "生成代码";
            this.menuCreateCode.Click += new System.EventHandler(this.menuCreateCode_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // cmsDB
            // 
            this.cmsDB.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsDB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBrowseDB,
            this.menuDeleteDatabase,
            this.刷新数据库ToolStripMenuItem,
            this.新建查询ToolStripMenuItem,
            this.生成存储过程ToolStripMenuItem,
            this.生成数据脚本ToolStripMenuItem,
            this.生成数据库文档ToolStripMenuItem,
            this.导出数据库脚本ToolStripMenuItem,
            this.menuOutput});
            this.cmsDB.Name = "cmsDB";
            this.cmsDB.Size = new System.Drawing.Size(215, 274);
            // 
            // menuBrowseDB
            // 
            this.menuBrowseDB.Name = "menuBrowseDB";
            this.menuBrowseDB.Size = new System.Drawing.Size(214, 30);
            this.menuBrowseDB.Text = "浏览数据库";
            this.menuBrowseDB.Click += new System.EventHandler(this.menuBrowseDB_Click);
            // 
            // menuDeleteDatabase
            // 
            this.menuDeleteDatabase.Name = "menuDeleteDatabase";
            this.menuDeleteDatabase.Size = new System.Drawing.Size(214, 30);
            this.menuDeleteDatabase.Text = "注销数据库";
            this.menuDeleteDatabase.Click += new System.EventHandler(this.menuDeleteDatabase_Click);
            // 
            // 刷新数据库ToolStripMenuItem
            // 
            this.刷新数据库ToolStripMenuItem.Name = "刷新数据库ToolStripMenuItem";
            this.刷新数据库ToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.刷新数据库ToolStripMenuItem.Text = "刷新数据库";
            // 
            // 新建查询ToolStripMenuItem
            // 
            this.新建查询ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("新建查询ToolStripMenuItem.Image")));
            this.新建查询ToolStripMenuItem.Name = "新建查询ToolStripMenuItem";
            this.新建查询ToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.新建查询ToolStripMenuItem.Text = "新建查询";
            this.新建查询ToolStripMenuItem.Click += new System.EventHandler(this.新建查询ToolStripMenuItem_Click);
            // 
            // 生成存储过程ToolStripMenuItem
            // 
            this.生成存储过程ToolStripMenuItem.Name = "生成存储过程ToolStripMenuItem";
            this.生成存储过程ToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.生成存储过程ToolStripMenuItem.Text = "生成存储过程";
            // 
            // 生成数据脚本ToolStripMenuItem
            // 
            this.生成数据脚本ToolStripMenuItem.Name = "生成数据脚本ToolStripMenuItem";
            this.生成数据脚本ToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.生成数据脚本ToolStripMenuItem.Text = "生成数据脚本";
            // 
            // 生成数据库文档ToolStripMenuItem
            // 
            this.生成数据库文档ToolStripMenuItem.Name = "生成数据库文档ToolStripMenuItem";
            this.生成数据库文档ToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.生成数据库文档ToolStripMenuItem.Text = "生成数据库文档";
            // 
            // 导出数据库脚本ToolStripMenuItem
            // 
            this.导出数据库脚本ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.结构文件ToolStripMenuItem,
            this.数据文件ToolStripMenuItem,
            this.数据结构文件ToolStripMenuItem});
            this.导出数据库脚本ToolStripMenuItem.Name = "导出数据库脚本ToolStripMenuItem";
            this.导出数据库脚本ToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.导出数据库脚本ToolStripMenuItem.Text = "导出数据库脚本";
            // 
            // 结构文件ToolStripMenuItem
            // 
            this.结构文件ToolStripMenuItem.Name = "结构文件ToolStripMenuItem";
            this.结构文件ToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.结构文件ToolStripMenuItem.Text = "结构文件";
            // 
            // 数据文件ToolStripMenuItem
            // 
            this.数据文件ToolStripMenuItem.Name = "数据文件ToolStripMenuItem";
            this.数据文件ToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.数据文件ToolStripMenuItem.Text = "数据文件";
            // 
            // 数据结构文件ToolStripMenuItem
            // 
            this.数据结构文件ToolStripMenuItem.Name = "数据结构文件ToolStripMenuItem";
            this.数据结构文件ToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.数据结构文件ToolStripMenuItem.Text = "数据结构文件";
            // 
            // menuOutput
            // 
            this.menuOutput.Name = "menuOutput";
            this.menuOutput.Size = new System.Drawing.Size(214, 30);
            this.menuOutput.Text = "输出代码";
            this.menuOutput.Click += new System.EventHandler(this.menuOutput_Click);
            // 
            // cmsView
            // 
            this.cmsView.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCreateCode1,
            this.menuSelect1,
            this.menuUpdate1,
            this.menuDelete1,
            this.menuInsert1});
            this.cmsView.Name = "cmsView";
            this.cmsView.Size = new System.Drawing.Size(153, 144);
            // 
            // menuCreateCode1
            // 
            this.menuCreateCode1.Name = "menuCreateCode1";
            this.menuCreateCode1.Size = new System.Drawing.Size(152, 28);
            this.menuCreateCode1.Text = "生成代码";
            this.menuCreateCode1.Click += new System.EventHandler(this.menuCreateCode_Click);
            // 
            // menuSelect1
            // 
            this.menuSelect1.Name = "menuSelect1";
            this.menuSelect1.Size = new System.Drawing.Size(152, 28);
            this.menuSelect1.Text = "查询记录";
            this.menuSelect1.Click += new System.EventHandler(this.menuSelect_Click);
            // 
            // menuUpdate1
            // 
            this.menuUpdate1.Name = "menuUpdate1";
            this.menuUpdate1.Size = new System.Drawing.Size(152, 28);
            this.menuUpdate1.Text = "修改记录";
            this.menuUpdate1.Click += new System.EventHandler(this.menuUpdate_Click);
            // 
            // menuDelete1
            // 
            this.menuDelete1.Name = "menuDelete1";
            this.menuDelete1.Size = new System.Drawing.Size(152, 28);
            this.menuDelete1.Text = "删除记录";
            this.menuDelete1.Click += new System.EventHandler(this.menuDelete_Click);
            // 
            // menuInsert1
            // 
            this.menuInsert1.Name = "menuInsert1";
            this.menuInsert1.Size = new System.Drawing.Size(152, 28);
            this.menuInsert1.Text = "增加记录";
            this.menuInsert1.Click += new System.EventHandler(this.menuInsert_Click);
            // 
            // DatabaseForm
            // 
            this.AutoHidePortion = 0.2D;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 894);
            this.Controls.Add(this.tvDatabase);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DatabaseForm";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.DockLeft;
            this.TabText = "数据库";
            this.Text = "数据库";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.cmsTable.ResumeLayout(false);
            this.cmsDB.ResumeLayout(false);
            this.cmsView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TreeView tvDatabase;
        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ContextMenuStrip cmsTable;
        public System.Windows.Forms.ToolStripMenuItem menuCreateCode;
        public System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.ToolStripButton toolStripButton1;
        public System.Windows.Forms.ContextMenuStrip cmsDB;
        public System.Windows.Forms.ToolStripMenuItem menuOutput;
        public System.Windows.Forms.ToolStripMenuItem menuDeleteDatabase;
        public System.Windows.Forms.ContextMenuStrip cmsView;
        public System.Windows.Forms.ToolStripMenuItem menuCreateCode1;
        public System.Windows.Forms.ToolStripButton btnRemoveDatabase;
        public System.Windows.Forms.ToolStripMenuItem menuRunSql;
        public System.Windows.Forms.ToolStripMenuItem menuSelect1;
        public System.Windows.Forms.ToolStripMenuItem menuUpdate1;
        public System.Windows.Forms.ToolStripMenuItem menuDelete1;
        public System.Windows.Forms.ToolStripMenuItem menuInsert1;
        public System.Windows.Forms.ToolStripMenuItem menuSelect;
        public System.Windows.Forms.ToolStripMenuItem menuUpdateToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem menuDeleteClickToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 增肌记录ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 刷新数据库ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 新建查询ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 生成存储过程ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 生成数据脚本ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 生成数据库文档ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 导出数据库脚本ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 结构文件ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 数据文件ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem menuBrowseDB;
        public System.Windows.Forms.ToolStripMenuItem 数据结构文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        public System.Windows.Forms.ToolStripLabel btnAddDatabase;
    }
}