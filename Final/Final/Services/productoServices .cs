using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final.Models;

namespace Final.Services
{
    public interface productoServices
    {
        Task<productos> Crea(productos vehiculo);
        Task<IEnumerable<productos>> GetAll();
        Task<productos> GetById(int id);
        Task<productos> Eliminar(productos vehiculo);
        Task<productos> actualizar(productos vehiculo);
    }
}
