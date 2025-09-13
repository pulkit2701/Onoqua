namespace A3.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WorkFlowField
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal WorkFlowFieldID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal WorkFlowID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal FieldID { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "numeric")]
        public decimal QueryFilterID { get; set; }

        public virtual Field Field { get; set; }

        public virtual QueryFilter QueryFilter { get; set; }

        public virtual WorkFlow WorkFlow { get; set; }
    }
}
