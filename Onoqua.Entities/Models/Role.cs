using System;
using System.Collections.Generic;

namespace Onoqua.Entities.Models
{
    public partial class Role
    {
        public Role()
        {
            this.Entities = new List<Entity>();
        }

        public decimal RoleID { get; set; }
        public string RoleType { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Entity> Entities { get; set; }
    }
}
