using A3.DataAccess;
using Onoqua.Entities.Models;
using Onoqua.Models;
using Onoqua.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using A3.Common;
using System.Data;

namespace Onoqua.Services
{
    public class FormsService
    {

        public FormModel Execute(ViewModel model, WorkFlow wf)
        {
            var da1 = new DataAccess<Form>();
            var result = new FormModel();
            result = (FormModel) da1.Where(m => m.FormID == wf.FormID).FirstOrDefault();
            var a = new OnoquaContext();
            var da = new SQLHelper(a.Database.Connection.ConnectionString);
            var fields = new List<FieldValue>();
            fields.Add(new FieldValue() { Field = "FormID", Value = wf.FormID });
            var data = da.GetDataTable("GetFields", true, fields);
            result.FormID = decimal.Parse(data.Rows[0]["FormID"].ToString());
            result.FormTitle = data.Rows[0]["FormTitle"].ToString();
            foreach (DataRow row in data.Rows)
            {
                result.FieldModel.Add(new FieldModel()
                {
                    FieldID = decimal.Parse(row["FieldID"].ToString()),
                    ID = int.Parse(row["FieldID"].ToString()),
                    FieldName = row["FieldName"].ToString(),
                    FieldPriority = int.Parse(row["FieldPriority"].ToString()),
                    FieldType = row["FieldType"].ToString(),
                    FieldUIClass = row["FieldUIClass"].ToString(),
                    FormID = result.FormID,
                    GroupID = decimal.Parse(row["GroupID"].ToString()),
                    GroupName = row["GroupName"].ToString(),
                    GroupPriority = int.Parse(row["GroupPriority"].ToString()),
                    UIClass = row.GetData("GroupUIClass")

                });
            }
            return result;
        }

    }
}