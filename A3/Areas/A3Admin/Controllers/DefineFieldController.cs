using A3.DataAccess;
using A3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace A3.Areas.A3Admin.Controllers
{
    public class DefineFieldController : Controller
    {
        // GET: A3Admin/DefineField
        public ActionResult Index()
        {
            if (!UserProfile.LoggedIn)
                return RedirectToAction("Index", "Home", new { area = "" });
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Search(A3.Model.Field data)
        {
            if (!UserProfile.LoggedIn)
                return RedirectToAction("Index", "Home", new { area = "" });
            return View("Index");
        }



        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Index(A3.Model.Field data)
        {
            if (!ModelState.IsValid)
                return View(data);
            var da = new DataAccess<Field>();
            da.Create(data);
            data = new Field();
            return View(data);

        }


    }
}