using A3.DataAccess;
using Onoqua.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            var da = new DataAccess<Form>();
            var c = da.All().ToList();
            return View(c);
        }

        public ActionResult Show(decimal formID)
        {
            var da = new DataAccess<FormGroup>();
            UserProfile.Form = da.Where(m => m.FormID == formID).FirstOrDefault().Form;
            UserProfile.Form.FormGroups = da.Include("Group").Where(m => m.FormID == formID).ToList();
            return View(UserProfile.Form.FormGroups);

        }
    }
}