using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3.Common
{
    public class FieldValue
    {
        public string Field;
        public object Value;

        public FieldValue()
        { }

        public FieldValue(string field, object value)
        {
            Field = field;
            Value = value;
        }
    }
}
