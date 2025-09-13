using Onoqua.Models;
using Onoqua.Entities.Models;
using System.Data.SqlClient;
using Onoqua.Entities;
using System.Linq;
using A3.DataAccess;

namespace Onoqua.Services.Interfaces
{
    public class DatabaseInterface : IInterface
    {
        public ViewModel Execute(ViewModel model, WorkFlow wf)
        {
            IDataHelper helper = wf.InnterFace.ProviderType.GetHelper(wf.InnterFace);
            var fields = model.Forms.SelectMany(m => m.FieldModel).ToList();
            //switch (wf.InnterFace.ProviderType)
            //{
            //   case "SQL":
            var db = new DataAccess<DBProvider>();
            var result = db.Where(m => m.DBProviderID == wf.InnterFace.ProviderID).FirstOrDefault().SQL.Replace(fields);
            //     break;

            //}

            //var result = wf.InnterFace.ProviderType//.SQL.Replace(fields);
            var ds = helper.GetDataSet(result, fields.ToFieldValue());
            foreach (var i in wf.InnterFace.InterFaceResults)
            {
                model.Forms.SelectMany(m => m.FieldModel).Where(m => m.FieldID == i.FieldID).FirstOrDefault().FieldValue = ds.Tables[0].Rows[0][i.FieldName].ToString();

            }
            return model;
        }
    }
}