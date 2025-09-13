using Onoqua.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onoqua.Entities.Models
{
    public static class EntityExtensions
    {
        public static void Clean(this List<Form> form)
        {
            var ctr = 0;
            while(ctr<form.Count())
            {
                form[ctr].FormGroups.Clear();
                form[ctr].WorkFlows.Clear();
                ctr++;
            }
        }

        public static Field Sync(this Field data)
        {
            var result = new Field();
            result.FieldExpressions = data.FieldExpressions;
            result.FieldID = data.FieldID;
            result.FieldName = data.FieldName;
            result.FieldType = data.FieldType;
            result.FieldValue = data.FieldValue;
            return result;
        }
    }
}
