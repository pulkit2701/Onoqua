using System;
using System.Collections.Generic;

namespace Onoqua.Entities.Models
{
    public partial class Address
    {
        public Address()
        {
            this.Entities = new List<Entity>();
        }

        public decimal AddressID { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string AddressType { get; set; }
        public virtual ICollection<Entity> Entities { get; set; }
    }
}
