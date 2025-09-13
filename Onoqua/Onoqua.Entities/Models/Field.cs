using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Onoqua.Entities.Models
{
    public partial class Field
    {
        public Field()
        {
            this.ComboValues = new List<ComboValue>();
            this.FieldExpressions = new List<FieldExpression>();
            this.GroupFields = new List<GroupField>();
            this.ProcessClientFields = new List<ProcessClientField>();
            this.WorkFlowFields = new List<WorkFlowField>();
        }

        public decimal FieldID { get; set; }
        [NotMapped]
        public int ID { get; set; }
        public string FieldType { get; set; }
        public string FieldName { get; set; }
        [NotMapped]
        public string FieldValue { get; set; }

        public virtual ICollection<ComboValue> ComboValues { get; set; }
        public virtual ICollection<FieldExpression> FieldExpressions { get; set; }
        public virtual ICollection<GroupField> GroupFields { get; set; }
        public virtual ICollection<ProcessClientField> ProcessClientFields { get; set; }
        public virtual ICollection<WorkFlowField> WorkFlowFields { get; set; }
    }
}
