using Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Services
{
    public interface IProveedoresData
    {
        IEnumerable<Proveedor> GetAll();
        Proveedor Get(int id);
        Proveedor Add(Proveedor proveedor);
        Proveedor Update(Proveedor proveedor);
        void Delete(Proveedor proveedor);
    }
}
