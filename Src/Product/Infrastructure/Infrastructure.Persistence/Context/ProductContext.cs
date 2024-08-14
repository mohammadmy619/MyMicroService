using Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Context
{
    public class ProductContext:DbContext
    {

        public ProductContext()
        {
            
        }
        public ProductContext(DbContextOptions<ProductContext> dbContextOptions)
        : base(dbContextOptions)
        {

        }

       

        internal readonly Task<object> AsEnumrable;

        public DbSet<Product> Product { get; set; }


    }
}
