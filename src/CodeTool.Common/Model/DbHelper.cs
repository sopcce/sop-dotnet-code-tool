using CodeTool.Common.Model;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTool.Common.Model
{
    public class DataPoco
    {
        public static PetaPoco.Database GetPoco(string connectionString, DatabaseTypes databaseTypes)
        {


            PetaPoco.Database dbHelper = new PetaPoco.Database(connectionString, GetEnumDescription(databaseTypes));

            return dbHelper;
        }


        public static string GetEnumDescription(System.Enum enumSubitem)
        {
            string text = enumSubitem.ToString();
            System.Reflection.FieldInfo field = enumSubitem.GetType().GetField(text);
            object[] customAttributes = field.GetCustomAttributes(typeof(DescriptionAttribute), false);
            string result;
            if (customAttributes == null || customAttributes.Length == 0)
            {
                result = text;
            }
            else
            {
                DescriptionAttribute descriptionAttribute = (DescriptionAttribute)customAttributes[0];
                result = descriptionAttribute.Description;
            }
            return result;
        }
    }
}
