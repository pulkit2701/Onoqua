using A3.DataAccess;
using Onoqua.Entities.Models;
using Onoqua.Models;
using Onoqua.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Onoqua
{
    public class Processor
    {
        public ViewModel Execute(decimal processID, decimal formID, ViewModel model)
        {
            var da = new DataAccess<WorkFlow>();
            IEnumerable<WorkFlow> wfs;
            wfs = model.Workflows;
            if (formID != 0)
                wfs = wfs.Where(m => m.Priority > wfs.Where(n => n.FormID == formID).FirstOrDefault().Priority).ToList();
            else
                wfs = wfs.Where(n => n.Priority <= wfs.Where(m => m.FormID != null).OrderBy(m => m.Priority).FirstOrDefault().Priority).ToList();
            foreach (var wf in wfs)
            {
                if (wf.InterFaceID != null)
                    model = InterfaceService.Execute(model, wf);
                if (wf.FormID != null)
                {
                    var f = new FormsService();
                    var form = f.Execute(model, wf);
                    model.CurrentFormId = form.FormID;
                    form.IsFirst = wf.isFirst;
                    form.IsLast = wf.IsLast;
                    model.Forms.Add(form);
                    model.CurrentFormId = form.FormID;
                    return model;
                };
                if (wf.TaskID != null)
                    model = TaskProcessor.Execute(model, wf);
            }

            return model;
        }



        ViewModel SetModel(Form form, ViewModel model)
        {
            form.FormGroups.ForEach(m =>
                {
                    m.Group.GroupFields.ForEach(n =>
                        {
                            if (model.Fields.Where(a => a.FieldID == n.FieldID).Count() > 0)
                                model.Fields.Where(a => a.FieldID == n.FieldID).FirstOrDefault().FieldValue = n.Field.FieldValue;
                            else
                            {
                                model.Fields.Add(new FieldModel()
                                {
                                    FieldExpressions = n.Field.FieldExpressions,
                                    FieldID = n.Field.FieldID,
                                    FieldName = n.Field.FieldName,
                                    FieldPriority = n.Priority,
                                    FieldType = n.Field.FieldType,
                                    FieldValue = n.Field.FieldValue,
                                    FormID = m.FormID,
                                    GroupName = m.Group.GroupName,
                                    GroupPriority = m.Priority,
                                    UIClass = m.UIClass,
                                    FieldUIClass = n.UIClass,
                                    GroupID = m.GroupID
                                });
                            }
                        });
                });

            return model;
        }

        public List<WorkFlow> GetWorkFlows(decimal processID, Client c)
        {
            var da = new DataAccess<ProcessClient>();
            return da.Where(m => m.ProcessID == processID && m.ClientID == c.ClientID || m.ClientID == 0).SelectMany(m => m.Process.WorkFlows).OrderBy(m => m.Priority).ToList();

        }

    }


}