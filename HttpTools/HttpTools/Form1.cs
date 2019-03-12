using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Xml;
using RandomCheck.Bussiness;
using System.IO;

namespace RandomCheck
{
    public partial class Form1 : Form
    {
        Random rdm;
        List<string> StdNames=new List<string>();

        bool access = false;
        bool ShiTi = false;
        public Form1()
        {            
            InitializeComponent();
        }
      
        private void reset(string filepath)
        {
            FilesOper fo = new FilesOper();
            StdNames = (List<string>)(fo.Get(filepath));
            if (StdNames == null)
            {
                StdNames = new List<string>();
                StdNames.Add("请增加学员系统");
                StdName.Text = "请增加学员系统";

            }
            else
            {
                StdName.Text = "开始提问";
            }
            
            lboxHaveNot.Items.Clear();
            for (int i = 0; i < StdNames.Count; i++)
            {
                lboxHaveNot.Items.Add(StdNames[i]);
            }
            lboxHave.Items.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("havenot.xml");
            XmlNode root = doc.GetElementsByTagName("StdInfo")[0];
            root.RemoveAll();
            doc.Save("havenot.xml");

            doc.Load("have.xml");      
            root = doc.GetElementsByTagName("StdInfo")[0];
            root.RemoveAll();
            doc.Save("have.xml");

        }
        private void GetFileDB()
        {
            cboxStdSys.Items.Clear();
            string[] DbFiels = Directory.GetFiles("StdSystem");
            if (DbFiels.Length > 0)
            {
                foreach (string str in DbFiels)
                {
                    cboxStdSys.Items.Add(str);
                }
                cboxStdSys.SelectedIndex = 0;
                rdmcheck.Enabled = true;
                butreset.Enabled = true;
            }
            else
            {
                cboxStdSys.Items.Add("无记录");
                cboxStdSys.SelectedIndex = 0;
                rdmcheck.Enabled = false;
                butreset.Enabled = false;
            }
        }

        private void PreLoad()
        {
            rdm = new Random(System.DateTime.Now.Millisecond);

            GetFileDB();

            XmlDocument doc = new XmlDocument();
            doc.Load("havenot.xml");
            XmlNodeList nodeList = doc.GetElementsByTagName("item");
            if (nodeList.Count == 0)
            {
                reset(cboxStdSys.SelectedItem.ToString());
            }
            else
            {
                StdNames.Clear();
                StdName.Text = "";
                lboxHaveNot.Items.Clear();
                lboxHave.Items.Clear();
                foreach (XmlNode node in nodeList)
                {
                    StdNames.Add(node.InnerText);
                    lboxHaveNot.Items.Add(node.InnerText);
                }
                doc.Load("have.xml");
                nodeList = doc.GetElementsByTagName("item");
                if (nodeList.Count > 0)
                {
                    foreach (XmlNode node in nodeList)
                    {
                        lboxHave.Items.Add(node.InnerText);
                    }
                }
            }           
        }

        List<string> ItemsAdd = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            PreLoad();
            labItems.Text = "";
            Read();
        }

        public void Read()
        {
            string[] filearr = Directory.GetFiles(Application.StartupPath + @"\StdSystem");
            for (int i = 0; i < filearr.Length; i++)
            {
                string fileName = Path.GetExtension(filearr[i]).ToLower();
                if (fileName == ".txt")
                {
                    ItemsAdd = ReadStory(filearr[i]);
                }
            }
            foreach (string item in ItemsAdd)
            {
                lbSever.Items.Add(item);
            }
        }

        public List<string> ReadStory(string StoryPath)
        {
            using (StreamReader sr = new StreamReader(File.Open(StoryPath, FileMode.Open)))
            {
                List<string> Story = new List<string>();
                for (int i = 0; !sr.EndOfStream; i++)
                {
                    Story.Add(sr.ReadLine());
                }
                return Story;
            }
        }

        private void rdmcheck_Click(object sender, EventArgs e)
        {
            
            if (StdNames.Count > 0)
            {
                string sname = StdNames[rdm.Next(0, StdNames.Count)];
                lboxHave.Items.Add(sname);
                lboxHaveNot.Items.Remove(sname);
                StdNames.Remove(sname);
                StdName.Text = sname;
                MessageBox.Show(sname,sname,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("循环结束，是否重新开始?", "Tip", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    reset(cboxStdSys.SelectedItem.ToString());
                    lbSelect.Items.Clear();
                }
            }
            if (ShiTi)
            {
                    if (ItemsAdd.Count > 0)
                {
                    string sitems = ItemsAdd[rdm.Next(0, ItemsAdd.Count)];
                    lbSelect.Items.Add(sitems);
                    labItems.Text = sitems;
                    ItemsAdd.Remove(sitems);
                    MessageBox.Show(sitems, sitems, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }
        private void butreset_Click(object sender, EventArgs e)
        {
            reset(cboxStdSys.SelectedItem.ToString());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("havenot.xml");
            XmlNode root =doc.GetElementsByTagName("StdInfo")[0];
            root.RemoveAll();
            for (int i = 0; i < lboxHaveNot.Items.Count;i++ )
            {
                XmlNode item = doc.CreateElement("item");
                XmlText text = doc.CreateTextNode(lboxHaveNot.Items[i].ToString());
                item.AppendChild(text);
                root.AppendChild(item);
            }
            doc.Save("havenot.xml");

            doc.Load("have.xml");
            root = doc.GetElementsByTagName("StdInfo")[0];
            root.RemoveAll();
            for (int i = 0; i <lboxHave.Items.Count; i++)
            {
                XmlNode item = doc.CreateElement("item");
                XmlText text = doc.CreateTextNode(lboxHave.Items[i].ToString());
                item.AppendChild(text);
                root.AppendChild(item);
            }
            doc.Save("have.xml");
        }

        private void lboxHaveNot_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (access)
            {
                if (StdNames.Count > 0)
                {
                    if (lboxHaveNot.SelectedIndex != -1)
                    {
                        string sname = lboxHaveNot.Items[lboxHaveNot.SelectedIndex].ToString();
                        lboxHave.Items.Add(sname);
                        lboxHaveNot.Items.Remove(sname);
                        StdNames.Remove(sname);
                        StdName.Text = sname;
                        MessageBox.Show(sname, sname, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (MessageBox.Show("循环结束，是否重新开始?", "Tip", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        reset(cboxStdSys.SelectedItem.ToString());
                    }
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.Q)
                {
                    if (access)
                    {
                        MessageBox.Show("增加限制！");
                        access = false;
                    }
                    else
                    {
                        MessageBox.Show("解除限制!");
                        access = true;
                    }
                }
            }
        }              

        private void cboxStdSys_SelectionChangeCommitted(object sender, EventArgs e)
        {
            reset(cboxStdSys.SelectedItem.ToString());
        }

        private void butAddSys_Click(object sender, EventArgs e)
        {
            AddStdInfo add = new AddStdInfo();
            add.ShowDialog();
            GetFileDB();
            reset(cboxStdSys.SelectedItem.ToString());
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (ShiTi)
            {
                ShiTi = false;
                btnReset.Text = "启用试题";
            }
            else
            {
                ShiTi = true;
                btnReset.Text = "关闭试题";
            }
        }
    }
}