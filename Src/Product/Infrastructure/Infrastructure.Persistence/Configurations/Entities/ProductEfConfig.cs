using Domin.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Configurations.Entities
{
    public class ProductEfConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
            builder.Property(p => p.price).IsRequired();
            builder.Property(p => p.description).HasMaxLength(200).IsRequired();
            builder.Property(p => p.CategoryName).HasMaxLength(50).IsRequired();
        }
    }
}
