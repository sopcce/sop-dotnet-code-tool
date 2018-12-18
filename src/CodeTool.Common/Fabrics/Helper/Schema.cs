
using CodeTool.Common.Fabrics;
using CodeTool.Common.Model;

namespace Fabrics
{
    public class Schema
    {
        private ISchema iSchema;

        private string connectionString;
        private DatabaseTypes type;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public DatabaseTypes Type
        {
            get { return type; }
            set
            {
                type = value;

                switch (value)
                {
                    case DatabaseTypes.Access:
                        iSchema = new AccessSchema();
                        break;
                    case DatabaseTypes.MySql:
                        iSchema = new MySqlSchema();
                        break;
                    case DatabaseTypes.Oracle:
                        iSchema = new OracleSchema();
                        break;
                    case DatabaseTypes.SQLite:
                        iSchema = new SQLiteSchema();
                        break;
                    case DatabaseTypes.Ase:
                        iSchema = new AseSchema();
                        break;
                    case DatabaseTypes.DB2:
                        iSchema = new DB2Schema();
                        break;
                    case DatabaseTypes.PostgreSql:
                        iSchema = new PostgreSqlSchema();
                        break;
                    case DatabaseTypes.Sql2000:
                    case DatabaseTypes.Sql2005:
                    default:
                        iSchema = new SqlSchema();
                        break;
                }
            }
        }

        public Schema()
        {
        }

        public Schema(string connectionString, DatabaseTypes type)
        {
            this.connectionString = connectionString;
            Type = type;
        }

        /// <summary>
        /// 获取数据库信息
        /// </summary>
        public Database GetSchema()
        {
            Database db = iSchema.GetSchema(connectionString, type);
            foreach (Table tb in db.Tables)
            {
                foreach (Field fd in tb.Fields)
                {
                    if (fd.FieldLength < 0)
                    {
                        fd.FieldLength = 4000;
                    }
                }
            }
            return db;
        }
    }
}
