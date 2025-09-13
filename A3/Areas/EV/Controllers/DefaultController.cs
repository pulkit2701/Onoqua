using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace A3.Areas.EV.Controllers
{
    public class DefaultController : Controller
    {
        // GET: EV/Default
        public ActionResult Index()
        {
            return View();
        }
    }
}