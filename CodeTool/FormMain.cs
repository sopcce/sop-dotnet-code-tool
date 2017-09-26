using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CodeTool
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                //string txt = "123.3321123,76.1235234";
                //var text1 = txt.Split(',')[0];
                //var text2 = txt.Split(',')[1];

            }
            catch
            {

            }
        }

        private void btnUnicode_Click(object sender, EventArgs e)
        {
            FormUnCode unform = new FormUnCode();
            unform.ShowDialog();
        }

        private void btnTemp_Click(object sender, EventArgs e)
        {
            FormTemplate unform = new FormTemplate();
            unform.ShowDialog();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("你确定要退出本程序吗？", "关闭窗口", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Dispose();
                this.Close();
            }
        }


    }
}
