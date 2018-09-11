
using CodeTool.Common.Model;

namespace Fabrics
{
    interface ISchema
    {
        Database GetSchema(string connectionString, DatabaseTypes type);
    }
}
