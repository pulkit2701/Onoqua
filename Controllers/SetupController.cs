using A3.DataAccess;
using Onoqua.Entities.Models;
using System.Web.Mvc;

namespace Onoqua.Controllers
{
    public class SetupController : Controller
    {
        // GET: Setup
        //[ValidateAntiForgeryToken]
        public ActionResult Index(decimal processID)
        {
            //if (processID == 0)
            //{
            //    var m = new EntityModel();
            //    var e = new Entity();
            //    e.ClientID = UserProfile.Client.ClientID;
            //    m.Entity = e;
            //    m.ExistingUsers = Services.UserService.GetUsers(UserProfile.Client.ClientID);
            //    return View("addusers", m);
            //}
            //var da = new DataAccess<WorkFlow>();
            //var stepid = da.Where(m => m.ProcessID == processID).FirstOrDefault();
            //ViewModel model = new ViewModel();
            //var p = new Processor();
            //var a = p.Execute(processID, 0,  model);
            //return View(model);
            return null;
        }


        [ValidateAntiForgeryToken]
        public void AddUser(Entity e)
        {
            var da = new DataAccess<Entity>();
            if (e.EntityID == 0)
            {
                e.ClientID = UserProfile.Client.ClientID;
                e.RoleID = 2;
                da.Create(e);
            }
            else
                da.Update(e);
            Response.Redirect("Index?processID=0");
        }
    }
}