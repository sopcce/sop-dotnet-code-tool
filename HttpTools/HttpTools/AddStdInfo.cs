using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RandomCheck.Bussiness;
using System.IO;
using System.Collections;

namespace RandomCheck
{
    public partial class AddStdInfo : Form
    {
        public AddStdInfo()
        {
            InitializeComponent();
        }

        private void butModify_Click(object sender, EventArgs e)
        {
            FilesOper fo = new FilesOper();
            List<string> StdNames = (List<string>)(fo.Get(cboxFileDb.SelectedItem.ToString()));
            DataGridViewRow row;
            DataGridViewTextBoxCell cell;
            NamesView.Rows.Clear();
            foreach (string name in StdNames)
            {
                cell = new DataGridViewTextBoxCell();
                row = new DataGridViewRow();
                cell.Value = name;
                row.Cells.Add(cell);
                NamesView.Rows.Add(row);
            }
            string[] name1=cboxFileDb.SelectedItem.ToString().Split('\\');
            string[] name2=name1[1].Split('.');
            tboxfilename.Text = name2[0];

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                if (e.ColumnIndex == 1 && e.RowIndex != NamesView.Rows.Count - 1)
                {
                    NamesView.Rows.Remove(NamesView.Rows[e.RowIndex]);
                }
            }
        }

        private void GetFileDb()
        {
            
            cboxFileDb.Items.Clear();
            string[] DbFiels = Directory.GetFiles("StdSystem");

            if (DbFiels.Length > 0)
            {
                foreach (string str in DbFiels)
                {
                    cboxFileDb.Items.Add(str);
                }
                cboxFileDb.SelectedIndex = 0;
                butDel.Enabled = true;
                butModify.Enabled = true;
            }
            else
            {
                butDel.Enabled = false;
                butModify.Enabled = false;
            }
        }

        private void AddStdInfo_Load(object sender, EventArgs e)
        {
            GetFileDb();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            List<string> StdNames = new List<string>();
            if (NamesView.Rows.Count > 1)
            {
                for (int i = 0; i < NamesView.Rows.Count - 1; i++)
                {
                    StdNames.Add(NamesView.Rows[i].Cells[0].Value.ToString());
                }
                if (!string.IsNullOrEmpty(tboxfilename.Text.Trim()))
                {
                    string file = tboxfilename.Text.Trim() + ".txt";
                    if (File.Exists(@"StdSystem\"+tboxfilename.Text.Trim()+".dat"))
                    {
                        if (MessageBox.Show("文件已存在，是否覆盖？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            FilesOper fo = new FilesOper();
                            ClassSerializers cs = new ClassSerializers();
                            fo.Save(@"StdSystem\" + tboxfilename.Text.Trim() + ".dat", cs.SerializeBinary(StdNames));
                            MessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GetFileDb();
                        }
                    }
                    else
                    {
                        FilesOper fo = new FilesOper();
                        ClassSerializers cs = new ClassSerializers();
                        fo.Save(@"StdSystem\" + tboxfilename.Text.Trim() + ".dat", cs.SerializeBinary(StdNames));
                        MessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetFileDb();
                    }
                }
                else
                {
                    MessageBox.Show("文件名为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("没有数据记录!","警告",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除\"" + cboxFileDb.SelectedItem.ToString() + "\"吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                File.Delete(cboxFileDb.SelectedItem.ToString());
                GetFileDb();
            }           
        }

       
        private void NamesView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {           
            if (NamesView[e.ColumnIndex, e.RowIndex].Value == null)
            {
                MessageBox.Show("数据记录为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NamesView[e.ColumnIndex, e.RowIndex].Value = "匿名";

            }
        }
    }
}