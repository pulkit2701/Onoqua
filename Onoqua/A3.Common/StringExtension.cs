using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3.Common
{
    public static class StringExtension
    {
        public static string Replace(this string str, IEnumerable<BaseKeyValue> objs)
        {
            while (str.IndexOf('{') > 0)
            {
                var field = "{" + str.Substring(str.IndexOf('{') + 1, str.IndexOf('}') - str.IndexOf('{') - 1) + "}";
                var value = objs.Where(m => "{" + m.FieldID + "}" == field).FirstOrDefault();
                if (value != null)
                    str = str.Replace("{" + field + "}", value.FieldValue);
            }
            return str;
        }
    }
}
