using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GlobalSoporte.NET.Models
{
    public class Item_Factura
    {

        [Key]
        public string ProductId { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Price { get; set; }
        public decimal subtotal_siniva { get; set; }
        public decimal impuesto { get; set; }
        public decimal totalrow { get; set; }
    }
}