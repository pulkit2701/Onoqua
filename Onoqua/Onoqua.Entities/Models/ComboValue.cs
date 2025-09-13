using System;
using System.Collections.Generic;

namespace Onoqua.Entities.Models
{
    public partial class ComboValue
    {
        public decimal ComboValueID { get; set; }
        public decimal FieldID { get; set; }
        public string DisplayText { get; set; }
        public string ComboValue1 { get; set; }
        public virtual Field Field { get; set; }
    }
}
