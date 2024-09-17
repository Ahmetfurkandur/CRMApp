using Application.Common.Interfaces.Repositories.Contact;
using Application.Common.Interfaces.Repositories.Customer;
using Application.Common.Interfaces.Repositories.Deal;
using Application.Common.Interfaces.Repositories.PotentialCustomer;
using Application.Common.Interfaces.Repositories.Task;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;
using Persistence.Repositories;

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
            services.AddScoped<ITaskWriteRepository, TaskWriteRepository>();
            
            
        }
    }
}
