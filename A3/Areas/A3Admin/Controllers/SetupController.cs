using A3.DataAccess;
using A3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace A3.Areas.A3Admin.Controllers
{
    public class SetupController : Controller
    {
        // GET: A3Admin/Setup
        public ActionResult Index()
        {
            if (!UserProfile.LoggedIn)
                return RedirectToAction("Index", "Home", new { area = "" });
            if (UserProfile.FieldTypes.Count() == 0) LoadFieldType();
            return View();
        }

        public void LoadFieldType()
        {
            UserProfile.FieldTypes.Add("CheckBox");
            UserProfile.FieldTypes.Add("Label");
            UserProfile.FieldTypes.Add("Text");
            UserProfile.FieldTypes.Add("Number");
            UserProfile.FieldTypes.Add("Date");


        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Index(string value)
        {

            if (value == "2")
                return RedirectToAction("Index", "Modules");
            if (value == "1")
                return View();
            return View(value);

        }



    }
}