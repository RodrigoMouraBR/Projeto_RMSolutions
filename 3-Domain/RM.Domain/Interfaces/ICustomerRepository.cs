using RM.Domain.Models;
namespace RM.Domain.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer>
    {
         Customer GetDocument(string document);
    }
}