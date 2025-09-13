using System;
using System.Collections.Generic;

namespace Onoqua.Entities.Models
{
    public partial class ConnectionString
    {
        public ConnectionString()
        {
            this.DBProviders = new List<DBProvider>();
        }

        public decimal ConnectionStringID { get; set; }
        public string ConnectionString1 { get; set; }
        public string DBProvider { get; set; }
        public virtual ICollection<DBProvider> DBProviders { get; set; }
    }
}
