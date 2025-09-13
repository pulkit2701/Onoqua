using A3.Common;
using A3.DataAccess;
using Onoqua.Entities.Models;
using Onoqua.Extensions;
using Onoqua.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Onoqua.Controllers
{
    public class DefineGroupController : Controller
    {
        // GET: DefineGroup
        [ValidateAntiForgeryToken]
        public ActionResult Index()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        public ActionResult SearchGroup(string searchGroup)
        {
            var da = new DataAccess<Group>();
            UserProfile.Groups.Groups = da.Where(m => m.GroupName.Contains(searchGroup)).ToList();
            return View("Index");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveGroup(Group f, int submit)
        {
            if (submit == -1) return View("../Configure/Index");
            var da = new DataAccess<Group>();
            da.Create(f);
            return View("Index", new Group());
        }

        [ValidateAntiForgeryToken]
        public ActionResult Manage(int submit)
        {
            switch (submit)
            {
                case 1:
                    {
                        return View("GroupFields");
                    }
            }
            return null;
        }


        [ValidateAntiForgeryToken]
        public ActionResult SearchGroupField(string searchGroup)
        {
            searchGroup.SearchGroup();
            return View("GroupFields");
        }

        [ValidateAntiForgeryToken]
        public ActionResult SelectedFieldForGroup(string searchField)
        {
            searchField.SearchFields();
            return View("GroupFields");
        }

        [ValidateAntiForgeryToken]
        public ActionResult SelectedGroup(int GroupId)
        {
            UserProfile.Groups.SelectedGroup = UserProfile.Groups.Groups.Where(m => m.GroupID == GroupId).FirstOrDefault();
            GroupModel gModel = new GroupModel();
            gModel.SelectedGroup = GroupId.GetGroup();
            gModel.Fields = GroupId.GetFields();
            return View(gModel);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult AddFieldToGroup(int fieldId, string fieldname)
        //{
        //    var da = new DataAccess<GroupField>();
        //    var groupField = new GroupField() { FieldID = fieldId, GroupID = UserProfile.Groups.SelectedGroup.GroupID };
        //    da.Create(groupField);
        //    UserProfile.Fields.Remove(UserProfile.Fields.Where(m => m.FieldID == fieldId).FirstOrDefault());
        //    return View(UserProfile.Groups.SelectedGroup.GroupID.GetFieldsByGroup());
        //}



        [ValidateAntiForgeryToken]
        public ActionResult AddFieldToGroup(List<GroupField> fieldIds, int groupId)
        {
            //   return null;
            //fieldIds = fieldIds.Substring(1);
            var da = new DataAccess<GroupField>();
            //List<GroupField> gf = new List<GroupField>();
            //fieldIds.Split(',').ToList().ForEach(m =>
            //{
            //    gf.Add(new GroupField() { FieldID = int.Parse(m), GroupID = groupId });
            //});
            da.Create(fieldIds);
            return SelectedGroup(groupId);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SearchField(string fieldName, int groupID)
        {
            var m = new GroupModel();
            m.SelectedGroup.GroupID = groupID;
            m.Fields = fieldName.SearchFields(groupID);
            return View(m);
        }

       
        public ActionResult Showfield(int groupID, string groupName)
        {
            var m = new ViewModel();
            m.Fields = new List<FieldModel>();
            groupID.GetGroupFields().ForEach(n =>
            {
                m.Fields.Add(new FieldModel() { FieldID = n.FieldID, FieldName = n.Field.FieldName, FieldPriority = n.Priority, FieldType = n.Field.FieldType, FieldUIClass = n.UIClass, GroupName = groupName });
            });

            return View("shared/_fieldPresenter", m);

        }


    }
}