using A3.Common;
using System;
using System.Collections.Generic;

namespace Onoqua.Entities.Models
{
    public partial class Field : BaseKeyValue
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
        public string FieldType { get; set; }
        public virtual List<ComboValue> ComboValues { get; set; }
        public virtual List<FieldExpression> FieldExpressions { get; set; }
        public virtual List<GroupField> GroupFields { get; set; }
        public virtual List<ProcessClientField> ProcessClientFields { get; set; }
        public virtual List<WorkFlowField> WorkFlowFields { get; set; }

        public BaseKeyValue BaseValue
        {
            get
            {
                return this;
            }
        }
    }
}
