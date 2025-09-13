using Onoqua.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Onoqua.Models
{
    public static class ExtensionMethods
    {
        public static FieldModel Sync(this FieldModel data)
        {
            var result = new FieldModel();
            result.FieldExpressions = data.FieldExpressions;
            result.FieldID = data.FieldID;
            result.FieldName = data.FieldName;
            result.FieldPriority = data.FieldPriority;
            result.FieldType = data.FieldType;
            result.FieldUIClass = data.FieldUIClass;
            result.FieldValue = data.FieldValue;
            result.FormID = data.FormID;
            result.GroupID = data.GroupID;
            result.GroupName = data.GroupName;
            result.GroupPriority = data.GroupPriority;
            result.UIClass = data.UIClass;
            return result;
        }
    }
}