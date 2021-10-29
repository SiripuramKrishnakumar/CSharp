using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UGL_CMS_Application.Common.Extensions
{
    public static class DataTables<T>
    {
    
        public static DataTable GetDataTableForSingle(T value)
        {
            if (value != null)
            {
                Type typ = value.GetType();
                DataTable dt = new DataTable(typ.Name);
                DataRow dr = dt.NewRow();
                foreach (PropertyInfo pi in typ.GetProperties())
                {
                    if (Types().Any(i => i.Contains(pi.PropertyType.Name)))
                        dt.Columns.Add(new DataColumn(pi.Name));
                }
                foreach (DataColumn dc in dt.Columns)
                {
                    dr[dc.ColumnName] = value.GetType().GetProperty(dc.ColumnName).GetValue(value);
                }
                dt.Rows.Add(dr);
                return dt;
            }
            return null;
        }
        public static DataTable GetDataTableForList(List<T> values)
        {
            if (values != null && values.Count > 0)
            {
                Type typ = values[0].GetType();
                DataTable dt = new DataTable(typ.Name);
                
                foreach (PropertyInfo pi in typ.GetProperties())
                {
                    if (Types().Any(i=> i.Contains(pi.PropertyType.Name)))
                        dt.Columns.Add(new DataColumn(pi.Name));
                }
                foreach (var value in values)
                {
                    if (value != null)
                    {
                        DataRow dr = dt.NewRow();
                        foreach (DataColumn dc in dt.Columns)
                        {
                            dr[dc.ColumnName] = value.GetType().GetProperty(dc.ColumnName).GetValue(value);
                        }
                        dt.Rows.Add(dr);
                    }
                }
                return dt;
            }
            return null;
        }
        public static string[] Types()
        {
            string[] types = new string[] { nameof(System.String), nameof(System.Int16), nameof(System.Int32), nameof(System.Int64), nameof(System.UInt16), nameof(System.UInt32), nameof(System.UInt64), nameof(System.Boolean), nameof(System.Decimal), nameof(System.Double), nameof(System.Single),nameof(System.Char),nameof(System.Byte),nameof(System.DateTime) };
            return types;
        }
    }
}
