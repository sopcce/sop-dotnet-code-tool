using System.Data;
using System.Text.RegularExpressions;
using CodeTool.Common.DBUtility;
using CodeTool.Common.Model;

namespace Fabrics
{
    internal class MySqlSchema : ISchema
    {
        DbHelper dbHelper = null;

        public Database GetSchema(string connectionString, DatabaseTypes type)
        {
            Database database = new Database();
            database.ConnString = connectionString;
            database.Type = type;

            //得到获取MySql结构的语句
            string connStr = database.ConnString;
            Match mDatabase = Regex.Match(connStr, @"Database=(?<Database>[^\;]*);");
            if (mDatabase.Success)
            {

                database.Name = mDatabase.Groups["Database"].Value; //已赋数据库名
                connStr = connStr.Replace(string.Format("Database={0};", database.Name), "Database=information_schema;");
            }
            else
            {
                return null;
            }

            dbHelper = DbHelper.Create("MySql");
            dbHelper.ConnectionString = connStr;

            GetTables(database);
            GetViews(database);
            GetStoreProcedures(database);

            return database;
        }

        private void GetStoreProcedures(Database database)
        {
            DataSet dsStoreProcedure = dbHelper.ExecuteDataset(CommandType.Text,
                string.Format("select distinct SPECIFIC_NAME from ROUTINES where ROUTINE_SCHEMA='{0}'", database.Name),
                null);
            foreach (DataRow r in dsStoreProcedure.Tables[0].Rows)
            {
                database.StoreProcedures.Add(r[0].ToString());
            }
        }

        private void GetViews(Database database)
        {
            DataSet dsViews = dbHelper.ExecuteDataset(CommandType.Text,
                string.Format("select distinct TABLE_NAME from information_schema.TABLES where TABLE_SCHEMA='{0}' and TABLE_TYPE='VIEW'", database.Name),
                null);
            foreach (DataRow rView in dsViews.Tables[0].Rows)
            {
                Table view = new Table();
                view.Name = SchemaHelper.GetString(rView[0]);
                GetColumns(database, view);
                view.Fields.Sort();
                database.AddView(view);
            }
        }

        private void GetTables(Database database)
        {
            DataSet dsTables = dbHelper.ExecuteDataset(CommandType.Text,
                string.Format("select distinct TABLE_NAME from information_schema.TABLES where TABLE_SCHEMA='{0}' and TABLE_TYPE='BASE TABLE'", database.Name),
                null);
            foreach (DataRow rTable in dsTables.Tables[0].Rows)
            {
                Table table = new Table();
                table.Name = SchemaHelper.GetString(rTable[0]);
                GetColumns(database, table);
                table.Fields.Sort();
                database.AddTable(table);
            }
        }

        private void GetColumns(Database db, Table table)
        {
            // 对每个表取字段属性
            DataSet dsColumns = dbHelper.ExecuteDataset(CommandType.Text,
               string.Format("select * from COLUMNS where TABLE_SCHEMA='{0}' and TABLE_NAME='{1}'", db.Name, table.Name),
               null);

            foreach (DataRow rField in dsColumns.Tables[0].Rows)
            {
                Field field = new Field();
                field.IsId = rField["EXTRA"].ToString().ToLower() == "auto_increment";
                field.IsKey = rField["COLUMN_KEY"].ToString().ToLower() == "pri";
                field.AllowNull = rField["IS_NULLABLE"].ToString().ToLower() == "yes";
                field.FieldType = SchemaHelper.GetString(rField["DATA_TYPE"]);
                field.DefaultValue = SchemaHelper.GetString(rField["COLUMN_DEFAULT"]);
                field.Descn = SchemaHelper.GetString(rField["COLUMN_COMMENT"]);
                field.Length = SchemaHelper.GetLong(rField["CHARACTER_MAXIMUM_LENGTH"]);
                field.Name = SchemaHelper.GetString(rField["COLUMN_NAME"]);
                field.Pos = SchemaHelper.GetInt(rField["ORDINAL_POSITION"]);
                table.AddField(field);
            }
        }
    }
}
