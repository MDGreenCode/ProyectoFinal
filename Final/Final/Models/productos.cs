using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class productos
    {
        public int id { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public string detalle { get; set; }
        [Required]
        public int cantidad  { get; set; }
        [Required]
        public int precios  { get; set; }
    }
}
