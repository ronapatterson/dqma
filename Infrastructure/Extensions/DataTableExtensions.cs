using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace DQMA.Infrastructure.Extensions
{
    public static class DataTableExtensions
    {
        public static IList<T> ToList<T>(this DataTable table) where T : new()
        {
            IList<PropertyInfo> properties = typeof(T).GetProperties().ToList();
            IList<T> result = new List<T>();

            foreach (var row in table.Rows)
            {
                var item = CreateItemFromRow<T>((DataRow)row, properties);
                result.Add(item);
            }

            return result;
        }

        public static T ToObject<T>(this DataTable table) where T : new()
        {
            T result = default;

            if (table.Rows.Count > 0)
            {
                IList<PropertyInfo> properties = typeof(T).GetProperties().ToList();
                result = new T();

                foreach (var row in table.Rows)
                {
                    result = CreateItemFromRow<T>((DataRow)row, properties);
                }

                return result;
            }

            return result;
        }

        private static T CreateItemFromRow<T>(DataRow row, IList<PropertyInfo> properties) where T : new()
        {
            T item = new T();

            foreach (var property in properties)
            {
                if (row.Table.Columns.Contains(property.Name) && row[property.Name] != DBNull.Value)
                {
                    if (property.PropertyType.IsEnum)
                    {
                        if (row[property.Name] is string)
                            property.SetValue(item, Enum.Parse(property.PropertyType, row[property.Name].ToString()), null);
                        else
                            property.SetValue(item, Enum.ToObject(property.PropertyType, row[property.Name]), null);
                    }
                    else
                        property.SetValue(item, row[property.Name], null);
                }
            }
            return item;
        }
    }
}
