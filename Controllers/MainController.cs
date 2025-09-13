using A3.DataAccess;
using Onoqua.Entities.Models;
using Onoqua.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Onoqua.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        [ValidateAntiForgeryToken]
        public ActionResult Index(List<Onoqua.Entities.Models.Process> data)
        {
            var procs = new List<ProcessClient>();
            foreach (var i in data.Where(m => m.IsSelected).ToList())
            {
                procs.Add(new ProcessClient() { ClientID = UserProfile.Client.ClientID, ProcessID = i.ProcessID });
            }
            var da = new DataAccess<ProcessClient>();
            da.Create(procs);
            var items = new List<Process>();
            var d = new DataAccess<Process>();
            data.ForEach(m =>
            {
                items.Add(d.Where(r => r.ProcessID == m.ProcessID).FirstOrDefault());
            });
            UserProfile.Processes = items;
            return View();
        }


        [ValidateAntiForgeryToken]
        public ActionResult Login(Entity e)
        {
            var da = new DataAccess<Entity>();
            var entity = da.Include(m => m.Client).Where(m => m.emailID == e.emailID && m.Password == e.Password).FirstOrDefault();
            if (entity == null)
                return View(@"..\default\index");
            UserProfile.Client = entity.Client;
            UserProfile.LoggedInUser = entity;

            var model = new ViewModel();
            model.Processes = da.Where(m => m.Client.ClientID == entity.ClientID && entity.EntityID == m.EntityID).SelectMany(m => m.Client.ProcessClients).Select(m => m.Process).ToList();
            return View(model);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Show(ViewModel model, decimal? processID, decimal? btnValue = 1)
        {
            if (UserProfile.Model.Processes.Count() == 0)
                InitModel(processID);
            model.CurrentFormId = UserProfile.Model.CurrentFormId;
            var newModel = SyncFields(model);
            if (btnValue == 1)
            {
                var p = new Processor();
                newModel = p.Execute(UserProfile.Model.Processes[0].ProcessID, UserProfile.Model.CurrentFormId, newModel);
            }
            if (btnValue == -1)
            {
                var wfs = UserProfile.Model.Workflows.Where(m => m.FormID != null && m.Priority < UserProfile.Model.Workflows.Where(n => n.FormID == model.CurrentFormId).FirstOrDefault().Priority).ToList();
                newModel.CurrentFormId = wfs[wfs.Count() - 1].FormID.Value;
            }
            newModel.Workflows = UserProfile.Model.Workflows;
            UserProfile.Model = newModel;
            if (newModel.CurrentFormId > 0)
            {
                newModel.CurrentForm = newModel.Forms.Where(m => m.FormID == newModel.CurrentFormId).FirstOrDefault();
                return RedirectToAction("ShowView", "Main", newModel);
            }
            else
                return null;


        }


        public ActionResult ShowView()
        {
            var newModel = SetVM(UserProfile.Model);
            return View("Show", newModel);
        }

        private ViewModel SetVM(ViewModel model)
        {
            var vm = new ViewModel();
            vm.CurrentForm.FormTitle = model.CurrentForm.FormTitle;
            vm.CurrentForm.FieldModel = model.CurrentForm.FieldModel;//.Forms.Where(m => m.FormID == model.CurrentFormId).FirstOrDefault().FormGroups.OrderBy(m => m.GroupID).OrderBy(m => m.Priority).ToList();
            return vm;
        }

        

        private FormGroup AddformGroup(FieldModel m)
        {
            var result = new FormGroup();
            result.UIClass = m.UIClass;
            result.Priority = m.GroupPriority;
            result.GroupID = m.GroupID;
            result.FormID = m.FormID;
            result.Group = new Group() { GroupID = m.GroupID, GroupName = m.GroupName };

            return result;
        }


        private void InitModel(decimal? processID)
        {
            var model = new ViewModel();
            var da = new DataAccess<Process>();
            model.Processes.Add(da.Where(m => m.ProcessID == processID).FirstOrDefault());
            var p = new Processor();
            model.Workflows = p.GetWorkFlows(model.Processes[0].ProcessID, UserProfile.Client);
            model.CurrentFormId = 0;
            UserProfile.Model = model;
        }

        public void Logout()
        {
            UserProfile.Clear();
            Response.Redirect("localhost/onoqua/default");
        }



        ViewModel SyncFields(ViewModel model)
        {
            if (model.CurrentFormId != 0)
            {
                int ctr = 0;
                while (ctr < UserProfile.Model.CurrentForm.FieldModel.Count())
                {
                    UserProfile.Model.CurrentForm.FieldModel[ctr].FieldValue = model.CurrentForm.FieldModel[ctr].FieldValue;
                    ctr++;
                }
            }
        
            return UserProfile.Model;

        }

        public ActionResult SetUp(decimal? processID)
        {
            return null;
        }


        public ActionResult ShowForm(ViewModel model)
        {
            var m = new ViewModel();
            return View(m);
        }



    }
}