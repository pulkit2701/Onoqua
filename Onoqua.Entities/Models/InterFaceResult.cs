using System;
using System.Collections.Generic;

namespace Onoqua.Entities.Models
{
    public partial class InterFaceResult
    {
        public decimal InterFaceResultID { get; set; }
        public decimal InterFaceID { get; set; }
        public string FieldName { get; set; }
        public decimal FieldID { get; set; }
        public virtual InterFace InterFace { get; set; }
    }
}
