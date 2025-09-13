using System;
using System.Collections.Generic;

namespace Onoqua.Entities.Models
{
    public partial class InterFace
    {
        public InterFace()
        {
            this.InterFaceResults = new List<InterFaceResult>();
            this.WorkFlows = new List<WorkFlow>();
        }

        public decimal InterFaceID { get; set; }
        public decimal ProviderID { get; set; }
        public string ProviderType { get; set; }
        public virtual ICollection<InterFaceResult> InterFaceResults { get; set; }
        public virtual ICollection<WorkFlow> WorkFlows { get; set; }
    }
}
