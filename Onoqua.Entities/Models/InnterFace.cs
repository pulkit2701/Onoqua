using System;
using System.Collections.Generic;

namespace Onoqua.Entities.Models
{
    public partial class InnterFace
    {
        public InnterFace()
        {
            this.WorkFlows = new List<WorkFlow>();
        }

        public decimal InterFaceID { get; set; }
        public string SQL { get; set; }
        public decimal ConnectionStringID { get; set; }
        public virtual ConnectionString ConnectionString { get; set; }
        public virtual ICollection<WorkFlow> WorkFlows { get; set; }
    }
}
