using System;
using System.Collections.Generic;

namespace Onoqua.Entities.Models
{
    public partial class FormGroup
    {
        public decimal FormGroupID { get; set; }
        public decimal FormID { get; set; }
        public decimal GroupID { get; set; }
        public decimal Priority { get; set; }
        public string UIClass { get; set; }
        public bool IsVertical { get; set; }
        public virtual Form Form { get; set; }
        public virtual Group Group { get; set; }
    }
}
