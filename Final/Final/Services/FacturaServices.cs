using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final.Models;
namespace Final.Services
{
    public interface FacturaServices
    {
        Task<factura> Crea(factura factura);
        Task<IEnumerable<factura>> GetAll();
        Task<factura> GetById(int id);
        Task<factura> Eliminar(factura factura);
        Task<factura> actualizar(factura factura);
    }
}
