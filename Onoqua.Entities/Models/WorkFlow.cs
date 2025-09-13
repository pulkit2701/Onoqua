using System;
using System.Collections.Generic;

namespace Onoqua.Entities.Models
{
    public partial class WorkFlow
    {
        public WorkFlow()
        {
            this.WorkFlowFields = new List<WorkFlowField>();
        }

        public decimal WorkFlowID { get; set; }
        public Nullable<decimal> TaskID { get; set; }
        public Nullable<decimal> InterFaceID { get; set; }
        public decimal FormID { get; set; }
        public bool IsLast { get; set; }
        public decimal ProcessID { get; set; }
        public Nullable<decimal> ConditionalTaskID { get; set; }
        public decimal Priority { get; set; }
        public decimal ProcessStepID { get; set; }
        public virtual Form Form { get; set; }
        public virtual InnterFace InnterFace { get; set; }
        public virtual Process Process { get; set; }
        public virtual ProcessStep ProcessStep { get; set; }
        public virtual Task Task { get; set; }
        public virtual ICollection<WorkFlowField> WorkFlowFields { get; set; }
    }
}
