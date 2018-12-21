using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeTool.Common.Model;
using CodeTool.Config;

namespace CodeTool.Forms
{
    public partial class DataInfoForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private Table _table;
        private Database _db;
      
        public DataInfoForm(Database db, Table table)
        {
            InitializeComponent();
            this._table = table;
            this._db = db;
            this.Text = table.Name + " —数据信息";
           
        }

        private void DataInfoForm_Load(object sender, EventArgs e)
        { 
            this.Text = " 测试标题 "; 

        }


    }
}
