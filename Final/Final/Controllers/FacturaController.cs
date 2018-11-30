using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Final.Models;
using Final.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Rotativa.AspNetCore;

namespace Final.Controllers
{
    public class FacturaController : Controller
    {
        private FacturaServices _facturaServices;

        public FacturaController(FacturaServices facturaServices)
        {
            _facturaServices = facturaServices;
        }

        public IActionResult Index()
        {
            //pasando datos de prueba
            //INICIO
            IList<productos> productos = new List<productos>
            {
                new productos { nombre = "lapiz", cantidad = 5, precio = 100, detalle = "usado" },
                new productos {nombre = "borra", cantidad = 15, precio = 50, detalle = "nueva"}
            };
            //FIN

            double total = 0;

            foreach (productos item in productos)
            {
                total += item.precio;
            }

            factura factura = new factura
            {
                productos = productos,
                total = total,
                Fecha = DateTime.Now
            };

            _facturaServices.Crea(factura);

            return new ViewAsPdf(nameof(Index),factura);
        }
    }
}
