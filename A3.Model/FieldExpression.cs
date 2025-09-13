namespace A3.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FieldExpression
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal FieldExpressionID { get; set; }

        [Column("FieldExpression")]
        [Required]
        [StringLength(100)]
        public string FieldExpression1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FieldID { get; set; }

        public virtual Field Field { get; set; }
    }
}
