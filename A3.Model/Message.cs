namespace A3.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Message
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal MessageID { get; set; }

        [Column("Message")]
        [Required]
        [StringLength(100)]
        public string Message1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TaskID { get; set; }

        public virtual Task Task { get; set; }
    }
}
