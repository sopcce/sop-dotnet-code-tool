using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTool.Common.Generator;

namespace CodeTool.Config
{
    public  class SqlConfig
    {
        public static string HomeUrl = "http://www.sopcce.com";
        public static string XmlUrl = "http://www.sopcce.com/downloads/codeTool.xml";
        public static string DownloadUrl = "http://www.sopcce.com/downloads/CodeTool.rar";
        public static string ChromeAppKey = @"\Software\Microsoft\Windows\CurrentVersion\App Paths\chrome.exe";


        public SqlConfig()
        {
            
        }






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
