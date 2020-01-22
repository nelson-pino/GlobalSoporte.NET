using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GlobalSoporte.NET.Models
{
    public class Customers
    {
        [Key]
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerDirec { get; set; }
        public string CustomerRif { get; set; }
        public string CustomerType { get; set; }
    }
}