using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tool
{
    public class IniHelper
    {
        private string filePath = null;

        private static Dictionary<string, IniHelper> dic = new Dictionary<string, IniHelper>();

        private IniHelper(string filePath)
        {
            this.filePath = filePath;
        }

        public static IniHelper Instance(string type)
        {
            string path = $".\\Config\\{type}.Config";
            if (!Directory.Exists(".\\Config"))
            {
                Directory.CreateDirectory(".\\Config");
            }
            if (!File.Exists(path))
            {
                FileStream fileStream = File.Create(path);
                fileStream.Close();
                fileStream.Dispose();
            }
            return new IniHelper(path);
        }

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern long GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public bool Write<T>(T value, string section, string key)
        {
            return WritePrivateProfileString(section, key, value.ToString(), filePath) != 0;
        }

        public T Read<T>(string section, string key, T defaultValue)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (GetPrivateProfileString(section, key, null, stringBuilder, 1000, filePath) != 0 && !string.IsNullOrEmpty(stringBuilder.ToString()))
            {
                Type typeFromHandle = typeof(T);
                return (T)Convert.ChangeType(stringBuilder.ToString(), typeFromHandle);
            }
            return defaultValue;
        }
    }

}
