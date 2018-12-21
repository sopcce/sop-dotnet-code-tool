using System;
using System.Drawing;
using System.Windows.Forms;
using CodeTool.Common.Model;
using CodeTool.Config;
using CodeTool.Forms.Open;
using WeifenLuo.WinFormsUI.Docking;

//using CodeTool.Forms;

namespace CodeTool.Forms
{
    public partial class DatabaseForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public event Action<Database> OutputCode;

        public event Action<Table> CreateCode;

        public event Action<string> ShowStatus;

        public event Action<Database, Table> DataInfo;


        public DatabaseForm()
        {
            InitializeComponent();
        }

        #region 添加移除数据库
        private void btnAddDatabase_Click(object sender, EventArgs e)
        {
            ConnectionForm frm = new ConnectionForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Database database = frm.database;
                ShowDatabase(database);
            }
        }

        private void btnRemoveDatabase_Click(object sender, EventArgs e)
        {
            TreeNode node = tvDatabase.SelectedNode;
            if (node == null) { return; }
            while (node.Level > 0)
            {
                node = node.Parent;
            }
            tvDatabase.Nodes.Remove(node);
        }
        #endregion

        #region  V&P&T 加载节点
        /// <summary>
        /// 显示第一级节点：数据库
        /// </summary>
        private void ShowDatabase(Database database)
        {
            //TODO: ICO
            TreeNode nodeDB = new TreeNode(
                string.Format("{0}－{1}",
                    database.Name,
                    database.TypeDescn),
                0, 10);
            nodeDB.Tag = database;
            nodeDB.ContextMenuStrip = cmsDB;
            this.tvDatabase.Nodes.Add(nodeDB);




            ShowFolders(database, nodeDB);
            nodeDB.Expand();
        }

        /// <summary>
        /// 显示第二级节点：表，视图，存储过程文件夹
        /// </summary>
        private void ShowFolders(Database db, TreeNode nodeRoot)
        {
            //添加“表”文件夹
            TreeNode nodeTableFolder = new TreeNode("表", 7, 17);
            nodeRoot.Nodes.Add(nodeTableFolder);


            //添加表
            ShowTables(db, nodeTableFolder);
            nodeTableFolder.Expand();

            //添加“视图”文件夹
            TreeNode nodeViewFolder = new TreeNode("视图", 8, 18);
            nodeRoot.Nodes.Add(nodeViewFolder);

            //添加视图
            ShowViews(db, nodeViewFolder);

            //添加“存储过程”文件夹
            TreeNode nodeStoreProceduresFolder = new TreeNode("存储过程", 4, 14);
            nodeRoot.Nodes.Add(nodeStoreProceduresFolder);

            //添加存储过程
            ShowStoreProcedures(db, nodeStoreProceduresFolder);
        }

        /// <summary>
        /// 显示第三级节点：表
        /// </summary>
        private void ShowTables(Database database, TreeNode nodeRoot)
        {
            foreach (Table table in database.Tables)
            {
                TreeNode nodeTable = new TreeNode(table.Name, 6, 16);
                nodeTable.Tag = table;
                nodeTable.ContextMenuStrip = cmsTable;
                nodeRoot.Nodes.Add(nodeTable);

                ShowFields(table, nodeTable);
            }
        }

        /// <summary>
        /// 显示第三级节点：视图
        /// </summary>
        private void ShowViews(Database database, TreeNode nodeRoot)
        {
            foreach (Table table in database.Views)
            {
                TreeNode nodeTable = new TreeNode(table.Name, 8, 18);
                nodeTable.Tag = table;
                nodeTable.ContextMenuStrip = cmsView;
                nodeRoot.Nodes.Add(nodeTable);

                ShowFields(table, nodeTable);
            }
        }

        /// <summary>
        /// 显示第三级节点：存储过程
        /// </summary>
        private static void ShowStoreProcedures(Database db, TreeNode nodeRoot)
        {
            foreach (string storeProcedure in db.StoreProcedures)
            {
                nodeRoot.Nodes.Add(new TreeNode(storeProcedure, 4, 14));
            }
        }

        /// <summary>
        /// 显示第四级节点：字段
        /// </summary>
        private void ShowFields(Table table, TreeNode nodeRoot)
        {
            foreach (Field field in table.Fields)
            {
                string text = string.Format("{0} ({1}{2}{3},{4})",
                    field.FieldName,
                    field.IsKey ? "PK " : "",
                    field.FieldType,
                    field.FieldLength == 0 ? "" : $"({ field.FieldLength})",
                    field.AllowNull ? "null" : "not null"
                    );

                TreeNode nodeField = new TreeNode(text, 2, 12);

                nodeField.ForeColor = field.IsKey ? Color.Red : Color.Black;


                nodeRoot.Nodes.Add(nodeField);





            }
        }
        #endregion

        #region  CURG右键
        private void menuSelect_Click(object sender, EventArgs e)
        {
            if (CreateCode != null)
            {
                string dbName = tvDatabase.SelectedNode.Parent.Parent.Text;
                Database db = tvDatabase.SelectedNode.Parent.Parent.Tag as Database;
                Table table = tvDatabase.SelectedNode.Tag as Table;
                if (table != null)
                {
                    SqlSeleteViewForm ssv = new SqlSeleteViewForm(db, table);
                    ssv.AddSqlTextEditor();
                    ssv.sqlTextEditor.Text = ssv.sqlTextEditor.Text + "select * from " + table.Name + "";
                    ssv.Show(MainForm.DockPanel);
                }
                else
                {
                    MessageBoxMessage.Alert("请先选中一个表或视图。");
                }
            }
        }

        private void menuUpdate_Click(object sender, EventArgs e)
        {
            if (CreateCode != null)
            {
                string dbName = tvDatabase.SelectedNode.Parent.Parent.Text;
                Database db = tvDatabase.SelectedNode.Parent.Parent.Tag as Database;
                Table table = tvDatabase.SelectedNode.Tag as Table;
                if (table != null)
                {
                    SqlSeleteViewForm ssv = new SqlSeleteViewForm(db, table);
                    ssv.AddSqlTextEditor();
                    string sql = $"update {table.Name} set ";
                    foreach (Field field in table.Fields)
                    {
                        if (field.IsKey)
                            continue;
                        sql += field.FieldName + "='', ";
                    }
                    sql = sql.TrimEnd(',');
                    sql += " where ";
                    ssv.sqlTextEditor.Text = ssv.sqlTextEditor.Text + sql;
                    ssv.Show(MainForm.DockPanel);
                }
                else
                {
                    MessageBoxMessage.Alert("请先选中一个表或视图。");
                }
            }
        }

        private void menuDelete_Click(object sender, EventArgs e)
        {
            if (CreateCode != null)
            {
                string dbName = tvDatabase.SelectedNode.Parent.Parent.Text;
                Database db = tvDatabase.SelectedNode.Parent.Parent.Tag as Database;
                Table table = tvDatabase.SelectedNode.Tag as Table;
                if (table != null)
                {
                    SqlSeleteViewForm ssv = new SqlSeleteViewForm(db, table);
                    ssv.AddSqlTextEditor();
                    ssv.sqlTextEditor.Text = ssv.sqlTextEditor.Text + @"delete from " + table.Name + "";
                    ssv.Show(MainForm.DockPanel);
                }
                else
                {
                    MessageBoxMessage.Alert("请先选中一个表或视图。");
                }
            }
        }

        private void menuInsert_Click(object sender, EventArgs e)
        {
            if (CreateCode != null)
            {
                string dbName = tvDatabase.SelectedNode.Parent.Parent.Text;
                Database db = tvDatabase.SelectedNode.Parent.Parent.Tag as Database;
                Table table = tvDatabase.SelectedNode.Tag as Table;
                if (table != null)
                {
                    SqlSeleteViewForm ssv = new SqlSeleteViewForm(db, table);

                    string tempSql = string.Empty;
                    string tempSqlValue = string.Empty;
                    foreach (Field field in table.Fields)
                    {
                        if (field.IsKey)
                            continue;
                        tempSql += field.FieldName + ",";
                        tempSqlValue += "'',";

                    }
                    tempSql = tempSql.TrimEnd(',');
                    tempSqlValue = tempSqlValue.TrimEnd(',');
                    string sql = $"  INSERT INTO {table.Name} ({tempSql}) VALUES({tempSqlValue}) ";

                    ssv.AddSqlTextEditor();
                    ssv.sqlTextEditor.Text = ssv.sqlTextEditor.Text + sql;
                    ssv.Show(MainForm.DockPanel);
                }
                else
                {
                    MessageBoxMessage.Alert("请先选中一个表或视图。");
                }
            }
        }
        /// <summary>
        /// 生成代码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuCreateCode_Click(object sender, EventArgs e)
        {
            CreateCurrentTableCode();
        }
        /// <summary>
        /// 测试信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu_CreateDataInfo_Click(object sender, EventArgs e)
        {
            if (CreateCode == null)
            {
                MessageBoxMessage.Alert("请先选中一个表或视图。");
                return;
            }
            // 弹出测试信息窗体
            string dbName = tvDatabase.SelectedNode.Parent.Parent.Text;
            Database db = tvDatabase.SelectedNode.Parent.Parent.Tag as Database;
            Table table = tvDatabase.SelectedNode.Tag as Table;
            if (db != null)
            {
                DataInfo(db, table);
            }
            else
            {
                MessageBoxMessage.Alert("请先选中一个数据库。");
            }

        }
        #endregion

        private void menuOutput_Click(object sender, EventArgs e)
        {
            OutputSelectedDatabaseCode();
        }



        private void menuDeleteDatabase_Click(object sender, EventArgs e)
        {
            tvDatabase.Nodes.Remove(tvDatabase.SelectedNode);
        }




        /// <summary>
        /// 对选中的库进行输出代码操作
        /// </summary>
        public void OutputSelectedDatabaseCode()
        {
            if (OutputCode != null)
            {
                Database database = tvDatabase.SelectedNode.Tag as Database;
                if (database != null)
                {
                    OutputCode(database);
                }
                else
                {
                    MessageBoxMessage.Alert("请先选中一个数据库。");
                }
            }
        }

        /// <summary>
        /// 对选中的表进行生成代码操作
        /// </summary>
        public void CreateCurrentTableCode()
        {
            if (CreateCode != null)
            {
                Table table = tvDatabase?.SelectedNode?.Tag as Table;
                if (table != null)
                {
                    CreateCode(table);
                }
                else
                {
                    MessageBoxMessage.Alert("请先选中一个表或视图。");
                }
            }
        }

        private void tvDatabase_MouseDown(object sender, MouseEventArgs e)
        {
            //得到TreeView里鼠标指向的节点,同时把该节点设置为当前选中的节点
            Point pt = this.PointToScreen(tvDatabase.Location);
            Point p = new Point(Control.MousePosition.X - pt.X, Control.MousePosition.Y - pt.Y);
            TreeNode tn = tvDatabase.GetNodeAt(p);
            if (tn != null)
            {
                tvDatabase.SelectedNode = tn;
            }
            //打开详细信息列表 

            //Database db = tvDatabase.SelectedNode.Tag as Database;
            //Table table = tvDatabase.SelectedNode.Tag as Table;
            //DataInfoForm dataInfoForm = new DataInfoForm(db, table);
            //dataInfoForm.Show(MainForm.DockPanel);

            //if (new MainForm().FindDocument("DataInfoForm") != null)
            //{
            //    Form f = new MainForm().FindDocument("DataInfoForm") as Form;
            //    f.Close();

            //}

        }



        protected virtual void OnShowStatus(string obj)
        {
            ShowStatus?.Invoke(obj);
        }

        private void menuRunSql_Click(object sender, EventArgs e)
        {

        }

        private void menuBrowseDB_Click(object sender, EventArgs e)
        {
            if (CreateCode != null)
            {

                Database db = tvDatabase.SelectedNode.Tag as Database;
                Table table = tvDatabase.SelectedNode.Tag as Table;
                if (db != null)
                {
                    //SqlSeleteViewForm ssv = new SqlSeleteViewForm(db, table);
                    //ssv.addSqlTextEditor();
                    //ssv.sqlTextEditor.Text = ssv.sqlTextEditor.Text + "select * from " + table.Name + "";
                    //ssv.Show(MainForm.DockPanel);
                }
                else
                {
                    MessageBoxMessage.Alert("请先选中一个数据库。");
                }
            }
        }

        private void 新建查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tvDatabase_Click(object sender, EventArgs e)
        {

        }


    }
}