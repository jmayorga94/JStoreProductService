using JStore.ProductService.Context.Configurations;
using JStore.ProductService.Models;
using Microsoft.EntityFrameworkCore;

namespace JStore.ProductService.Context
{
    public class ProductServiceDbContext : DbContext
    {
        public ProductServiceDbContext(DbContextOptions options) :base(options)
        {

        }
       
       public DbSet<Product> Products { get; set; }
       public DbSet<Category> Categories { get; set; }

       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        }
    }
}
