using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final.Models;
using Final.Data;
namespace Final.Services
{
    public class ServiceFactura : FacturaServices

        
    {
        private readonly ApplicationDbContext _context;
        public ServiceFactura(ApplicationDbContext ctx)
        {
           _context = ctx;
    }           
        public Task<factura> actualizar(factura factura)
        {
            throw new NotImplementedException();
        }

        public Task<factura> Crea(factura factura)
        {
            throw new NotImplementedException();
        }

        public Task<factura> Eliminar(factura factura)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<factura>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<factura> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
