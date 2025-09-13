using A3.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Onoqua.Controllers
{
    public class ConfigureController : Controller
    {
        // GET: Configure
        public ActionResult Index()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        public ActionResult ShowView(decimal? ConfigureType)
        {
            switch (ConfigureType)
            {
                case 1:
                    {
                        LoadProcesses();
                        return View("DefineProcess");
                    }
                case 2:
                    {
                        if (UserProfile.FieldTypes.Count() == 0) LoadFieldType();
                        return View("../DefineFields/DefineFields");
                    }
                case 3:
                    {
                        return View("../DefineGroup/Index");
                    }
                case 4:
                    {
                        return RedirectToAction("Index", "DefineQuery");
                    }
            }
            return null;
        }

        public void LoadFieldType()
        {
            UserProfile.FieldTypes.Add("CheckBox");
            UserProfile.FieldTypes.Add("Label");
            UserProfile.FieldTypes.Add("Text");
            UserProfile.FieldTypes.Add("Number");
            UserProfile.FieldTypes.Add("Date");


        }

        private void LoadProcesses()
        {
            UserProfile.ProcessModel.Processes.Clear();
            var da = new DataAccess<Onoqua.Entities.Models.Process>();
            da.All().ToList().ForEach(m => UserProfile.ProcessModel.Processes.Add(new KeyValuePair<decimal, string>(m.ProcessID, m.ProcessName)));
        }

        [ValidateAntiForgeryToken]
        public ActionResult SaveProcess(int submit, Onoqua.Entities.Models.Process p)
        {
            if (submit == -1) return View("Index");
            var da = new DataAccess<Onoqua.Entities.Models.Process>();
            if (p.ProcessID == 0)
                da.Create(p);
            else
                da.Update(p);
            return View("DefineProcess");
        }

        [ValidateAntiForgeryToken]
        public ActionResult SelectProcess(int ProcessKey)
        {
            var da = new DataAccess<Onoqua.Entities.Models.Process>();
            var data = da.Where(m => m.ProcessID == ProcessKey).FirstOrDefault();
            return View("DefineProcess", data);
        }
    }

}