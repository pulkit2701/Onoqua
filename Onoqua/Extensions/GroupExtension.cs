using A3.DataAccess;
using Onoqua.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Onoqua.Extensions
{
    public static class GroupExtension
    {
        public static Group GetGroup(this int groupID)
        {
            var da = new DataAccess<Group>();
            return da.Where(m => m.GroupID == groupID).FirstOrDefault();
        }

        public static List<GroupField> GetGroupFields( this int groupID)
        {
            var da = new DataAccess<GroupField>();
            return da.Include(n => n.Field).Where(m => m.GroupID == groupID).OrderBy(n => n.Priority).ToList();
        }

    }
}