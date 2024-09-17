using Application.Common.Interfaces.Repositories.Customer;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(CrmAppDbContext context) : base(context)
        { }
    }
}
