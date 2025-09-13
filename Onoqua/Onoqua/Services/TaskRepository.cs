using A3.DataAccess;
using Onoqua.Entities.Models;
using Onoqua.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using A3.Common;
using System.Data;
using Onoqua.Services;


namespace Onoqua
{
    public static class TaskProcessor
    {
        public static ViewModel Execute(ViewModel model, WorkFlow wf)
        {
            var da = new DataAccess<Task>();
            var t = da.Include(m => m.Messages).Where(m => m.TaskID == wf.TaskID).FirstOrDefault();
            var dt = new DataTable();
            var fields = model.Forms.SelectMany(m => m.FieldModel).ToList();
            var result = dt.Compute(t.Expression.Replace(fields), null);
            model.Forms.SelectMany(m => m.FieldModel).Where(m => m.FieldID == t.ResultFieldID).FirstOrDefault().FieldValue = result.ToString();
            return model;
        }
    }
}