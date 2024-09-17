using Application.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class PotentialCustomerWriteRepository : WriteRepository<PotentialCustomer>, IPotentialCustomerWriteRepository
    {
        public PotentialCustomerWriteRepository(CrmAppDbContext context) : base(context)
        {
        }
    }
}
