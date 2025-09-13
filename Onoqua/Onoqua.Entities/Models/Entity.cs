using System;
using System.Collections.Generic;

namespace Onoqua.Entities.Models
{
    public partial class Entity
    {
        public decimal EntityID { get; set; }
        public decimal RoleID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string emailID { get; set; }
        public string Password { get; set; }
        public Nullable<decimal> AddressID { get; set; }
        public decimal ClientID { get; set; }
        public virtual Address Address { get; set; }
        public virtual Client Client { get; set; }
        public virtual Role Role { get; set; }
    }
}
