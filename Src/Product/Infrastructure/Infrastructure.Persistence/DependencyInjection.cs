using Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Domain.contracts;
using Domain.Entites;

namespace Infrastructure.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<ProductContext>(options =>
            {
                options.UseNpgsql(configuration
                    .GetConnectionString("ApplicationDbContext"));
            });

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IProductRepository, ProductRepository>();



            return services;
        }
    }
}
