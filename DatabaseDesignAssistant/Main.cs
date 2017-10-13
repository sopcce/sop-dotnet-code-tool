using System;
using System.Windows.Forms;

namespace Sop.DatabaseDesignAssistant
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
            BaseForm bsBaseForm = new BaseForm();
            bsBaseForm.Show();
        }

        private void EntityGeneration_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerationForm gForm = new GenerationForm();
            gForm.Show();
        }
    }
}
