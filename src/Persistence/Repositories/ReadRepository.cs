using Application.Repositories;
using Domain.Entities.Common;
using Persistence.Contexts;
using System.Linq.Expressions;

namespace Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        public CrmAppDbContext _context;

        public ReadRepository(CrmAppDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll(bool tracking = true)
        {
            var query = Table.AsQueryable();

            if (!tracking)
                 query = query.AsNoTracking();
            return query;
        }

        public async Task<T> GetByIdAsync(Guid id, bool tracking = true)
        {
            var query = Table.AsQueryable();

            if (!tracking)
                query = query.AsNoTracking();
            return await query
                    .FirstOrDefaultAsync(data => data.Id == id);
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> filter, bool tracking = true)
        {
            var query = Table.AsQueryable();

            if (!tracking)
                query = query.AsNoTracking();
            return await query
                    .FirstOrDefaultAsync(filter);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> filter, bool tracking = true)
        {
            var query = Table.Where(filter);

            if (!tracking)
                query = query.AsNoTracking();
            return query;
        }
    }
}
