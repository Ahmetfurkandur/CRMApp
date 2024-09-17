using Application.Common.Interfaces.Repositories.Deal;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class DealWriteRepository : WriteRepository<Deal>, IDealWriteRepository
    {
        public DealWriteRepository(CrmAppDbContext context) : base(context)
        {
        }
    }
}
