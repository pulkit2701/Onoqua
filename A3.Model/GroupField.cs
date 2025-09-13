namespace A3.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GroupField
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal GroupFieldID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal GroupID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FieldID { get; set; }

        public int Priority { get; set; }

        [Required]
        [StringLength(20)]
        public string UIClass { get; set; }

        public virtual Field Field { get; set; }

        public virtual Group Group { get; set; }
    }
}
