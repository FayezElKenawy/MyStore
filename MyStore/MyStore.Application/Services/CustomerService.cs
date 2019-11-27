using MyStore.Application.Interfaces;
using MyStore.Application.ViewModel;
using MyStore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository _ICustomerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _ICustomerRepository = customerRepository;
        }
        public CustomerViewModel GetCustomers()
        {
            return new CustomerViewModel()
            {
                Customers = _ICustomerRepository.Customers()
            };
        }
    }
}
