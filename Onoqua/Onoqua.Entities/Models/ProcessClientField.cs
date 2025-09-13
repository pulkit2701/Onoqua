using System;
using System.Collections.Generic;

namespace Onoqua.Entities.Models
{
    public partial class ProcessClientField
    {
        public decimal ProcessClientFieldID { get; set; }
        public decimal ProcessClientID { get; set; }
        public decimal FieldID { get; set; }
        public string FieldValue { get; set; }
        public virtual Field Field { get; set; }
        public virtual ProcessClient ProcessClient { get; set; }
    }
}
