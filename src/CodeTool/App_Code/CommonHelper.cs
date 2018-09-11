using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace CodeTool.App_Code
{
  public class CommonHelper
  {

    public static string DictionaryConvert(string source, string type)
    {
      string result = string.Empty;
      int index = 0;
      string[] array = source.Replace(" ", "").Split(new char[]
      {
                '、'
      });
      for (int i = 0; i < array.Length; i++)
      {
        string line = array[i];
        result += string.Format("INSERT INTO [System_Class] ([int_style],[Class_Name],[Class_Remark],[int_OrderID]) VALUES({0},'{1}','{2}',{3}); \n", new object[]
        {
                    type,
                    line.Replace(" ", ""),
                    line,
                    index
        });
        index++;
      }
      return result;
    }

    public static string SqlTypeToCSharpType(string type, bool isnull)
    {
      string result;
      switch (type.ToLower())
      {
        case "nvarchar":
        case "varchar":
        case "char":
          result = "string";
          break;
        case "bit":
          result = "bool";
          break;
        case "datetime":
        case "datetime2":
        case "datetimeoffset":
        case "date":
        case "smalldatetime":
        case "time":
          result = "DateTime";
          break;
        case "money":
        case "decimal":
        case "numeric":
        case "smallmoney":
          result = "double";
          break;
        case "float":
          result = type.ToLower();
          break;
        case "int":
        case "tinyint":
        case "bigint":
        case "real":
        case "smallint":
          result = "int";
          break;
        default:
          result = "string";
          break;
      }
      return result;
    }
    public static string CreateModel(string tableName)
    {

      string conn = CacheHelper.GetCache(ConfigHelper.ConnectionString).ToString();
      PetaPoco.Database db = new PetaPoco.Database(conn, "");
      var tableInfo = db.Query<TableInfo>(ConfigHelper.SqlTableInfo.Replace(ConfigHelper.TableName, tableName));
      var columnInfo = db.Query<ColumnInfo>(ConfigHelper.SqlTableInfo.Replace(ConfigHelper.TableName, tableName));

      StringBuilder sb = new StringBuilder();
      sb.AppendLine(" using System;");
      sb.AppendLine(" using System.Collections.Generic;");
      sb.AppendLine(" using System.Linq;");
      sb.AppendLine(" using System.Text;");
      sb.AppendLine(" ");
      sb.AppendLine(" namespace  Model");
      sb.AppendLine(" {");
      sb.AppendLine("     /// <summary>");

      sb.AppendLine("     /// </summary>");

      sb.AppendLine("     public class " + tableName);
      sb.AppendLine("     {");
      foreach (var info in columnInfo)
      {
        sb.AppendLine("         /// <summary>");

        string text = string.IsNullOrWhiteSpace(info.ColumnExplain) ? info.ColumnName : info.ColumnExplain;
        text += string.IsNullOrWhiteSpace(info.ColumnDefaultValue) ? "" : "默认：" + info.ColumnDefaultValue;

        sb.AppendLine("         /// " + text);
        sb.AppendLine("         /// </summary>");
        sb.AppendLine("         public " + SqlTypeToCSharpType(info.ColumnType, info.ColumnIsEmpty) + " " + info.ColumnName + "  {  get ;set; }");
        sb.AppendLine(" ");
      }
      sb.AppendLine("     }");
      sb.AppendLine(" }");
      return sb.ToString();
    }





    /// <summary>
    /// 生成存储过程
    /// </summary>
    /// <param name="tableName"></param>
    /// <returns></returns>
    public static string CreateSelectProc(string tableName)
    {
      string temp = ConfigHelper.sqlTempSelect.Replace(ConfigHelper.TableName, tableName);
      return temp;
    }






    public static string Combine(params string[] paths)
    {
      if (paths.Length == 0)
        throw new ArgumentException("please input path");
      var builder = new StringBuilder();
      var spliter = "\\";
      var firstPath = paths[0];
      if (firstPath.StartsWith("HTTP", StringComparison.OrdinalIgnoreCase))
        spliter = "/";
      if (!firstPath.EndsWith(spliter))
        firstPath = firstPath + spliter;
      builder.Append(firstPath);
      for (var i = 1; i < paths.Length; i++)
      {
        var nextPath = paths[i];
        if (nextPath.StartsWith("/") || nextPath.StartsWith("\\"))
          nextPath = nextPath.Substring(1);
        if (i != paths.Length - 1)
        {
          if (nextPath.EndsWith("/") || nextPath.EndsWith("\\"))
          {
            nextPath = nextPath.Substring(0, nextPath.Length - 1) + spliter;
          }
          else
          {
            nextPath = nextPath + spliter;
          }
        }

        builder.Append(nextPath);
      }

      return builder.ToString();
    }
    public static string ReadTextFile(string filePath, Encoding encoding)
    {

      if (!System.IO.File.Exists(filePath))
      {
        return string.Empty;
      }
      string result = string.Empty;
      try
      {
        using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
        {
          using (StreamReader streamReader = new StreamReader(fileStream, encoding))
          {
            result = streamReader.ReadToEnd();
          }
        }
      }
      catch
      {
        // ignored
      }
      return result;
    }
    public static bool WriteTextFile(string filePath, string content, Encoding encoding, FileMode fileMode = FileMode.Create)
    {

      bool result = false;
      try
      {
        using (var fileStream = new FileStream(filePath, fileMode, FileAccess.Write))
        {
          using (var streamWriter = new StreamWriter(fileStream, encoding))
          {
            streamWriter.Write(content);
            result = true;
          }
        }
      }
      catch
      {
        // ignored
      }
      return result;
    }

  }
}
