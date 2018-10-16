//using Model;

using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using CodeTool.Common.Model;

namespace CodeTool.Config
{
    public class History
    {
        private static string xmlPath = Application.StartupPath + "\\Config\\";
        private static string xmlName = "History.xml";
        private static string xmlPathAndName = xmlPath + xmlName;


        public DatabaseTypes DatabaseType
        {
            get;
            set;
        }
        public string AccessConn
        {
            get;
            set;
        }
        public string SqlServerConn
        {
            get;
            set;
        }
        public string MySqlConn
        {
            get;
            set;
        }
        public string OracleConn
        {
            get;
            set;
        }
        public string SQLiteConn
        {
            get;
            set;
        }
        public string AseConn
        {
            get;
            set;
        }
        public string DB2Conn
        {
            get;
            set;
        }
        public string PostgreSqlConn
        {
            get;
            set;
        }
        public History()
        {
            this.DatabaseType = DatabaseTypes.Sql2000;
            this.SqlServerConn = "Data Source=.;User ID=sa;Password=;Initial Catalog=;";
        }
        public static History Load()
        {
            History history = new History();
            XmlDocument xmlDocument = new XmlDocument();
            if (File.Exists(History.xmlPathAndName))
            {
                try
                {
                    xmlDocument.Load(History.xmlPathAndName);
                    XmlNode xmlNode = xmlDocument.SelectSingleNode("Config");
                    PropertyInfo[] properties = history.GetType().GetProperties();
                    for (int i = 0; i < properties.Length; i++)
                    {
                        PropertyInfo propertyInfo = properties[i];
                        string value = xmlNode.SelectSingleNode(propertyInfo.Name).Attributes["value"].Value;
                        if (propertyInfo.PropertyType.IsEnum)
                        {
                            propertyInfo.SetValue(history, Enum.Parse(propertyInfo.PropertyType, value), null);
                        }
                        else
                        {
                            propertyInfo.SetValue(history, value, null);
                        }
                    }
                }
                catch (Exception)
                {

                    History.Save(history);
                }
            }
            else
            {


                History.Save(history);
            }
            return history;
        }


        public static void Save(History sys)
        {
            try
            {

                if (!Directory.Exists(xmlPath))
                {
                    Directory.CreateDirectory(xmlPath);
                  
                }

                XmlDocument xmlDocument = new XmlDocument();
                XmlDeclaration nodeDeclarLocation = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
                xmlDocument.AppendChild(nodeDeclarLocation);
                XmlNode xmlNode = xmlDocument.CreateElement("Config");
                xmlDocument.AppendChild(xmlNode);
                PropertyInfo[] properties = typeof(History).GetProperties();
                for (int i = 0; i < properties.Length; i++)
                {
                    PropertyInfo propertyInfo = properties[i];
                    XmlNode xmlNode2 = xmlDocument.CreateElement(propertyInfo.Name);
                    XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("value");
                    xmlAttribute.Value = (propertyInfo.GetValue(sys, null) ?? string.Empty).ToString();
                    xmlNode2.Attributes.Append(xmlAttribute);
                    xmlNode.AppendChild(xmlNode2);
                }
                xmlDocument.Save(History.xmlPathAndName);
            }
            catch (Exception ex)
            {
                MessageBoxMessage.Error(ex.Message);
            }
        }
    }
}
