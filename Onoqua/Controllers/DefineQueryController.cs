using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Onoqua.Controllers
{
    public class DefineQueryController : Controller
    {
        // GET: DefineQuery
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult SearchQuery(string query)
        {
            return null;
        }
    }
}