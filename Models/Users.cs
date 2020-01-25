using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GlobalSoporte.NET.Models
{
    public class Users
    {
        [Key]
        public string UserId { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string Departamento { get; set; }
        public string MapId { get; set; }
        public string Role { get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }
    }
}