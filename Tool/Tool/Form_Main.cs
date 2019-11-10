using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tool
{
    public partial class Form_Main : Form
    {

        private string ReplaceListFilePath = ".\\data\\ReplaceList.txt";

        private string ModelPath = ".\\data\\{namespace}";

        private List<KeyValuePair<string, string>> ReplaceList = null;

        private List<KeyValuePair<string, string>> MoveList = null;

        private List<string> ErrorMessage = new List<string>();
        // ProgressBarInvoke
        public delegate void ProgressBarInvoke(double value);

        /// <summary>
        /// 输出目录
        /// </summary>
        public string OutPath
        {
            get
            {
                return textBox_OutPath.Text;
            }
            set
            {
                textBox_OutPath.Text = value;
            }
        }
        public Form_Main()
        {
            InitializeComponent();
        }

        public void LoadReplaceList()
        {
            if (!File.Exists(ReplaceListFilePath))
            {
                throw new Exception($"找不到文件{ReplaceListFilePath}");
            }
            StreamReader streamReader = new StreamReader(ReplaceListFilePath);
            ReplaceList = new List<KeyValuePair<string, string>>();
            Regex regex = new Regex("Replace[\\s](?<Replace>[\\S]+?)[\\s](?<ReplaceTo>[\\S]+?$)");
            while (streamReader.Peek() > 0)
            {
                string input = streamReader.ReadLine();
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string value = match.Groups["Replace"].Value;
                    string text = match.Groups["ReplaceTo"].Value;
                    if (text == "namespace")
                    {
                        text = textBox_namespace.Text;
                    }
                    if (text == "info")
                    {
                        text = textBox_info.Text;
                    }
                    if (text == "table")
                    {
                        text = textBox_Table.Text;
                    }

                    ReplaceList.Add(new KeyValuePair<string, string>(value, text));
                }
            }
            string tempText = textBox_namespace.Text;
            if (!string.IsNullOrWhiteSpace(tempText))
            { 
                if (!ReplaceList.Select(n => n.Key).Contains("namespace"))
                {
                    ReplaceList.Add(new KeyValuePair<string, string>("namespace", tempText));
                } 
            }
            tempText = textBox_info.Text;
            if (!string.IsNullOrWhiteSpace(tempText))
            {
              
                if (!ReplaceList.Select(n => n.Key).Contains("info"))
                {
                    ReplaceList.Add(new KeyValuePair<string, string>("info", tempText));
                }
            }
            tempText = textBox_Table.Text;
            if (!string.IsNullOrWhiteSpace(tempText))
            {

                if (!ReplaceList.Select(n => n.Key).Contains("table"))
                {
                    ReplaceList.Add(new KeyValuePair<string, string>("table", tempText));
                }
            }


        }

        public void LoadMoveList()
        {
            MoveList = new List<KeyValuePair<string, string>>();
            List<string> files = new List<string>();
            GetAllChildFile(ModelPath, ref files);
            foreach (string item in files)
            {
                MoveList.Add(new KeyValuePair<string, string>(item, item.TrimStart('.')));
            }
        }
        /// <summary>
        /// 选择文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_ChooseOutPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult dialogResult = folderBrowserDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                OutPath = folderBrowserDialog.SelectedPath;
            }
        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_OutPath.Text))
            {
                MessageBox.Show("请选择正确的输出目录");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox_info.Text))
            {
                MessageBox.Show("请输入合法的项目名称");
                return;
            }
            try
            {
                LoadReplaceList();
                LoadMoveList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (Directory.Exists(GetSaveFileFullPath(textBox_info.Text)))
            {
                DialogResult dialogResult = MessageBox.Show("目标应用已经创建，是否继续？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            Task.Factory.StartNew(delegate
            {
                Working();
            });
        }

        private void SetProgressBarSchedule(double schedule)
        {
            if (progressBar_Schedule.InvokeRequired)
            {
                ProgressBarInvoke method = SetProgressBarSchedule;
                Invoke(method, schedule);
            }
            else
            {
                progressBar_Schedule.Value = (int)(schedule * 100.0);
                progressBar_Schedule.Maximum = 100;
            }
        }


        private void Working()
        {
            int num = 0;
            foreach (KeyValuePair<string, string> move in MoveList)
            {
                num++;
                SetProgressBarSchedule((double)num / (double)MoveList.Count);
                if (!File.Exists(move.Key))
                {
                    ErrorMessage.Add($"找不到文件{move.Key}");
                }
                else
                {
                    string replaceValue = GetReplaceValue(GetSaveFileFullPath(move.Value));
                    string saveDirByFile = GetSaveDirByFile(replaceValue);
                    if (!Directory.Exists(saveDirByFile))
                    {
                        Directory.CreateDirectory(saveDirByFile);
                    }
                    StreamReader streamReader = new StreamReader(move.Key, Encoding.UTF8);
                    string replaceValue2 = GetReplaceValue(streamReader.ReadToEnd());
                    streamReader.Close();
                    streamReader.Dispose();
                    StreamWriter streamWriter = new StreamWriter(replaceValue, append: false, Encoding.UTF8);
                    streamWriter.Write(replaceValue2);
                    streamWriter.Close();
                    streamWriter.Dispose();
                }
            }
            SetProgressBarSchedule(1.0);
            string text = "操作完成";
            if (ErrorMessage.Count > 0)
            {
                text += ",但是出现错误\r\n";
                text += string.Join("\r\n", ErrorMessage);
            }
            MessageBox.Show(text);
            SetProgressBarSchedule(0.0);
        }

        private string GetReplaceValue(string value)
        {
            foreach (KeyValuePair<string, string> replace in ReplaceList)
            {
                value = value.Replace("{" + replace.Key + "}", replace.Value);
            }
            return value;
        }

        private string GetSaveFileFullPath(string filePath)
        {
            return textBox_OutPath.Text.TrimEnd('\\') + "\\" + filePath.TrimStart('\\');
        }

        private string GetSaveDirByFile(string filePath)
        {
            return filePath.Substring(0, filePath.LastIndexOf("\\"));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="files"></param>
        private void GetAllChildFile(string path, ref List<string> files)
        {
            if (Directory.Exists(path))
            {
                string[] directories = Directory.GetDirectories(path);
                string[] array = directories;
                foreach (string path2 in array)
                {
                    GetAllChildFile(path2, ref files);
                }
                files.AddRange(Directory.GetFiles(path));
            }
        }
    }
}

