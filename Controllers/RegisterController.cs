using A3.DataAccess;
using Onoqua.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Onoqua.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            var m = new Client();
            var e= new Entity();
            e.Address = new Address();
            m.Entities.Add(e);
            return View(m);
        }

        [ValidateAntiForgeryToken]
        public ActionResult Register(Onoqua.Entities.Models.Client m, Entity e, Address a)
        {
            var da = new DataAccess<Client>();
            e.Address = a;
            e.RoleID = 1;
            m.Entities.Add(e);
            m = da.Create(m);
            var dap = new DataAccess<Process>();
            UserProfile.Client = m;
            return View(dap.All().ToList());
        }

        public void AddModules(string value)
        {
            var vals = value.Split(',');
            var procs = new List<ProcessClient>();
            foreach (var i in vals)
            {
                if (i != "")
                    procs.Add(new ProcessClient() { ClientID = UserProfile.Client.ClientID, ProcessID = decimal.Parse(i) });
            }
            var da = new DataAccess<ProcessClient>();
            da.Create(procs);
        }
    }
}