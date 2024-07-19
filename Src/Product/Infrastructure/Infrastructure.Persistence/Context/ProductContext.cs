using Domin.Entites;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Context
{
    public class ProductContext:DbContext
    {
        internal readonly Task<object> AsEnumrable;

        public DbSet<Product> Product { get; set; }


    }
}
