using A3.Common;
using Onoqua.Entities;
using Onoqua.Entities.Models;
using Onoqua.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Onoqua
{
    public static class DataExtensions
    {
        public static IDataHelper GetHelper(this string DBType, InterFace interfaceType)
        {
            //if (DBType == "SQL") return new SQLHelper(connectionString.ConnectionString.ConnectionString1);
            //   if (DBType == "ORACLE") return new OracleHelper(connectionString);
            throw new Exception("DataProvider " + DBType + " does not exist.");
        }

        public static List<FieldValue> ToFieldValue(this List<FieldModel> model)
        {
            List<FieldValue> result = new List<FieldValue>();
            foreach (var i in model)
            {
                result.Add(new FieldValue(i.FieldName, i.FieldValue));
            }
            return result;
        }

      

    }
}