using A3.DataAccess;
using Onoqua.Entities.Models;
using Onoqua.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Onoqua
{
    public static class Processor
    {
        public static decimal Execute(decimal processID, decimal processStepID, decimal formID, bool isSetup, ref ViewModel model)
        {
            var da = new DataAccess<WorkFlow>();
            IEnumerable<WorkFlow> wfs;
            if (isSetup)
                wfs = da.Where(m => m.ProcessStep.IsSetup && m.ProcessID == processID).OrderBy(m => m.Priority);
            else
            {
                wfs = da.Where(m => !m.ProcessStep.IsSetup && m.ProcessID == processID).OrderBy(m => m.Priority);
                wfs = wfs.Where(m => m.Priority > wfs.Where(n => n.FormID == formID).FirstOrDefault().Priority);
            }
            foreach (var wf in wfs)
            {
                if (wf.InterFaceID != 0)
                {
                    InterfaceService.Execute(ref model, wf);
                }
                if (wf.FormID != 0)
                {

                    return wf.FormID;
                };
                if (wf.TaskID != 0)
                {
                    TaskRepository.Execute(ref model, wf);
                }
            }
            return 0;
        }
    }
}