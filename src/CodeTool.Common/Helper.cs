using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CodeTool.Common
{
    public class Helper
    {
        /// <summary>
        /// 输出日志文件启用，方便运维统计
        /// </summary>
        /// <param name="msg">内容</param>
        /// <param name="fileNamePrefix">文件前缀</param>
        /// <param name="filePath">时间指定的格式进行转换</param>
        /// <param name="fileNameSuffix">时间指定的格式进行转换</param>
        public static void WriteLog(string msg, string fileNamePrefix = "Log", bool append = true, string filePath = "yyyyMM/dd", string fileNameSuffix = "yyyy-MM-dd")
        {
            try
            {
                string fileName =
                    string.Format("~/Log/{0}/{1}_{2}.txt",
                        DateTime.Now.ToString("yyyyMM/dd"),
                        fileNamePrefix,
                        DateTime.Now.ToString(fileNameSuffix));


                string path = FileUtility.GetDiskFilePath(fileName);
                path = FileUtility.Combine(path, System.IO.Path.GetFileName(fileName));

                msg = "\r\n  ========================================          \n\n" + msg + "\r\n";
                WriteFile(path, msg, append);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }








        /// <summary>
        /// 写入文件（会检测目录是否存在，不存在则自动创建目录）
        /// </summary>
        public static void WriteFile(string filePath, string content, bool append = false)
        {
            string dir = filePath.Substring(0, filePath.LastIndexOf(@"\"));
            if (false == Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(filePath, append, Encoding.UTF8);
                sw.Write(content);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                sw.Close();
            }
        }


















       

        /// <summary>
        /// 拷贝文件
        /// </summary>
        public static void CopyFolder(string sourceDirName, string destDirName)
        {
            Directory.CreateDirectory(destDirName);

            if (!Directory.Exists(sourceDirName)) return;

            string[] directories = Directory.GetDirectories(sourceDirName);

            if (directories.Length > 0)
            {
                foreach (string d in directories)
                {
                    CopyFolder(d, destDirName + d.Substring(d.LastIndexOf(@"\")));
                }
            }

            string[] files = Directory.GetFiles(sourceDirName);

            if (files.Length > 0)
            {
                foreach (string s in files)
                {
                    string destFile = destDirName + s.Substring(s.LastIndexOf(@"\"));
                    if (!File.Exists(destFile))
                    {
                        File.Copy(s, destDirName + s.Substring(s.LastIndexOf(@"\")), true);
                    }
                }
            }
        }

        /// <summary>
        /// 移动目录
        /// </summary>
        /// <param name="sourceDirName">原目录</param>
        /// <param name="destDirName">新目录</param>
        public static void MoveFolder(string sourceDirName, string destDirName)
        {
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            FileSystemInfo[] sfiles = dir.GetFileSystemInfos();
            if (sfiles != null && sfiles.Length > 0)
            {
                for (int i = 0; i < sfiles.Length; i++)
                {
                    if (sfiles[i].Attributes == FileAttributes.Directory)
                    {
                        MoveFolder(sfiles[i].FullName, destDirName + "\\" + sfiles[i].Name);
                    }
                    else
                    {
                        FileInfo file = (FileInfo)sfiles[i];
                        file.CopyTo(destDirName + "\\" + file.Name, true);
                        file.Delete();
                    }
                }
            }

            Directory.Delete(sourceDirName);
        }

        /// <summary>
        /// 获取一个目录下所有的文件，包括子文件
        /// </summary>
        public static List<string> GetAllFiles(string dirPath)
        {
            List<string> lst = new List<string>();
            FindFile(dirPath, lst);
            return lst;
        }

        private static void FindFile(string dirPath, List<string> files)
        {
            //在指定目录及子目录下查找文件,放入List<string>中
            DirectoryInfo Dir = new DirectoryInfo(dirPath);
            foreach (FileInfo f in Dir.GetFiles()) //查找文件
            {
                files.Add(Dir + "\\" + f.ToString()); //填加文件名
            }

            foreach (DirectoryInfo d in Dir.GetDirectories()) //查找子目录 
            {
                FindFile(Dir + "\\" + d.ToString() + "\\", files);
            }
        }
    }
}
