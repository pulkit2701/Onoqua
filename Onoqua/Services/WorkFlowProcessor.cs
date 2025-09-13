//using A3.DataAccess;
//using Onoqua.Entities.Models;
//using Onoqua.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Web;

//namespace Onoqua.Services
//{
//    public static class WorkFlowProcessor
//    {
//        public static Form Execute(List<WorkFlow> wfs, ref ViewModel model, decimal formID)
//        {
//            var w = wfs.Where(n => n.Priority > wfs.Where(m => m.FormID == formID).Select(m => m.Priority).FirstOrDefault()).ToList();
//            foreach (var wf in w)
//            {
//                if (wf.FormID != 0)
//                    return GetForm(wf.FormID);
//                if (wf.InterFaceID != 0)
//                    InterfaceService.Execute( model, wf);
//                if (wf.TaskID != 0)
//                    TaskProcessor.Execute( model, wf);
//            }

//            return null;
//        }

//        private static Form GetForm(decimal? formID)
//        {
//            var da = new DataAccess<Form>();
//            var da1 = new DataAccess<Group>();
//            var da2 = new DataAccess<GroupField>();
//            var form = da.Where(m => m.FormID == formID).FirstOrDefault();
//            form.FormGroups = da.Where(m => m.FormID == formID).SelectMany(m => m.FormGroups).OrderBy(m => m.Priority).ToList();
//            form.FormGroups.ForEach(m =>
//            {
//                try
//                {
//                    m.Group = da1.Where(n => n.GroupID == m.GroupID).FirstOrDefault();
//                    m.Group.GroupFields = da2.Include(n => n.Field).Where(n => n.GroupID == m.GroupID).OrderBy(n => n.Priority).ToList();
//                }
//            catch(Exception e)
//                {

//                }
//            });

//            return form;
//        }


//        private static List<Field> GetFields(decimal groupid)
//        {
//            var da = new DataAccess<GroupField>();
//            return da.Where(m => m.GroupID == groupid).Select(m => m.Field).ToList();
//        }

//    }
//}