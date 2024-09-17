using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(ServiceRegistration).Assembly));
            services.AddAutoMapper(typeof(ServiceRegistration).Assembly);
        }
    }
}
