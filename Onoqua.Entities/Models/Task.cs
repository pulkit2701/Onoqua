using System;
using System.Collections.Generic;

namespace Onoqua.Entities.Models
{
    public partial class Task
    {
        public Task()
        {
            this.Messages = new List<Message>();
            this.WorkFlows = new List<WorkFlow>();
        }

        public decimal TaskID { get; set; }
        public string Expression { get; set; }
        public decimal ResultFieldID { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<WorkFlow> WorkFlows { get; set; }
    }
}
