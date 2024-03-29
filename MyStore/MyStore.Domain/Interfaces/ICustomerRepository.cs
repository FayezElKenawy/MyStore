﻿using MyStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> Customers();
    }
}
