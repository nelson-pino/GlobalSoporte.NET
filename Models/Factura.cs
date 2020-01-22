using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GlobalSoporte.NET.Models
{
    public class Factura
    {
        [Key]
        public string FacturaId { get; set; }
        public DateTime FechaFactura { get; set; }
        public string CustomerId { get; set; }
        public string Subtotal { get; set; }
        public string Impuesto { get; set; }
        public string TotalFactura { get; set; }
        public List<Item_Factura> Rows { get; set; }
    }
}