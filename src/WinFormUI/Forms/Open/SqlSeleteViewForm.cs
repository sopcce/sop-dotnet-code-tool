using System;
using System.Data;
using System.Windows.Forms;
using CodeTool.Common.DBUtility;
using CodeTool.Common.Model;
using CodeTool.Common;
using CodeTool.Common.GridView;

namespace CodeTool.Forms.Open
{
    public partial class SqlSeleteViewForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private Table table;
        private Database db;

        public SqlSeleteViewForm(Database db, Table table)
        {
            InitializeComponent();
            sqlTextEditor.SetStyle("TSQL");
            this.db = db;
            this.table = table;
            this.Text = table.Name+" —数据信息";
        }

        public void AddSqlTextEditor()
        {

            if ((this.sqlTextEditor.Text.Trim().Length != 0) && (this.sqlTextEditor.Text[this.sqlTextEditor.Text.Length - 1] != '\n'))
            {
                this.sqlTextEditor.Text = this.sqlTextEditor.Text + "\n";
            }
        }
        private void dgView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (this.dgView.Rows.Count != 0)
            {
                for (int i = 0; i < this.dgView.Rows.Count; )
                {
                    this.dgView.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Pink;
                    i += 2;
                }
            }
        }

        private DbHelper dbHelper = null;

        private void runSql_Click(object sender, System.EventArgs e)
        {
            if (this.db != null)
            {
                switch (db.Type)
                {
                    case DatabaseTypes.Access:
                        this.dbHelper = DbHelper.Create("OleDb");
                        break;
                    case DatabaseTypes.MySql:
                        this.dbHelper = DbHelper.Create("MySql");
                        break;
                    case DatabaseTypes.Ase:
                        this.dbHelper = DbHelper.Create("Ase");
                        break;
                    case DatabaseTypes.Oracle:
                        this.dbHelper = DbHelper.Create("Oracle");
                        break;
                    case DatabaseTypes.SQLite:
                        this.dbHelper = DbHelper.Create("SQLite");
                        break;
                    case DatabaseTypes.DB2:
                        this.dbHelper = DbHelper.Create("DB2");
                        break;
                    case DatabaseTypes.PostgreSql:
                        this.dbHelper = DbHelper.Create("PostgreSql");
                        break;
                    case DatabaseTypes.Sql2000:
                    case DatabaseTypes.Sql2005:
                    default:
                        this.dbHelper = DbHelper.Create("SqlServer");
                        break;
                }
                this.dbHelper.ConnectionString = db.ConnString;

                string selectedText = this.sqlTextEditor.ActiveTextAreaControl.TextArea.SelectionManager.SelectedText;

                selectedText = string.IsNullOrWhiteSpace(selectedText) ? sqlTextEditor.Text : selectedText;
                if (!string.IsNullOrWhiteSpace(selectedText))
                {
                    selectedText = selectedText.Trim(new char[] { ' ', '\t', '\n' });
                    if (selectedText == "")
                    {
                        selectedText = this.sqlTextEditor.Text;
                    }
                    string format = "（所影响的行数为 {0} 行）";
                    try
                    {
                        if (selectedText.StartsWith("select", StringComparison.InvariantCultureIgnoreCase))
                        {
                            DataSet dS = this.dbHelper.ExecuteDataset(CommandType.Text, selectedText, null);
                            this.dgView.DataSource = dS.Tables[0];
                            dgView.CodeGrid();

                            this.txtLineEffect.Text = string.Format(format, dS.Tables[0].Rows.Count);
                            this.tabInfo.SelectedIndex = 0;
                        }
                         if (selectedText.StartsWith("delete", StringComparison.InvariantCultureIgnoreCase))
                        {
                            this.txtLineEffect.Text = string.Format(format, this.dbHelper.ExecuteDataset(CommandType.Text, selectedText, null).ToString());
                            this.dgView.DataSource = null;
                            this.tabInfo.SelectedIndex = 1;
                        }
                         if (selectedText.StartsWith("update", StringComparison.InvariantCultureIgnoreCase))
                        {
                            this.txtLineEffect.Text = string.Format(format, this.dbHelper.ExecuteDataset(CommandType.Text, selectedText, null).ToString());
                            this.dgView.DataSource = null;
                            this.tabInfo.SelectedIndex = 1;
                        }
                         if (selectedText.StartsWith("insert", StringComparison.InvariantCultureIgnoreCase))
                        {
                            this.txtLineEffect.Text = string.Format(format, this.dbHelper.ExecuteDataset(CommandType.Text, selectedText, null).ToString());
                            this.dgView.DataSource = null;
                            this.tabInfo.SelectedIndex = 1;
                        }
                        
                        //{
                        //    //this.dgView.DataSource = null;
                        //    //this.txtLineEffect.Text = "无效的Sql语句；期待'Delete','Insert','Select','Update'";
                        //    //this.tabInfo.SelectedIndex = 1;
                        //}
                    }
                    catch (Exception exception)
                    {
                        this.txtLineEffect.Text = exception.Message;
                        this.tabInfo.SelectedIndex = 1;
                    }
                }
            }
            else
            {
                this.txtLineEffect.Text = "数据库未加载,无法执行语句";
                this.tabInfo.SelectedIndex = 1;
            }
        }
    }
}