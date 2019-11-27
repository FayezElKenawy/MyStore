using MyStore.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Application.Interfaces
{
    public interface IProductService
    {
        IEnumerable<ProductViewModel> GetProducts();
    }
}
