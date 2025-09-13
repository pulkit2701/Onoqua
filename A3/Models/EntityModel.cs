
using A3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace A3.Models
{
    public class EntityModel
    {
        public Entity Entity { get; set; }
        public List<Entity> ExistingUsers { get; set; }

        public EntityModel()
        {
            ExistingUsers = new List<Entity>();
        }

    }
}