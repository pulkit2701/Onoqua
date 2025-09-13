namespace A3.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FormGroup
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal FormGroupID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FormID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal GroupID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Priority { get; set; }

        [Required]
        [StringLength(100)]
        public string UIClass { get; set; }

        public bool IsVertical { get; set; }

        public virtual Form Form { get; set; }

        public virtual Group Group { get; set; }
    }
}
