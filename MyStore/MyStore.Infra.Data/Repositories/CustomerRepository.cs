using MyStore.Domain.Interfaces;
using MyStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Infra.Data.Repositories
{
   public class CustomerRepository : ICustomerRepository
    {
        private MyStoreContext _context;
        public CustomerRepository(MyStoreContext context)
        {
            _context = context;
        }
        public IEnumerable<Customer> Customers()
        {
            return _context.Customers;
        }
    }
}
