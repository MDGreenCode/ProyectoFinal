using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class factura
    {
        public int id{ get; set; }
        [Required]
        public double total  { get; set; }
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
        [Required]
        public IList<productos> productos { get; set; }
        public int productoid { get; set; }
        public string nombre { get; set; }
    }
}
