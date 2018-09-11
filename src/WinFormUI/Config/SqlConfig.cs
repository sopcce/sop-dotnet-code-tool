using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTool.Config
{
    public static class SqlConfig
    {
        public const string HomeUrl = "http://www.sopcce.com";
        public const string XmlUrl = "http://www.socansoft.com/downloads/socanCode/socanCode.xml";
        public const string DownloadUrl = "http://www.socansoft.com/downloads/CodeTool/CodeTool.rar";
       
         


        #region SQL 
        public static string GetAccessProvider { get; set; } = "Provider=Microsoft.Jet.OLEDB.4.0;";

        public static string GetPersistSecurityInfo { get; set; } = "Persist Security Info=True;";

        public static string GetDataSource { get; set; } = "Data Source={0};";


        public static string GetAseConn { get; set; } =
            "Data Source={0};Port={1};User Id={2};Password={3};Database={4};persist security info=true";


        public static string GetDb2Conn { get; set; } =
            "Database={0};User ID={1};Password={2};Server={3};persist security info=true";

        public static string GetMySqlConn { get; set; }
            = "Data Source={0};Port={1};User Id={2};Password={3};Database={4};SslMode=none;";

        public static string GetOracleConn { get; set; }
            = "Data Source={0};Persist Security Info=True;User ID={1};Password={2};Unicode=True";

        public static string GetPostgreSqlConn { get; internal set; }
            = "Server={0};Port={1};User Id={2};Password={3};Database={4};Encoding=UNICODE";

        public static string GetData { get; internal set; }
            = "Data Source={0};";


        #endregion
        
    }
    

}
