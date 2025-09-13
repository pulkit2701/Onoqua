using System;
using System.Collections.Generic;

namespace Onoqua.Entities.Models
{
    public partial class GroupField
    {
        public decimal GroupFieldID { get; set; }
        public decimal GroupID { get; set; }
        public decimal FieldID { get; set; }
        public int Priority { get; set; }
        public string UIClass { get; set; }
        public virtual Field Field { get; set; }
        public virtual Group Group { get; set; }
    }
}
