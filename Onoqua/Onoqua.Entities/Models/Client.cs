using System;
using System.Collections.Generic;

namespace Onoqua.Entities.Models
{
    public partial class Client
    {
        public Client()
        {
            this.Entities = new List<Entity>();
            this.ProcessClients = new List<ProcessClient>();
        }

        public decimal ClientID { get; set; }
        public string Name { get; set; }
        public virtual List<Entity> Entities { get; set; }
        public virtual List<ProcessClient> ProcessClients { get; set; }
    }
}
