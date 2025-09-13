using System;
using System.Collections.Generic;

namespace Onoqua.Entities.Models
{
    public partial class Message
    {
        public decimal MessageID { get; set; }
        public string Message1 { get; set; }
        public decimal TaskID { get; set; }
        public virtual Task Task { get; set; }
    }
}
