using Persistence.Contexts;

namespace Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CrmAppDbContext>
    {
        public CrmAppDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer(Configuration.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
