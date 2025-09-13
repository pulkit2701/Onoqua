using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Onoqua.Entities.Models
{
    public partial class Process
    {
        public Process()
        {
            this.ProcessClients = new List<ProcessClient>();
            this.WorkFlows = new List<WorkFlow>();
        }

        [NotMapped]
        public bool IsSelected { get; set; }
        public decimal ProcessID { get; set; }
        public string ProcessName { get; set; }
        public string Summary { get; set; }
        public string LogoURL { get; set; }
        [NotMapped]
        public Nullable<decimal> SetupProcessID { get; set; }
        public virtual ICollection<ProcessClient> ProcessClients { get; set; }
        public virtual ICollection<WorkFlow> WorkFlows { get; set; }
    }
}
