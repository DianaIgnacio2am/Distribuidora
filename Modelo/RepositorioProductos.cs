using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{ // creo que lo voy a hacer como un desvio para que si cargas un producto percedero vaya para alla
  // y si es nopercedero vaya para otro lado. pero centralizado acá como una posibilidad.
    public class RepositorioProductos
    {
        private Context _context;
        public RepositorioProductos(Context context)
        {
            _context = context;
        }

        public ReadOnlyCollection<Producto> Listar()
        {
            List<Producto> prod = new();
            prod.AddRange(_context.ProductoNoPercederos
                .AsNoTracking()
                .Include(x => x.categorias)
                .Include(x => x.proveedores)
                .ToList());
            prod.AddRange(_context.ProductoPercederos
                .AsNoTracking()
                .Include(x => x.categorias)
                .Include(x => x.proveedores)
                .ToList());
            return prod.AsReadOnly();

        }
    }
}
