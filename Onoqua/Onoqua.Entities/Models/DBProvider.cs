using System;
using System.Collections.Generic;

namespace Onoqua.Entities.Models
{
    public partial class DBProvider
    {
        public decimal DBProviderID { get; set; }
        public string SQL { get; set; }
        public decimal ConnectionStringID { get; set; }
        public virtual ConnectionString ConnectionString { get; set; }
    }
}
