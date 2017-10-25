 

using System.Text;
using System.Text.RegularExpressions;

namespace CodeTool.EditorHelper
{
    public class CSharpFormatHelper
    {
        /// <summary>
        /// remove empty lines from string
        /// </summary>
        /// <param name="lines"></param>
        /// <returns></returns>
        public static string RemoveEmptyLines(string lines)
        {
            return Regex.Replace(lines, @"^\s*$\n|\r", "", RegexOptions.Multiline).TrimEnd();
        }
        /// <summary>
        /// Indent String with Spaces
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public static string Indent(int count)
        {
            if (count <= 0)
            {
                return "";
            }
            else
            {
                return "    ".PadLeft(count * 2);
            }
        }

        /// <summary>
        /// Formatting C# code
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static string FormatCSharpCode(string code)
        {
            //去除空白行
            code = RemoveEmptyLines(code);
            StringBuilder sb = new StringBuilder();
            int count = 2;
            int times = 0;
            string[] lines = code.Split('\n');
            foreach (var line in lines)
            {

                if (line.TrimStart().StartsWith("{") || line.TrimEnd().EndsWith("{"))
                {
                    sb.Append(Indent(count * times) + line.TrimStart() + "\n");
                    times++;

                }
                else if (line.TrimStart().StartsWith("}"))
                {
                    times--;
                    if (times <= 0)
                    {
                        times = 0;
                    }

                    sb.Append(Indent(count * times) + line.TrimStart() + "\n");

                }
                else
                {
                    sb.Append(Indent(count * times) + line.TrimStart() + "\n");
                }
            }
            return sb.ToString();
        }
    }
}
