using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using CodeTool.Common.DBUtility;
using CodeTool.Common.Model;

namespace Fabrics
{
    internal class SqlSchema : ISchema
    {
        public Database GetSchema(string connectionString, DatabaseTypes type)
        {
            Database database = new Database();
            database.ConnString = connectionString;
            database.Type = type;

            //获取数据库结构
            DbHelper dbHelper = DbHelper.Create("SqlServer");
            dbHelper.ConnectionString = database.ConnString;

            string sqlTable = GetSql(database.Type, SchemaHelper.SchemaType.Table);
            DataSet ds = dbHelper.ExecuteDataset(CommandType.Text, sqlTable, null);
            List<Table> tables = GetSQLTableList(ds);


            //todo
            //var db = DataPoco.GetPoco(connectionString, type);
            //var dd = db.Query<FieldInfo>(sqlTable);

            //foreach (var item in dd)
            //{
            //    var SDSDS = item.DefaultValue;
            //}





            foreach (Table table in tables)
            {
                database.AddTable(table);
            }

            ds = dbHelper.ExecuteDataset(CommandType.Text,
                GetSql(database.Type, SchemaHelper.SchemaType.View), null);
            List<Table> views = GetSQLTableList(ds);
            foreach (Table view in views)
            {
                database.AddView(view);
            }

            ds = dbHelper.ExecuteDataset(CommandType.Text, SqlForGetStoreProcedures, null);
            database.StoreProcedures = GetSQLStoreProcedureList(ds);

            return database;
        }

        /// <summary>
        /// 取得表结构的SQL语句
        /// </summary>
        private string GetSql(DatabaseTypes type, SchemaHelper.SchemaType schemaType)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append("SELECT d.name N'TableName',a.colorder N'FieldNumber',a.name N'FieldName', ");
            strSql.Append("(case when COLUMNPROPERTY( a.id,a.name,'IsIdentity')=1 then '1'else '0' end) N'IsId',");
            strSql.Append("(case when (SELECT count(*) ");
            strSql.Append(" FROM sysobjects WHERE (name in (SELECT name FROM sysindexes ");
            strSql.Append(" WHERE (id = a.id) AND (indid in (SELECT indid FROM sysindexkeys");
            strSql.Append(" WHERE (id = a.id) AND (colid in (SELECT colid FROM syscolumns");
            strSql.Append(" WHERE (id = a.id) AND (name = a.name))))))) AND (xtype = 'PK'))>0 ");
            strSql.Append(" then '1' else '0' end) N'IsKey', b.name N'FieldType',a.length N'FieldSize', ");
            strSql.Append(" COLUMNPROPERTY(a.id,a.name,'PRECISION') as N'FieldLength', ");
            strSql.Append(" isnull(COLUMNPROPERTY(a.id,a.name,'Scale'),0) as N'DecimalDigits', ");
            strSql.Append(" (case when a.isnullable=1 then '1'else '0' end) N'AllowNull', isnull(e.text,'') N'DefaultValue', ");
            strSql.Append(" isnull(g.[value],'') AS N'FieldDescn' ");
            strSql.Append(" FROM syscolumns a left join systypes b on a.xtype=b.xusertype inner join sysobjects d  on a.id=d.id");

            switch (schemaType)
            {
                case SchemaHelper.SchemaType.View:
                    strSql.Append(" and d.xtype='V'");
                    break;
                case SchemaHelper.SchemaType.Table:
                default:
                    strSql.Append(" and d.xtype='U'");
                    break;
            }

            strSql.Append("and d.name<>'dtproperties' left join syscomments e on a.cdefault=e.id");

            if (type == DatabaseTypes.Sql2005)
            {
                strSql.Append(" left join sys.extended_properties g on a.id=g.major_id AND a.colid = g.minor_id order by object_name(a.id),a.colorder");
            }
            else
            {
                strSql.Append(" left join sysproperties g on a.id=g.id AND a.colid = g.smallid order by object_name(a.id),a.colorder ");
            }

            return strSql.ToString();
        }

        /// <summary>
        /// SqlServer中取得存储过程的SQL语句
        /// </summary>
        private string SqlForGetStoreProcedures = "select distinct(name) from sysobjects where type='p' ";

        private List<Table> GetSQLTableList(DataSet ds)
        {
            DataTable dt = ds.Tables[0];
            List<Table> tables = new List<Table>();
            foreach (DataRow r in dt.Rows)
            {
                Field field = GetField(r);
                string parentTableName = SchemaHelper.GetString(r["TableName"]);

                bool hasTable = false;
                foreach (Table modelTable in tables)
                {
                    if (parentTableName == modelTable.Name)
                    {
                        modelTable.AddField(field);
                        hasTable = true;
                        break;
                    }
                }
                if (!hasTable)
                {
                    Table newTable = new Table();
                    newTable.Name = parentTableName;
                    newTable.AddField(field);
                    tables.Add(newTable);
                }
            }

            foreach (Table table in tables)
            {
                table.Fields.Sort();
            }
            return tables;
        }

        /// <summary>
        /// 获取所有存储过程集合
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>
        private List<string> GetSQLStoreProcedureList(DataSet ds)
        {
            List<string> storeProcedures = new List<string>();
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                storeProcedures.Add(r[0].ToString());
            }
            return storeProcedures;
        }

        private Field GetField(DataRow r)
        {
            Field model = new Field();
            model.AllowNull = SchemaHelper.GetBool(r["AllowNull"]);
            model.DefaultValue = SchemaHelper.GetString(r["DefaultValue"]);
            model.FieldDescn = SchemaHelper.GetString(r["FieldDescn"]);
            model.FieldLength = SchemaHelper.GetInt(r["FieldLength"]);
            model.FieldName = SchemaHelper.GetString(r["FieldName"]);
            model.FieldNumber = SchemaHelper.GetInt(r["FieldNumber"]);
            model.FieldSize = SchemaHelper.GetInt(r["FieldSize"]);
            model.FieldType = SchemaHelper.GetString(r["FieldType"]);
            model.IsId = SchemaHelper.GetBool(r["IsId"]);
            model.IsKey = SchemaHelper.GetBool(r["IsKey"]);
            return model;
        }

    }
    public class FieldInfo
    {
        public string TableName { get; set; }
        public string FieldNumber { get; set; }
        public string FieldName { get; set; }
        public string FieldSize { get; set; }
        public string FieldType { get; set; }
        public string IsId { get; set; }
        public string IsKey { get; set; }
        public string FieldLength { get; set; }
        public string FieldDescn { get; set; }
        public string AllowNull { get; set; }
        public string DefaultValue { get; set; }
        public string DecimalDigits { get; set; }
        
    }
}
