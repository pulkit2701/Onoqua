using A3.DataAccess;
using Onoqua.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Onoqua.Extensions
{
    public static class FieldExtension
    {
        public static List<Field> SearchFields(this string searchField)
        {
            var da = new DataAccess<Onoqua.Entities.Models.Field>();
            var result = da.Where(m => m.FieldName.Contains(searchField)).ToList();
            UserProfile.Fields = result;
            return result;

        }

        public static List<Field> SearchFields(this string searchField, int groupId)
        {
            var da = new DataAccess<Onoqua.Entities.Models.Field>();
            
            var r = da.Context.GroupFields.Where(m => m.GroupID == groupId).Select(m=>m.FieldID).ToList();
            var result = da.Where(m => m.FieldName.Contains(searchField) && !r.Contains(m.FieldID)).ToList();

            UserProfile.Fields = result;
            return result;

        }


        public static Field GetField(this int fieldID)
        {
            var da = new DataAccess<Field>();
            return da.Where(m => m.FieldID == fieldID).FirstOrDefault();

        }

        public static List<Group> GetAttachedGroups(this int fieldID)
        {
            var da = new DataAccess<Group>();
            return da.Context.GroupFields.Where(m => m.FieldID == fieldID).Select(m => m.Group).ToList();
        }

        public static List<Field> GetFields(this int groupID)
        {
            var da = new DataAccess<Group>();
            return da.Where(m => m.GroupID == groupID).SelectMany(m => m.GroupFields).Select(m => m.Field).ToList();
        }
    }
}