using System.Collections.ObjectModel;
using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public sealed class RepositorioOrdenDeCompra : Repositorio<OrdenDeCompra>
    {
        public RepositorioOrdenDeCompra(Context context)
        {
            this.context = context;
        }

        public override List<OrdenDeCompra> Listar()
        {
            return context.OrdenDeCompras
                .AsNoTracking()
                .Include(x => x.Proveedor)
                .Include(x => x.detalles)
                    .ThenInclude(x => x.Producto)
                .ToList();
        }

        public OrdenDeCompra ObtenerPorId(int Tid)
        {
            OrdenDeCompra ord = context.OrdenDeCompras.First(x => x.Id == Tid);
            return ord ?? new OrdenDeCompra();
        }

        public override void Add(OrdenDeCompra t)
        {
            t.Proveedor = context.Proveedores.First(x => x.Cuit == t.Proveedor.Cuit);

            foreach (var detalle in t.detalles)
            {
                detalle.Producto = (detalle.Producto.EsPerecedero) ?
                    context.ProductoPercederos.First(x => x.Id == detalle.Producto.Id) :
                    context.ProductoNoPercederos.First(x => x.Id == detalle.Producto.Id);
            }
            context.OrdenDeCompras.Add(t);
        }

        public override void Del(OrdenDeCompra t)
        {
            OrdenDeCompra ord = context.OrdenDeCompras.First(x => x.Id == t.Id);
            if (ord == null) return;
            context.OrdenDeCompras.Remove(ord);
        }

        public override void Mod(OrdenDeCompra t)
        {

            t.Proveedor = context.Proveedores.First(x => x.Cuit == t.Proveedor.Cuit);

            foreach (var detalle in t.detalles)
            {
                detalle.Producto = (detalle.Producto.EsPerecedero) ?
                    context.ProductoPercederos.First(x => x.Id == detalle.Producto.Id) :
                    context.ProductoNoPercederos.First(x => x.Id == detalle.Producto.Id);
            }
            context.OrdenDeCompras.Update(t);
        }


    }
}
