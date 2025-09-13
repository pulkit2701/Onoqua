using Onoqua.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Onoqua.Models
{
    public class FieldModel : Field
    {
        public string  GroupName { get; set; }
        public int GroupPriority { get; set; }
        public int FormID { get; set; }
        public string UIClass { get; set; }
        public int FieldPriority { get; set; }
        public decimal SelectedCombo { get; set; }
    }
}