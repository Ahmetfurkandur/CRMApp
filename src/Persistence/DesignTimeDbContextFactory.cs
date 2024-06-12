using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
