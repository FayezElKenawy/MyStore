using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyStore.Application.Interfaces;
using MyStore.Application.ViewModel;

namespace Mystore.MVC.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            ProductViewModel model = _productService.GetProducts();
            return View(model);
        }
    }
}