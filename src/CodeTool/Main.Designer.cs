namespace CodeTool
{
    partial class Main
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.File_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.DataRemoval_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.EntityGeneration_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.Edit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.btnTemp = new System.Windows.Forms.Button();
      this.btnUnicode = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_ToolStripMenuItem,
            this.Edit_ToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
      this.menuStrip1.Size = new System.Drawing.Size(850, 34);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // File_ToolStripMenuItem
      // 
      this.File_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DataRemoval_ToolStripMenuItem,
            this.EntityGeneration_ToolStripMenuItem});
      this.File_ToolStripMenuItem.Name = "File_ToolStripMenuItem";
      this.File_ToolStripMenuItem.Size = new System.Drawing.Size(80, 28);
      this.File_ToolStripMenuItem.Text = "功能(&F)";
      // 
      // DataRemoval_ToolStripMenuItem
      // 
      this.DataRemoval_ToolStripMenuItem.Name = "DataRemoval_ToolStripMenuItem";
      this.DataRemoval_ToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
      this.DataRemoval_ToolStripMenuItem.Text = "数据迁移工具";
      this.DataRemoval_ToolStripMenuItem.Click += new System.EventHandler(this.DataRemoval_ToolStripMenuItem_Click);
      // 
      // EntityGeneration_ToolStripMenuItem
      // 
      this.EntityGeneration_ToolStripMenuItem.Name = "EntityGeneration_ToolStripMenuItem";
      this.EntityGeneration_ToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
      this.EntityGeneration_ToolStripMenuItem.Text = "实体生成工具";
      this.EntityGeneration_ToolStripMenuItem.Click += new System.EventHandler(this.EntityGeneration_ToolStripMenuItem_Click);
      // 
      // Edit_ToolStripMenuItem
      // 
      this.Edit_ToolStripMenuItem.Name = "Edit_ToolStripMenuItem";
      this.Edit_ToolStripMenuItem.Size = new System.Drawing.Size(80, 28);
      this.Edit_ToolStripMenuItem.Text = "编辑(&E)";
      // 
      // btnTemp
      // 
      this.btnTemp.Font = new System.Drawing.Font("宋体", 22F);
      this.btnTemp.Location = new System.Drawing.Point(13, 165);
      this.btnTemp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btnTemp.Name = "btnTemp";
      this.btnTemp.Size = new System.Drawing.Size(218, 93);
      this.btnTemp.TabIndex = 1;
      this.btnTemp.Text = "简单模板";
      this.btnTemp.UseVisualStyleBackColor = true;
      this.btnTemp.Click += new System.EventHandler(this.btnTemp_Click);
      // 
      // btnUnicode
      // 
      this.btnUnicode.Font = new System.Drawing.Font("宋体", 22F);
      this.btnUnicode.Location = new System.Drawing.Point(13, 53);
      this.btnUnicode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btnUnicode.Name = "btnUnicode";
      this.btnUnicode.Size = new System.Drawing.Size(218, 93);
      this.btnUnicode.TabIndex = 2;
      this.btnUnicode.Text = "编码";
      this.btnUnicode.UseVisualStyleBackColor = true;
      this.btnUnicode.Click += new System.EventHandler(this.btnUnicode_Click);
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("宋体", 22F);
      this.button1.Location = new System.Drawing.Point(346, 53);
      this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(342, 93);
      this.button1.TabIndex = 1;
      this.button1.Text = "待开发模板";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(850, 624);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.btnTemp);
      this.Controls.Add(this.btnUnicode);
      this.Controls.Add(this.menuStrip1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Main";
      this.Text = "数据操作辅助设计工具";
      this.Load += new System.EventHandler(this.Main_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DataRemoval_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EntityGeneration_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Edit_ToolStripMenuItem;
        private System.Windows.Forms.Button btnTemp;
        private System.Windows.Forms.Button btnUnicode;
        private System.Windows.Forms.Button button1;
    }
}