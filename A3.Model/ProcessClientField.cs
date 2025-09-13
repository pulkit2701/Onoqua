namespace A3.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProcessClientField
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ProcessClientFieldID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ProcessClientID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FieldID { get; set; }

        [StringLength(200)]
        public string FieldValue { get; set; }

        public virtual Field Field { get; set; }

        public virtual ProcessClient ProcessClient { get; set; }
    }
}
