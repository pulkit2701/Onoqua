using A3.DataAccess;
using Onoqua.Entities.Models;
using Onoqua.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using A3.Common;
using System.Data;


namespace Onoqua
{
    public static class TaskRepository
    {
        public static void Execute(ref ViewModel model, WorkFlow wf)
        {
            var da = new DataAccess<Task>();
            var t = da.Include(m => m.Messages).Where(m => m.TaskID == wf.TaskID).FirstOrDefault();
            var dt = new DataTable();
            var fields = model.Fields.Select(m=>m.BaseValue).ToList();
            var result = dt.Compute(t.Expression.Replace(fields), null);
            model.Fields.Where(m => m.FieldID == t.ResultFieldID).FirstOrDefault().FieldValue = result.ToString();
        }
    }
}