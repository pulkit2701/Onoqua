using System;
using System.Collections.Generic;

namespace Onoqua.Entities.Models
{
    public partial class QueryFilter
    {
        public QueryFilter()
        {
            this.WorkFlowFields = new List<WorkFlowField>();
        }

        public decimal QueryFilterID { get; set; }
        public string QueryFilter1 { get; set; }
        public virtual ICollection<WorkFlowField> WorkFlowFields { get; set; }
    }
}
