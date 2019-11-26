using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MyStore.Domain.Models;

namespace MyStore.Infra.Data
{
   public class MyStoreContext:DbContext
    {
        public MyStoreContext(DbContextOptions options):base (options)
        {
            
        }
        public Product products { get; set; }

    }
}
