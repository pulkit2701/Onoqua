using A3.DataAccess;
using A3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace A3.Areas.A3Admin.Controllers
{
    public class ModulesController : Controller
    {
        // GET: A3Admin/Modules
        public ActionResult Index()
        {
            if (!UserProfile.LoggedIn)
                return RedirectToAction("Index", "Home", new { area = "" }); 
            var da = new DataAccess<ProcessClient>();
            UserProfile.Processes = da.Where(m => m.ClientID == UserProfile.Client.ClientID).Select(n => n.Process).ToList();

            return View();
        }



        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Index(string ProcessKey)
        {
            if (!UserProfile.LoggedIn)
                return RedirectToAction("Index", "Home", new { area = "" });
            if (ProcessKey == "-1")
                return RedirectToAction("CreateNew", new Process() { ProcessID = -1 });
            else
                return RedirectToAction("CreateNew", UserProfile.Processes.Where(m => m.ProcessID == int.Parse(ProcessKey)).FirstOrDefault());
        }


        public ActionResult CreateNew(string processID)
        {
            if (!UserProfile.LoggedIn)
                return RedirectToAction("Index", "Home", new { area = "" });
            if (processID != "")
                return View(UserProfile.Processes.Where(m => m.ProcessID == int.Parse(processID)).FirstOrDefault());
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult CreateNew(A3.Model.Process data)
        {
            if (!UserProfile.LoggedIn)
                return RedirectToAction("Index", "Home", new { area = "" });
            if (ModelState.IsValid)
            {
               
                var da = new DataAccess<Process>();
                if (data.ProcessID == 0)
                {
                    data.ProcessClients.Add(new ProcessClient() { ClientID = UserProfile.LoggedInUser.ClientID });
                    data = da.Create(data);
                    ViewBag.Title = data.ProcessName + " Process Created";
                }
                else
                {
                    da.Update(data);
                    ViewBag.Title = data.ProcessName + " Process updated";
                }
                
                data = new Process();
            }
            return View(data);
        }

    }
}