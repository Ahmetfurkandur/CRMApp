using Application.Common.Interfaces.Repositories.PotentialCustomer;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class PotentialCustomerReadRepository : ReadRepository<PotentialCustomer>, IPotentialCustomerReadRepository
    {
        public PotentialCustomerReadRepository(CrmAppDbContext context) : base(context)
        { }
    }
}
