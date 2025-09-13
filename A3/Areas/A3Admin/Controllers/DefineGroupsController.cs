using A3.DataAccess;
using A3.Model;
using A3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace A3.Areas.A3Admin.Controllers
{
    public class DefineGroupsController : Controller
    {
        // GET: A3Admin/DefineGroups
        public ActionResult Index()
        {
            if (!UserProfile.LoggedIn)
                return RedirectToAction("Index", "Home", new { area = "" });
            return View(new Group());
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Search(A3.Model.Group data)
        {
            if (!UserProfile.LoggedIn)
                return RedirectToAction("Index", "Home", new { area = "" });
            var da = new DataAccess<Group>();
            UserProfile.Groups.Groups = da.Where(m => m.GroupName.Contains(data.GroupName)).ToList();
            return RedirectToAction("Index");
        }



        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Index(A3.Model.Group data)
        {
            if (!ModelState.IsValid)
                return View(data);
            var da = new DataAccess<A3.Model.Group>();
            if (data.GroupID != 0) da.Save(data); else da.Create(data);
            data = new A3.Model.Group();
            return View(data);

        }


        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult SelectedGroups(int GroupId)
        {
            if (!UserProfile.LoggedIn)
                return RedirectToAction("Index", "Home", new { area = "" });
            UserProfile.Groups.SelectedGroup = UserProfile.Groups.Groups.Where(m => m.GroupID == GroupId).FirstOrDefault();
            UserProfile.Groups.SelectedGroup.GroupFields = new DataAccess<GroupField>().Include(m => m.Field).Where(m => m.GroupID == GroupId).ToList();
            return View(UserProfile.Groups.SelectedGroup);

            //return View("Index", UserProfile.Groups.SelectedGroup);
        }



    }


}