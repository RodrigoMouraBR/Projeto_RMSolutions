using System.Linq;
using RM.Data.Context;
using RM.Domain.Interfaces;
using RM.Domain.Models;

namespace RM.Data.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(RMContext context) : base(context)
        {
            
        }
        public Customer GetDocument(string document)
        {
            return Search(c=>c.Document == document).FirstOrDefault();
        }
    }
}