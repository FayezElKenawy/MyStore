using Microsoft.Extensions.DependencyInjection;
using MyStore.Application.Interfaces;
using MyStore.Application.Services;
using MyStore.Domain.Interfaces;
using MyStore.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Infra.Ioc
{
    public class DepenencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application services
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICustomerService, CustomerService>();
            
            //Data Services
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
        }
    }
}
