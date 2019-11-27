using MyStore.Domain.Interfaces;
using MyStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Infra.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private MyStoreContext _context;
        public ProductRepository(MyStoreContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> GetProducts()
        {
            return _context.Products;
        }
    }
}
