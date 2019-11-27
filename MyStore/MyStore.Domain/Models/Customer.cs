using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Domain.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
