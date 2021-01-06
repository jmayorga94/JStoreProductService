using JStore.ProductService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JStore.ProductService.Context.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Image).IsRequired(false);
            builder.Property(p => p.Price).HasColumnType("Decimal");
            builder.Property(p => p.Description).HasMaxLength(200);
            builder.Property(p => p.Name).HasMaxLength(50);
        }
    }
}
