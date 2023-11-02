using Domin.Entites;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Context
{
    public class ProductContext:DbContext
    {


        public DbSet<Product> Product { get; set; }


    }
}
