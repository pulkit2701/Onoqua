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

        public decimal ProcessID { get; set; }
        public string ProcessName { get; set; }
        public string Summary { get; set; }
        public string LogoURL { get; set; }
        public virtual ICollection<ProcessClient> ProcessClients { get; set; }
        public virtual ICollection<WorkFlow> WorkFlows { get; set; }
        [NotMapped]
        public bool IsSelected { get; set; }
    }
}
