using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final.Models;
using Final.Data;

namespace Final.Services
{
    public class SeviceProductos : productoServices
    {
        private readonly ApplicationDbContext _contex;
        public SeviceProductos (ApplicationDbContext tx)
        {
            _contex = tx;
        }
        public Task<productos> actualizar(productos vehiculo)
        {
            throw new NotImplementedException();
        }

        public Task<productos> Crea(productos vehiculo)
        {
            throw new NotImplementedException();
        }

        public Task<productos> Eliminar(productos vehiculo)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<productos>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<productos> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
