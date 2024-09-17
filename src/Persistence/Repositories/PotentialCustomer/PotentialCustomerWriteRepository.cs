using Application.Common.Interfaces.Repositories.PotentialCustomer;
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
