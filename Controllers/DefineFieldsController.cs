using A3.DataAccess;
using Onoqua.Entities.Models;
using Onoqua.Extensions;
using System.Linq;
using System.Web.Mvc;

namespace Onoqua.Controllers
{
    public class DefineFieldsController : Controller
    {


        [ValidateAntiForgeryToken]
        public ActionResult DefineFields()
        {
            return View();
        }


        [ValidateAntiForgeryToken]
        public ActionResult SearchField(string searchField)
        {

            searchField.SearchFields();
            return View("DefineFields");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveField(Field f, int submit)
        {
            if (submit == -1) return View("../Configure/Index");
            var da = new DataAccess<Field>();
            da.Create(f);
            return View("DefineFields");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult GetAttachedFields(int value)
        {
            return null;
        }

        [HttpPost]
        public ActionResult GetField(int fieldID)
        {
            var results = fieldID.GetAttachedGroups();
            return View(results);
        }




    }
}