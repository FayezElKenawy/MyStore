using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyStore.Application.Interfaces;
using MyStore.Application.ViewModel;

namespace Mystore.MVC.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerService _service;
        public CustomerController(ICustomerService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            CustomerViewModel model = _service.GetCustomers();
            return View(model);
        }
    }
}