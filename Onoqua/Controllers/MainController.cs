using A3.DataAccess;
using Onoqua.Entities.Models;
using Onoqua.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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


        public ActionResult Show(ViewModel model)
        {
            return null;

        }



    }
}