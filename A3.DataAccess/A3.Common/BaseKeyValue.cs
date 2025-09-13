using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3.Common
{
    public class BaseKeyValue
    {
        public string FieldName { get; set; }
        [NotMapped]
        public string FieldValue { get; set; }
        public int FieldID { get; set; }
    }
}
