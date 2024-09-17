using Application.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class TaskWriteRepository : WriteRepository<Domain.Entities.Task>, ITaskWriteRepository
    {
        public TaskWriteRepository(CrmAppDbContext context) : base(context)
        {
        }
    }
}
