using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class Proveedor
    {
        public int id { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public string Detalle { get; set; }
    }
}
