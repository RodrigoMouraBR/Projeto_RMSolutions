using RM.Data.Context;
using RM.Domain.Interfaces;
using RM.Domain.Models;

namespace RM.Data.Repositories
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        public AddressRepository(RMContext context) : base(context)
        {
            
        }
    }
}