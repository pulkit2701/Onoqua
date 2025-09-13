namespace A3.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ComboValue
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ComboValueID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FieldID { get; set; }

        [Required]
        [StringLength(50)]
        public string DisplayText { get; set; }

        [Column("ComboValue")]
        [Required]
        [StringLength(10)]
        public string ComboValue1 { get; set; }

        public virtual Field Field { get; set; }
    }
}
