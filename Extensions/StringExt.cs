using A3.DataAccess;
using Onoqua.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Onoqua
{
    public static class StringExtension
    {
        public static string Replace(this string str, IEnumerable<Field> objs)
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

        public static void SearchGroup(this string searchGroup)
        {
            var da = new DataAccess<Group>();
            UserProfile.Groups.Groups = da.Where(m => m.GroupName.Contains(searchGroup)).ToList();
        }

      

        public static List<Field> GetFieldsByGroup(this decimal groupID)
        {
            var da = new DataAccess<Field>();
            return da.Context.GroupFields.Where(m => m.GroupID == groupID).Select(m => m.Field).ToList();
        }
    }
}