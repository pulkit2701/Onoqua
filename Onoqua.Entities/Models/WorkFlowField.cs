using System;
using System.Collections.Generic;

namespace Onoqua.Entities.Models
{
    public partial class WorkFlowField
    {
        public decimal WorkFlowFieldID { get; set; }
        public decimal WorkFlowID { get; set; }
        public decimal FieldID { get; set; }
        public decimal QueryFilterID { get; set; }
        public virtual Field Field { get; set; }
        public virtual QueryFilter QueryFilter { get; set; }
        public virtual WorkFlow WorkFlow { get; set; }
    }
}
