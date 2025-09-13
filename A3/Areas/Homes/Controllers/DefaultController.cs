using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace A3.Areas.Homes.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Homes/Default
        public ActionResult Index()
        {
            return View();
        }
    }
}