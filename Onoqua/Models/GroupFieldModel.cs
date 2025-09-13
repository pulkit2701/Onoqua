using Onoqua.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Onoqua.Models
{
    public class GroupFieldModel
    {
        public List<Field> Fields { get; set; }
        public Group Group { get; set; }

    }
}