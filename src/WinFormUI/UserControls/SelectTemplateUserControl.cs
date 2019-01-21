using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using CodeTool.Common;
using CodeTool.Common.Generator;
using CodeTool.Config;

namespace CodeTool.UserControls
{
    public partial class SelectTemplateUserControl : UserControl
    {


        public event Action<string> ShowReadmeOfTemplate;
        public string TemplateFolderPath => Application.StartupPath + @"\" + SqlConfig.TemplateFolder + @"\" + cobTemplates.Text;

        public SelectTemplateUserControl()
        {
            InitializeComponent();
            LoadTemplates();
        }

        public void LoadTemplates()
        {
            int index = cobTemplates.SelectedIndex;

            cobTemplates.Items.Clear();

            var path = SqlConfig.Instance().GetPath();
            if (Directory.Exists(path))
            {
                foreach (string dir in Directory.GetDirectories(path))
                {
                    DirectoryInfo d = new DirectoryInfo(dir);
                    cobTemplates.Items.Add(d.Name);
                }
            }

            if (index >= 0 && cobTemplates.Items.Count > index)
                cobTemplates.SelectedIndex = index;
            else if (cobTemplates.Items.Count > 0)
                cobTemplates.SelectedIndex = 0;
        }




        public List<Setting> Settings
        {
            get
            {
                List<Setting> settings = new List<Setting>();
                foreach (SettingUserControl uc in panel1.Controls)
                {
                    settings.Add(uc.Setting);
                }
                return settings;
            }
        }

        private void cobTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            List<Setting> settings = Setting.GetSettings(TemplateFolderPath);
            for (int i = 0; i < settings.Count; i++)
            {
                Setting item = settings[settings.Count - 1 - i];
                SettingUserControl uc = new SettingUserControl(item);
                uc.Dock = DockStyle.Top;
                panel1.Controls.Add(uc);
            }

            string readme = null;
            string readmeFile = TemplateFolderPath.TrimEnd('\\', ' ') + @"\readme.txt";
            if (File.Exists(readmeFile))
            {
                readme = FileUtility.ReadTextFile(readmeFile, 0);
            } 
            if (ShowReadmeOfTemplate != null)
            {
                ShowReadmeOfTemplate(readme);
            }
        }


    }
}
