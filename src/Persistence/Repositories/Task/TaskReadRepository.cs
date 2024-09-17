using Application.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class TaskReadRepository : ReadRepository<Domain.Entities.Task>, ITaskReadRepository
    {
        public TaskReadRepository(CrmAppDbContext context) : base(context)
        {
        }
    }
}
