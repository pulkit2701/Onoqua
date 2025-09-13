using A3.Model;
using System.Collections.Generic;

namespace A3.Models
{
    public class ProcessModel : Process
    {
        public List<KeyValuePair<decimal, string>> Processes { get; set; }

        public ProcessModel()
        {
            Processes = new List<KeyValuePair<decimal, string>>();
        }
    }
}