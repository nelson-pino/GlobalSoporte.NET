using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GlobalSoporte.NET.Models
{
    public class Products
    {
        [Key]
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public string ProductCategory { get; set; }
        public string ProductEx { get; set; }
    }
}