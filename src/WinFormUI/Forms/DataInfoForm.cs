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
        public DataInfoForm()
        {
            InitializeComponent(); 
        }

        public DataInfoForm(Database db, Table table)
        {
            this._table = table;
            this._db = db;
        }

        private void DataInfoForm_Load(object sender, EventArgs e)
        {
            MessageBoxMessage.Alert("asdasd");
        }

      
    }
}
