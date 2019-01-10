using System;
using RM.Domain.Core.Entities;
namespace RM.Domain.Models
{
    public class Address : Entity<Address>
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public Guid CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public override bool IsValidated()
        {
            return true;
        }
    }
}