using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CodeTool.App_Code;
using CodeTool.EditorHelper;
using ICSharpCode.TextEditor;
using ICSharpCode.TextEditor.Document;

namespace CodeTool
{
    public partial class FormMake : Form
    {
        /// <summary>
        /// 
        /// </summary>
        private static string _connectionString = "Data Source=192.168.1.36;User ID=sa;Password=sa123.";

        private static string providerName = "";
        /// <summary>
        /// 
        /// </summary>
        private TextEditorControl textEditor = null;

        /// <summary>
        /// 设置连接信息
        /// </summary>
        private static Step step = Step.SetConnection;
        private static string table;
        /// <summary>
        /// 
        /// </summary>
        private static IEnumerable<string> views;
        private static bool _changeDataBase = false;
        private static object _selectItem;
        private static string _logPath = System.IO.Directory.GetCurrentDirectory() + "\\log.txt";


        public FormMake()
        {
            InitializeComponent();

            textEditor = new TextEditorControl();
            textEditor.Dock = DockStyle.Fill;
            // PlSetOption.Controls.Add(textEditor);
            groupBox1.Controls.Add(textEditor);
            textEditor.TextChanged += TextEditor_TextChanged;
        }

        private void TextEditor_TextChanged(object sender, EventArgs e)
        {
            //更新，以便进行代码折叠
            textEditor.Document.FoldingManager.UpdateFoldings(null, null);
        }

        private void FormMake_Load(object sender, EventArgs e)
        {
            _connectionString = "server=192.168.1.36;uid=sa;pwd=sa123.";
            TxtConnectionString.Text = _connectionString;
            listBox_dbType.SelectedIndex = 0;
            #region 文本编辑器


            string sampleCode = @"using ICSharpCode.TextEditor;
using System;
using System.Collections.Generic;
         using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ICSharpCodeTextEditor
{
    public partial class Form1 : Form
    {
        private TextEditorControl textEditor = null;
        public Form1()
        {
            InitializeComponent();
                     textEditor = new TextEditorControl();
            textEditor.Dock = DockStyle.Fill;
   this.pContainer.Controls.Add(textEditor);
            textEditor.TextChanged += TextEditor_TextChanged;
        }
        private void TextEditor_TextChanged(object sender, EventArgs e)
        {
            //更新，以便进行代码折叠
            textEditor.Document.FoldingManager.UpdateFoldings(null, null);
        }
        private void btnFormatCSharp_Click(object sender, EventArgs e)
        {
            textEditor.Text = 
            JackWangCUMT.WinForm.CSharpFormatHelper.FormatCSharpCode(textEditor.Text);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if(textEditor!=null)
                   {
     textEditor.SetHighlighting(""C#"");

                textEditor.Encoding = System.Text.Encoding.UTF8;
            textEditor.Document.FoldingManager.FoldingStrategy = new JackWangCUMT.WinForm.MingFolding();
        }
    }
}
}
";

            textEditor.SetHighlighting("C#");
            textEditor.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy("C#");
            //textEditor.Encoding = System.Text.Encoding.UTF8;
            //textEditor.Font = new Font("Hack", 12);
            //textEditor.Document.FoldingManager.FoldingStrategy = new MingFolding();
            //textEditor.Text = sampleCode;

            //自定义代码高亮
            string path = Application.StartupPath + "\\HighLighting";
            FileSyntaxModeProvider fsmp;
            if (Directory.Exists(path))
            {
                fsmp = new FileSyntaxModeProvider(path);
                HighlightingManager.Manager.AddSyntaxModeFileProvider(fsmp);
                textEditor.SetHighlighting("C#");
            }
            #endregion


        }

        private void FormMake_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show(@"你确定要退出本程序吗？", @"关闭窗口",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Dispose();
                this.Close();
            }
        }











        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnComplete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(@"你确定要退出本程序吗？", @"关闭窗口",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Dispose();
                this.Close();
            }

        }




        /// <summary>
        /// 上一步
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            switch (step)
            {
                case Step.Execute:
                    BtnPrevious.Visible = true;
                    BtnSchemaNext.Text = "下一步》";
                    BtnSchemaNext.Enabled = true;
                    PlExecMessage.Visible = false;
                    PlSetOption.Visible = true;
                    step = Step.SetOption;
                    break;
                case Step.SetOption:
                    PlSetOption.Visible = false;
                    PlSelectDataItem.Visible = true;
                    step = Step.SelectTables;
                    break;
                case Step.SelectViews:
                    break;
                case Step.SelectTables:
                    PlSelectDataItem.Visible = false;
                    PlSelectDataBase.Visible = true;
                    step = Step.SelectDataBase;
                    break;
                case Step.SelectDataBase:
                    PlSelectDataBase.Visible = false;
                    PanelConect.Visible = true;
                    btnClearCode.Visible = false;
                    BtnPrevious.Visible = false;
                    step = Step.SetConnection;
                    break;
            }
        }
        /// <summary>
        /// 下一步
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSchemaNext_Click(object sender, EventArgs e)
        {
            switch (step)
            {
                case Step.SetConnection:
                    #region SetConnection
                    if (!ValidateConnectionString())
                        return;
                    string errorMessage = string.Empty;
                    if (!CheckConnection(out errorMessage))
                    {
                        MessageBox.Show(errorMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    List<DatabaseInfo> dbInfos;
                    //清空
                    LbDataBases.Items.Clear();
                    if (BindDataBase(out dbInfos))
                    {
                        if (dbInfos.Any())
                        {
                            foreach (var info in dbInfos)
                            {
                                if (!string.IsNullOrWhiteSpace(info.Name))
                                    LbDataBases.Items.Add(info.Name);
                            }
                        }
                        step = Step.SelectDataBase;
                        PanelConect.Visible = false;
                        PlSelectDataBase.Visible = true;
                        BtnPrevious.Visible = true;
                    }
                    #endregion
                    break;
                case Step.SelectDataBase:
                    #region SelectDataBase
                    if (LbDataBases.SelectedItem == null)
                    {
                        MessageBox.Show(@"请选择一个数据库！", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    _connectionString = _connectionString + "; database=" + LbDataBases.SelectedItem + ";";

                    if (_changeDataBase)
                    {
                        listBoxSelectDataBaseItems.Items.Clear();
                        _changeDataBase = false;
                        List<TableInfo> tableInfos;
                        if (BindTables(out tableInfos))
                        {
                            if (tableInfos.Any())
                            {
                                foreach (var info in tableInfos)
                                {
                                    if (!string.IsNullOrWhiteSpace(info.TableName))
                                        listBoxSelectDataBaseItems.Items.Add(info.TableName + "^Explain：" + info.TableExplain);
                                }
                            }
                            PlSelectDataBase.Visible = false;
                            PlSelectDataItem.Visible = true;
                            step = Step.SelectTables;
                        }
                    }
                    #endregion
                    break;
                case Step.SelectTables:
                    #region SelectTables
                    if (listBoxSelectDataBaseItems.SelectedItem == null)
                    {
                        MessageBox.Show(@"请选择一个数据表！", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    table = listBoxSelectDataBaseItems.SelectedItem.ToString();

                    table = table.Split('^')[0];





                    PlSelectDataItem.Visible = false;
                    PlSetOption.Visible = true;
                    step = Step.SetOption;
                    string message = string.Empty;
                    btnClearCode.Visible = true;
                    #endregion
                    break;
                case Step.SelectViews:
                    btnClearCode.Visible = false;

                    break;
                case Step.SetOption:
                    step = Step.Execute;
                    PlSetOption.Visible = false;
                    PlExecMessage.Visible = true;
                    TxtExecMessage.Text = "";

                   
                    break;
                case Step.Execute:
                    this.Close();
                    break;
            }
        }

        #region SetConnectionString

        private void RBtnProvideConnectionString_CheckedChanged(object sender, EventArgs e)
        {
            SetConnectOptions(false);
        }

        private void RBtnSpecifiyServer_CheckedChanged(object sender, EventArgs e)
        {
            SetConnectOptions();
        }

        private void RBtnWinAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            this.TxtUserName.Enabled = false;
            this.TxtPassword.Enabled = false;
        }

        private void RBtnSqlAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            this.TxtUserName.Enabled = true;
            this.TxtPassword.Enabled = true;
        }

        #endregion





        #region Method
        /// <summary>
        /// 判断链接是否可用
        /// </summary>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public bool CheckConnection(out string errorMessage)
        {
            try
            {
                errorMessage = string.Empty;
                PetaPoco.Database db = new PetaPoco.Database(_connectionString, "");
                db.OpenSharedConnection();
                if (db.Connection.State != ConnectionState.Open)
                {
                    errorMessage = @"数据库未连接,请尝试链接";
                    return false;
                }
                db.CloseSharedConnection();
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }



        }

        /// <summary>
        /// 更新连接设置的启用状态
        /// </summary>
        /// <param name="enable"></param>
        private void SetConnectOptions(bool enable = true)
        {
            this.TxtServer.Enabled = enable;
            this.TxtUserName.Enabled = enable;
            this.TxtPassword.Enabled = enable;
            this.RBtnWinAuthentication.Enabled = enable;
            this.RBtnSqlAuthentication.Enabled = enable;
            this.TxtConnectionString.Enabled = !enable;
            this.listBox_dbType.Enabled = !enable;

        }
        /// <summary>
        /// 验证连接字符串
        /// </summary>
        public bool ValidateConnectionString()
        {
            if (TxtServer.Enabled)
            {
                if (RBtnWinAuthentication.Checked)
                {
                    if (string.IsNullOrEmpty(TxtServer.Text))
                    {
                        MessageBox.Show(@"给定服务器名称无效", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    _connectionString = string.Format(@"Data Source={0};Integrated Security=True;Pooling=true;", TxtServer.Text.Trim());
                    return true;
                }

                if (string.IsNullOrEmpty(TxtUserName.Text) || string.IsNullOrEmpty(TxtPassword.Text))
                {
                    MessageBox.Show(@"用户名和密码是必需的", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                _connectionString = string.Format(@"Data Source={0};User ID={1};Password={2};Trusted_Connection=no; Pooling=true;", TxtServer.Text.Trim(), TxtUserName.Text.Trim(), TxtPassword.Text.Trim());

            }
            else if (TxtConnectionString.Enabled)
            {
                if (string.IsNullOrEmpty(TxtConnectionString.Text))
                {
                    MessageBox.Show(@"给定的连接字符串无效", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                _connectionString = TxtConnectionString.Text.Trim();
            }

            return true;
        }
        /// <summary>
        /// 绑定数据库
        /// </summary>
        private bool BindDataBase(out List<DatabaseInfo> dbInfos)
        {
            try
            {
                providerName = listBox_dbType.Text;
                PetaPoco.Database db = new PetaPoco.Database(_connectionString, providerName);
                db.OpenSharedConnection();
                if (db.Connection.State != ConnectionState.Open)
                {
                    dbInfos = null;
                    MessageBox.Show(@"数据库为未连接,请尝试链接");
                    return false;
                }
                db.CloseSharedConnection();
                string sql = ConfigHelper.GetDataBaseInfo(ConfigHelper.GetDbType(providerName));
                dbInfos = db.Query<DatabaseInfo>(sql).ToList();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(@"错误信息：" + ex.Message);
                dbInfos = null;
                return false;
            }

        }

        /// <summary>
        /// 绑定数据表
        /// </summary>
        private bool BindTables(out List<TableInfo> tables)
        {
            try
            {
                PetaPoco.Database db = new PetaPoco.Database(_connectionString, providerName);

                string sql = ConfigHelper.GetTableInfo(ConfigHelper.GetDbType(providerName));
                tables = db.Query<TableInfo>(sql).ToList();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(@"错误信息：" + ex.Message);
                tables = null;
                return false;
            }
        }

        #endregion


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LbDataBases_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!LbDataBases.SelectedItem.Equals(_selectItem))
            {
                _selectItem = LbDataBases.SelectedItem;
                _changeDataBase = true;
            }
        }

        private void listBox_dbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClearCode_Click(object sender, EventArgs e)
        {
            textEditor.Text = CSharpFormatHelper.FormatCSharpCode(textEditor.Text);
        }
    }


}
