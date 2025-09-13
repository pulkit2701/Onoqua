namespace A3.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProcessClient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProcessClient()
        {
            ProcessClientFields = new HashSet<ProcessClientField>();
        }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ProcessClientID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ClientID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ProcessID { get; set; }

        public virtual Client Client { get; set; }

        public virtual Process Process { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcessClientField> ProcessClientFields { get; set; }
    }
}
