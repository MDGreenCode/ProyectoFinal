using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final.Data;
using Final.Models;
using Microsoft.EntityFrameworkCore;

namespace Final.Services
{
    public class SqlProveedoresData : IProveedoresData
    {
        private ApplicationDbContext _context;

        public SqlProveedoresData(ApplicationDbContext context)
        {
            _context = context;
        }

        public Proveedor Add(Proveedor proveedor)
        {
            _context.proveedores.Add(proveedor);
            _context.SaveChanges();
            return proveedor;
        }

        public void Delete(Proveedor proveedor)
        {
            _context.Attach(proveedor).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public Proveedor Get(int id)
        {
            return _context.proveedores.FirstOrDefault(r => r.id == id);
        }

        public IEnumerable<Proveedor> GetAll()
        {
            return _context.proveedores.OrderBy(r => r.nombre);
        }

        public Proveedor Update(Proveedor proveedor)
        {
            _context.Attach(proveedor).State = EntityState.Modified;
            _context.SaveChanges();
            return proveedor;
        }
    }
}
