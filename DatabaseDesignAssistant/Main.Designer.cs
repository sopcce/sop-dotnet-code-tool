namespace Sop.DatabaseDesignAssistant
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_ToolStripMenuItem,
            this.Edit_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(567, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File_ToolStripMenuItem
            // 
            this.File_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DataRemoval_ToolStripMenuItem,
            this.EntityGeneration_ToolStripMenuItem});
            this.File_ToolStripMenuItem.Name = "File_ToolStripMenuItem";
            this.File_ToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.File_ToolStripMenuItem.Text = "功能(&F)";
            // 
            // DataRemoval_ToolStripMenuItem
            // 
            this.DataRemoval_ToolStripMenuItem.Name = "DataRemoval_ToolStripMenuItem";
            this.DataRemoval_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DataRemoval_ToolStripMenuItem.Text = "数据迁移工具";
            this.DataRemoval_ToolStripMenuItem.Click += new System.EventHandler(this.DataRemoval_ToolStripMenuItem_Click);
            // 
            // EntityGeneration_ToolStripMenuItem
            // 
            this.EntityGeneration_ToolStripMenuItem.Name = "EntityGeneration_ToolStripMenuItem";
            this.EntityGeneration_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.EntityGeneration_ToolStripMenuItem.Text = "实体生成工具";
            this.EntityGeneration_ToolStripMenuItem.Click += new System.EventHandler(this.EntityGeneration_ToolStripMenuItem_Click);
            // 
            // Edit_ToolStripMenuItem
            // 
            this.Edit_ToolStripMenuItem.Name = "Edit_ToolStripMenuItem";
            this.Edit_ToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.Edit_ToolStripMenuItem.Text = "编辑(&E)";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 416);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "数据操作辅助设计工具";
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
    }
}