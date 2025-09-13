using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Onoqua.Entities.Models
{
    public partial class ProcessClient
    {
        public ProcessClient()
        {
            this.ProcessClientFields = new List<ProcessClientField>();
        }

        public decimal ProcessClientID { get; set; }
        public decimal ClientID { get; set; }
        public decimal ProcessID { get; set; }
        public virtual Client Client { get; set; }
        public virtual Process Process { get; set; }
        public virtual ICollection<ProcessClientField> ProcessClientFields { get; set; }

    }
}
