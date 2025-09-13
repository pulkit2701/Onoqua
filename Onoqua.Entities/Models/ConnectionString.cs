using System;
using System.Collections.Generic;

namespace Onoqua.Entities.Models
{
    public partial class ConnectionString
    {
        public ConnectionString()
        {
            this.InnterFaces = new List<InnterFace>();
        }

        public decimal ConnectionStringID { get; set; }
        public string ConnectionString1 { get; set; }
        public virtual ICollection<InnterFace> InnterFaces { get; set; }
    }
}
