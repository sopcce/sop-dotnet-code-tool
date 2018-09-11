using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CodeTool.Common.Model;

namespace CodeTool.UserControls
{
    public partial class SelectTableUserControl : UserControl
    {
        public SelectTableUserControl()
        {
            InitializeComponent();
        }

        private Database db = null;
        public Database Db
        {
            get
            {
                return this.db;
            }
            set
            {
                this.db = value;

                if (this.db != null)
                {
                    foreach (Table table in this.db.Tables)
                    {
                        lstTables.Items.Add(table);
                    }
                    foreach (Table view in this.db.Views)
                    {
                        lstTables.Items.Add(view);
                    }
                }
            }
        }

        public List<Table> SelectedTables
        {
            get
            {
                List<Table> tables = new List<Table>();
                foreach (object obj in lstSelectedTables.Items)
                {
                    tables.Add(obj as Table);
                }
                return tables;
            }
        }

        private void btnSelected_Click(object sender, EventArgs e)
        {
            List<object> objs = new List<object>();
            foreach (object obj in lstTables.SelectedItems)
            {
                objs.Add(obj);
            }
            foreach (object obj in objs)
            {
                lstSelectedTables.Items.Add(obj);
                lstTables.Items.Remove(obj);
            }
        }

        private void btnSelectedAll_Click(object sender, EventArgs e)
        {
            List<object> objs = new List<object>();
            foreach (object obj in lstTables.Items)
            {
                objs.Add(obj);
            }
            foreach (object obj in objs)
            {
                lstSelectedTables.Items.Add(obj);
                lstTables.Items.Remove(obj);
            }
        }

        private void btnUnSelected_Click(object sender, EventArgs e)
        {
            List<object> objs = new List<object>();
            foreach (object obj in lstSelectedTables.SelectedItems)
            {
                objs.Add(obj);
            }
            foreach (object obj in objs)
            {
                lstTables.Items.Add(obj);
                lstSelectedTables.Items.Remove(obj);
            }
        }

        private void btnUnSelectedAll_Click(object sender, EventArgs e)
        {
            List<object> objs = new List<object>();
            foreach (object obj in lstSelectedTables.Items)
            {
                objs.Add(obj);
            }
            foreach (object obj in objs)
            {
                lstTables.Items.Add(obj);
                lstSelectedTables.Items.Remove(obj);
            }
        }
    }
}
