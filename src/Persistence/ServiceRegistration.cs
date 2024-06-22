using Application.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<CrmAppDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));

            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<IContactReadRepository, ContactReadRepository>();
            services.AddScoped<IContactWriteRepository, ContactWriteRepository>();
            services.AddScoped<IPotentialCustomerReadRepository, PotentialCustomerReadRepository>();
            services.AddScoped<IPotentialCustomerWriteRepository, PotentialCustomerWriteRepository>();
            services.AddScoped<IDealReadRepository, DealReadRepository>();
            services.AddScoped<IDealWriteRepository, DealWriteRepository>();
            services.AddScoped<ITaskReadRepository, TaskReadRepository>();
            services.AddScoped<ITaskWriteRepository, ITaskWriteRepository>();
            
            
        }
    }
}
