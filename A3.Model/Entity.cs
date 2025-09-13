namespace A3.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Entity")]
    public partial class Entity
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal EntityID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal RoleID { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [StringLength(100)]
        public string emailID { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AddressID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ClientID { get; set; }

        public virtual Address Address { get; set; }

        public virtual Client Client { get; set; }

        public virtual Role Role { get; set; }
    }
}
