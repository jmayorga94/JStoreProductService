using JStore.ProductService.Context;
using JStore.ProductService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JStore.ProductService.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductServiceDbContext _context;

        public ProductRepository(ProductServiceDbContext context)
        {
            _context = context;
        }

        public void Add(Product product)
        {
            _context.Add(product);
            _context.SaveChanges();
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.Include(c => c.Category).ToList();
        }

        public Product GetBy(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
