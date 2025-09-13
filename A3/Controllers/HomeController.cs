using A3.DataAccess;
using A3.Model;
using A3.Models;
using System.Linq;
using System.Web.Mvc;

namespace A3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Login()
        {
            var e = new Entity();

            return View(e);
        }


        [ValidateAntiForgeryToken]
        public ActionResult ValidateUser(Entity e)
        {
            var da = new DataAccess<Entity>();
            var entity = da.Include(m => m.Client).Where(m => m.emailID == e.emailID && m.Password == e.Password).FirstOrDefault();
            if (entity == null || e.emailID.Trim()=="" || e.Password.Trim()=="")
                return RedirectToAction("login");
            UserProfile.Client = entity.Client;
            UserProfile.LoggedInUser = entity;
            UserProfile.LoggedIn = true;
            var model = new ViewModel();

            model.Processes = da.Where(m => m.Client.ClientID == entity.ClientID && entity.EntityID == m.EntityID).SelectMany(m => m.Client.ProcessClients).Select(m => m.Process).ToList();
            //return RedirectToAction("Index", "Modules", new {area= "A3Admin" });
            return RedirectToAction("Index", "Default", new { area = "Homes" });
        }



    }
}