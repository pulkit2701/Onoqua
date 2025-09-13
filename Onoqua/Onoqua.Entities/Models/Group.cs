using System;
using System.Collections.Generic;

namespace Onoqua.Entities.Models
{
    public partial class Group
    {
        public Group()
        {
            this.FormGroups = new List<FormGroup>();
            this.GroupFields = new List<GroupField>();
        }

        public decimal GroupID { get; set; }
        public string GroupName { get; set; }
        public virtual List<FormGroup> FormGroups { get; set; }
        public virtual List<GroupField> GroupFields { get; set; }
    }
}
