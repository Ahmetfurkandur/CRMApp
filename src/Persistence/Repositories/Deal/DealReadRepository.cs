using Application.Repositories;
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
