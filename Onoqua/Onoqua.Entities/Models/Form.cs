using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Onoqua.Entities.Models
{
    public partial class Form
    {
        public Form()
        {
            this.FormGroups = new List<FormGroup>();
            this.WorkFlows = new List<WorkFlow>();
            
        }



        public decimal FormID { get; set; }
        public string FormTitle { get; set; }
        public virtual List<FormGroup> FormGroups { get; set; }
        public virtual List<WorkFlow> WorkFlows { get; set; }
    }
}
