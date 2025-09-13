namespace A3.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WorkFlow
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WorkFlow()
        {
            WorkFlowFields = new HashSet<WorkFlowField>();
        }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal WorkFlowID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TaskID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? InterFaceID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FormID { get; set; }

        public bool IsLast { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ProcessID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ConditionalTaskID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Priority { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ProcessStepID { get; set; }

        [Required]
        [StringLength(100)]
        public string Provider { get; set; }

        public bool isFirst { get; set; }

        public virtual Form Form { get; set; }

        public virtual InnterFace InnterFace { get; set; }

        public virtual Process Process { get; set; }

        public virtual ProcessStep ProcessStep { get; set; }

        public virtual Task Task { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkFlowField> WorkFlowFields { get; set; }
    }
}
