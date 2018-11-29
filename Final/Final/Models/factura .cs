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
        public int total  { get; set; }
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
        public productos productos { get; set; }
        public int productosid { get; set; }
    }
}
