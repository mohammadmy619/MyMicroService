using Application.Persistence.Contracts;
using Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<ProductContext>(options =>
            {
                options.UseSqlServer(configuration
                    .GetConnectionString("ApplicationDbContext"));
            });

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

          

            return services;
        }
    }
}
