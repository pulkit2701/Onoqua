using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace A3.Common
{
    public static class ExtensionMethods
    {
        public static void Data(this Exception ex, string key, object value)
        {
            if (!ex.Data.Contains(key))
                ex.Data.Add(key, value);
            else

                ex.Data.Add(key + ex.Data.Count.ToString(), value);
        }



        public static void ThrowExcpetionIfNull(this object o, string message)
        {
            if (o == null)
                throw new Exception(message);
        }


        public static string GetFolderName(this DateTime d)
        {
            return d.Month.ToString().PadLeft(2, '0') + d.Day.ToString().PadLeft(2, '0') + d.Year.ToString();
        }



        public static List<string> GetFields(this string data)
        {
            int a = 0;
            a = data.IndexOf("{", a);
            var result = new List<string>();
            while (a > -1)
            {
                result.Add(data.Substring(a, data.IndexOf("}", a) - a + 1));
                a = data.IndexOf("{", a + 1);
            }
            return result;
        }


        public static string GetData(this DataRow row, string fieldname)
        {
            return row[fieldname].ToString();
        }
    }
}
