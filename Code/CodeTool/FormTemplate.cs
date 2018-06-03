using CodeTool.App_Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CodeTool
{
    public partial class FormTemplate : Form
    {

        public string ConnectionString = "server=.;uid=Sa;pwd=sa123.;database=Sop;";
        public FormTemplate()
        {
            InitializeComponent();
        }
        private void btnOpen_Load(object sender, EventArgs e)
        {
            comboBox_Connstring.Items.Add(ConnectionString);
            comboBox_Connstring.Items.Add("Data Source=.;Initial Catalog=test_528;User ID=sa;Password=sa123.");
           
       

            //OpenDbDao(ConnectionString, "");
        }
        /// <summary>
        /// 打开数据链接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenDB_Click(object sender, EventArgs e)
        {
            ConnectionString = comboBox_Connstring.Text.Trim();
            OpenDbDao(ConnectionString, "");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            string tableName = comboBox_dbType.Text;
            if (string.IsNullOrEmpty(tableName))
            {
                MessageBox.Show(@"请选择数据表.");
                return;
            }
            richTextBox_code.Text = CommonHelper.CreateSelectProc(tableName);

        }



        public bool OpenDbDao(string connectionString, string providerName = "", string dbType = "U")
        {
            try
            {
                PetaPoco.Database db = new PetaPoco.Database(connectionString, providerName);
                db.OpenSharedConnection();
                if (db.Connection.State != ConnectionState.Open)
                {
                    MessageBox.Show(@"数据库为未连接,请尝试链接");
                    return false;
                }
                string sql = "Select id, name, type From SysObjects Where XType = 'U' order by name asc";
                var dbInfo = db.Query<DatabaseInfo>(sql).ToList();
                //清空
                comboBox_dbType.Items.Clear();
                comboBox_dbType.Items.Add("请选择表");
                comboBox_dbType.SelectedIndex = 0;

                if (dbInfo.Any())
                {
                    foreach (var item in dbInfo)
                    {
                        if (!string.IsNullOrWhiteSpace(item.Name))
                            comboBox_dbType.Items.Add(item.Name);
                    }
                }
                db.CloseSharedConnection();
                CacheHelper.SetCache(ConfigHelper.ConnectionString, connectionString, TimeSpan.FromDays(1));
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(@"错误信息：" + ex.Message);
                return false;
            }
        }

        private void btn_model_Click(object sender, EventArgs e)
        {
            string tableName = comboBox_dbType.Text;
            if (string.IsNullOrEmpty(tableName))
            {
                MessageBox.Show(@"请选择数据表.");
                return;
            }
            richTextBox_code.Text = CommonHelper.CreateModel(tableName);

        }
    }
}
