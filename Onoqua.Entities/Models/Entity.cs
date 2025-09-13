using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Onoqua.Entities.Models
{
    public partial class Entity
    {
        public decimal EntityID { get; set; }
        public decimal RoleID { get; set; }
        [Display(Name = "First Name")] 
        public string FirstName { get; set; }
        [Display(Name = "Last Name")] 
        public string LastName { get; set; }
        [Display(Name = "Email ID")]
        [DataType(DataType.EmailAddress)]
        public string emailID { get; set; }
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public decimal? AddressID { get; set; }
        public decimal ClientID { get; set; }
        public virtual Address Address { get; set; }
        public virtual Client Client { get; set; }
        public virtual Role Role { get; set; }
    }
}
