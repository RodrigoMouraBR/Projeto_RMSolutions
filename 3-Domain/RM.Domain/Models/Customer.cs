using RM.Domain.Core.Entities;
using System.Collections.Generic;
namespace RM.Domain.Models
{
    public class Customer : Entity<Customer>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Address> Address { get; set; }
        public override bool IsValidated()
        {
            return true;
        }
    }
}