﻿using MyStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Application.ViewModel
{
    public class ProductViewModel
    {
        public IEnumerable<Product> Products { get; set; }
    }
}
