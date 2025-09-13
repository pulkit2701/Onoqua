using System;
using System.Collections.Generic;

namespace Onoqua.Entities.Models
{
    public partial class FieldExpression
    {
        public decimal FieldExpressionID { get; set; }
        public string FieldExpression1 { get; set; }
        public decimal FieldID { get; set; }
        public virtual Field Field { get; set; }
    }
}
