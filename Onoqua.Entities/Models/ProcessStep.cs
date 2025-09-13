using System;
using System.Collections.Generic;

namespace Onoqua.Entities.Models
{
    public partial class ProcessStep
    {
        public ProcessStep()
        {
            this.WorkFlows = new List<WorkFlow>();
        }

        public decimal ProcessStepID { get; set; }
        public string ProcessStepName { get; set; }
        public bool IsSetup { get; set; }
        public virtual ICollection<WorkFlow> WorkFlows { get; set; }
    }
}
