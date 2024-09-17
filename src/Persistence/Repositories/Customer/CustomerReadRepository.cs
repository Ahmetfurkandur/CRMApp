using Application.Common.Interfaces.Repositories.Customer;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(CrmAppDbContext context) : base(context)
        { }
    }
}
