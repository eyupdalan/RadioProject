using RadyoTypes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RadyoServis
{
    public static class ServiceHelper
    {

        public static List<SqlParameter> ObjectToSqlParameter(IEntity obj)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            foreach (var item in obj.GetType().GetProperties())
            {
                try
                {
                    object value = item.GetValue(obj, null);
                    if (value != null && !string.IsNullOrWhiteSpace(value.ToString()))
                    {
                        string type = item.PropertyType.ToString();
                        if ((type.Contains("Int") || type.Contains("Enum")) && Convert.ToInt64(value) == 0)
                            continue;

                        list.Add(GetInputParameter(item.Name, value));
                    }
                }
                catch
                {
                    // Do nothing
                }
            }
            return list;
        }

        public static SqlParameter GetInputParameter(string name, object value)
        {
            return (new SqlParameter("@@" + name, value));
        }
    }
}