using RM.Domain.Core.Entities;
namespace RM.Domain.Models
{
    public class Customer : Entity<Customer>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public override bool IsValidated()
        {
            return true;
        }
    }
}