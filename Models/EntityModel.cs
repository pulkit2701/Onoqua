using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Onoqua.Entities.Models;

namespace Onoqua.Models
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