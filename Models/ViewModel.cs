using Onoqua.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Onoqua.Models
{
    public class ViewModel
    {

        decimal _currentFormId = 0;
        public List<FieldModel> Fields { get; set; }
        public List<Process> Processes { get; set; }
        public List<WorkFlow> Workflows { get; set; }
        public List<FormModel> Forms { get; set; }
        public decimal? FirstFormID { get; set; }
        public decimal? LastFormID { get; set; }
        public ProcessModel ProcessModel { get; set; }

        public FormModel CurrentForm { get; set; }
        //public int ctr { get; set; }



        public decimal CurrentFormId
        {
            get
            {
                return _currentFormId;
            }
            set
            {
                _currentFormId = value;
                //CurrentForm = Forms.Where(m => m.FormID == _currentFormId).FirstOrDefault();
            }
        }

        public ViewModel()
        {
            Forms = new List<FormModel>();
            Processes = new List<Process>();
            Fields = new List<FieldModel>();
            CurrentForm = new FormModel();
        }

        public List<FieldModel> Groups
        {
            get
            {
                var f = new FieldModelEqualityComparer();
                var result = Fields.Where(m => m.FormID == CurrentFormId).OrderBy(m => m.GroupPriority).Select(m => new FieldModel(m.GroupID, m.GroupName, m.UIClass)).Distinct(f).ToList();
                return result;
            }
        }

    }

    class FieldModelEqualityComparer : IEqualityComparer<FieldModel>
    {

        public bool Equals(FieldModel x, FieldModel y)
        {
            if (x.GroupID == y.GroupID && x.GroupName == y.GroupName && x.UIClass == y.UIClass)
                return true;
            else
                return false;
        }

        public int GetHashCode(FieldModel obj)
        {
            var i = obj.GroupID.ToString() + "  " + obj.GroupName + "  " + obj.UIClass;

            return i.GetHashCode();
        }
    }
}