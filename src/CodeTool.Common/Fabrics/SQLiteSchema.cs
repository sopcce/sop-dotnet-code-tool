using System;
using System.Data;
using System.Data.SQLite;
using System.Collections;
using CodeTool.Common.DBUtility;
using CodeTool.Common.Model;

namespace Fabrics
{
    internal class SQLiteSchema : ISchema
    {
        private DbHelper helper = null;

        private void GetColumns(Table table)
        {
            DataTable schema;
            using (SQLiteConnection connection = new SQLiteConnection(helper.ConnectionString))
            {
                connection.Open();
                schema = connection.GetSchema("COLUMNS");
            }

            foreach (DataRow r in schema.Select(string.Format("TABLE_NAME = '{0}'", table)))
            {
                Field model = new Field();

                model.AllowNull = Convert.ToBoolean(r["IS_NULLABLE"]);
                model.FieldNumber = Convert.ToInt32(r["ORDINAL_POSITION"]);
                model.FieldName = r["COLUMN_NAME"].ToString();
                model.FieldType =  SchemaHelper.GetString(r["DATA_TYPE"]);
                model.DefaultValue = r["COLUMN_DEFAULT"].ToString();
                model.FieldDescn = SchemaHelper.GetString(r["DESCRIPTION"]);
                model.FieldSize = Convert.ToInt32((r["CHARACTER_MAXIMUM_LENGTH"] == DBNull.Value) ? 0 : r["CHARACTER_MAXIMUM_LENGTH"]);
                model.FieldLength = SchemaHelper.GetInt(r["CHARACTER_MAXIMUM_LENGTH"]);
                model.IsId = SchemaHelper.GetBool(r["AUTOINCREMENT"]);

                if (Convert.ToBoolean(r["PRIMARY_KEY"]))
                {
                    model.IsKey = true;
                }
                else
                {
                    model.IsKey = false;
                }

                table.AddField(model);
            }
        }

        private void GetProcedures(Database db)
        {

        }

        public Database GetSchema(string connectionString, DatabaseTypes type)
        {
            Database db = new Database();
            db.ConnString = connectionString;
            db.Type = type;
            this.helper = DbHelper.Create("SQLite");
            helper.ConnectionString = connectionString;
            this.GetTables(db);
            this.GetViews(db);
            //this.GetProcedures(db);//‘›Œ¥≈‰÷√
            return db;
        }

        private void GetTables(Database db)
        {
            DataSet set = this.helper.ExecuteDataset(CommandType.Text, "select name from sqlite_master where type = 'table' and name NOT LIKE 'sqlite_%' ORDER BY name", null);
            foreach (DataRow row in set.Tables[0].Rows)
            {
                if (!(row["Name"].ToString() == "XP_PROC"))
                {
                    Table table = new Table();
                    table.Name = row["Name"].ToString();
                    this.GetColumns(table);
                    table.Fields.Sort();
                    db.AddTable(table);
                }
            }
        }

        private void GetViews(Database db)
        {
            DataSet set = this.helper.ExecuteDataset(CommandType.Text, "select name from sqlite_master where type = 'view' and name NOT LIKE 'sqlite_%' ORDER BY name", null);
            foreach (DataRow row in set.Tables[0].Rows)
            {
                Table table = new Table();
                table.Name = row["Name"].ToString();
                this.GetColumns(table);
                table.Fields.Sort();
                db.AddView(table);
            }
        }
    }
}
