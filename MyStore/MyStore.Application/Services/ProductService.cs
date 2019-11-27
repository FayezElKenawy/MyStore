using MyStore.Application.Interfaces;
using MyStore.Application.ViewModel;
using MyStore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Application.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }   
        public ProductViewModel GetProducts()
        {
            return new ProductViewModel()
            {
                Products = _productRepository.GetProducts()
            };
        }
    }
}
