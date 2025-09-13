
using A3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace A3.Models
{
    public class FieldModel : Field
    {
        public string GroupName { get; set; }
        public decimal GroupPriority { get; set; }
        public decimal FormID { get; set; }
        public string UIClass { get; set; }
        public int FieldPriority { get; set; }
        public decimal SelectedCombo { get; set; }
        public string FieldUIClass { get; set; }
        public decimal GroupID { get; set; }

        public FieldModel(decimal groupID, string groupName, string groupUIClass)
        {
            GroupID = groupID;
            GroupName = groupName;
            UIClass = groupUIClass;
        }

        public FieldModel()
        { }



    }
}