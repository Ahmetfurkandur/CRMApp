using Application.Common.Interfaces.Repositories.Deal;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class DealReadRepository : ReadRepository<Deal>, IDealReadRepository
    {
        public DealReadRepository(CrmAppDbContext context) : base(context)
        {
        }
    }
}
