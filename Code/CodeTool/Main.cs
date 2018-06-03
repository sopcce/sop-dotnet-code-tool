using System;
using System.Windows.Forms;

namespace CodeTool
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 点击数据菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataRemoval_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //BaseForm bsBaseForm = new BaseForm();
            //bsBaseForm.Show();
        }

        private void EntityGeneration_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //GenerationForm gForm = new GenerationForm();
            //gForm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {

            FormMake unform = new FormMake();
            unform.ShowDialog();
        }
    }
}
