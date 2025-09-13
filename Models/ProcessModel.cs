using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Onoqua.Models
{
    public class ProcessModel : Onoqua.Entities.Models.Process
    {
        public List<KeyValuePair<decimal, string>> Processes { get; set; }

        public ProcessModel()
        {
            Processes = new List<KeyValuePair<decimal, string>>();
        }
    }
}