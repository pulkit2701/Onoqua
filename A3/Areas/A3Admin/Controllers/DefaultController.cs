using A3.DataAccess;
using A3.Model;
using System.Web.Mvc;

namespace A3.Areas.A3Admin.Controllers
{
    public class DefaultController : Controller
    {
        // GET: A3Admin/Default
        public ActionResult Index()
        {
            if (!UserProfile.LoggedIn)
                return RedirectToAction("Index", "Home", new { area = "" });
            return View(ResetObject());
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Index(Client m, Entity e, Address a)
        {
            e.Address = a;
            e.RoleID = 1;
            e.Role = new Role() { RoleID = 1, Description = "Owner", RoleType = "Owner" };
            m.Entities.Add(e);
            if (ModelState.IsValid)
            {
                var da = new DataAccess<Client>();
                m = da.Create(m);
                UserProfile.Client = m;
                return RedirectToAction("Index", "Setup");
            }
            

            return View(m);

        }

        private Client ResetObject()
        {
            var m = new Client();
            m.Name = "";
            var e = new Entity();
            e.Address = new Address();
            m.Entities.Add(e);
            return m;
        }

    }
}