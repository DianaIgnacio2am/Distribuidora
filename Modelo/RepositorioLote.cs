using Entidades;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.Arm;

namespace Modelo
{
    public sealed class RepositorioLote : Repositorio<Lote>
    {
        public RepositorioLote(Context context)
        {
            this.context = context;
        }

        public override List<Lote> Listar()
        {
            return context.Lotes
                .AsNoTracking()
                .Include(x => x.Producto)
                .ToList();
        }

        public Lote ObtenerPorId(int Tid)
        {
            Lote lot = context.Lotes.First(x => x.Id == Tid);
            return lot ?? new Lote();
        }
        public void Add(Remito rem)
        {
            foreach (var detalle in rem.Lotes)
            {
                detalle.IdRemito = rem.Id;
                Add(detalle);
            }
        }
        public override void Add(Lote t)
        {
            t.Producto = (t.Producto.EsPerecedero) ?
                context.ProductoPercederos.First(x => x.Id == t.Producto.Id) :
                context.ProductoNoPercederos.First(x => x.Id == t.Producto.Id);
            context.Lotes.Add(t);
            Guardar();
        }

        public override void Del(Lote t)
        {
            Lote lot = context.Lotes.First(x => x.Id == t.Id);
            if (lot == null) return;
            lot.Habilitado = false;
        }

        public override void Mod(Lote t)
        {
            context.Lotes.Update(t);
        }

        public bool DisminuirStock(Factura fac)
        {
            bool ret = false;
            foreach (var detalle in  fac.Detalles)
            {
                int cantidad = detalle.Cantidad;
                while (cantidad > 0)
                {
                    var elementoAdisminuir = context.Lotes.Where(x => x.Habilitado == true)
                        .FirstOrDefault(x => x.Producto.Id == detalle.Producto.Id);

                    if (elementoAdisminuir.Cantidad == 0) {
                        elementoAdisminuir.Habilitado = false;
                        context.SaveChanges();
                    }

                    cantidad -= elementoAdisminuir.Cantidad;

                    if (cantidad > 0)
                    {
                        elementoAdisminuir.Cantidad = 0;
                        elementoAdisminuir.Habilitado = false;
                    }
                    else if (cantidad == 0)
                    {
                        elementoAdisminuir.Cantidad = 0;
                        elementoAdisminuir.Habilitado = false;
                        ret = true;
                        context.Lotes.Update(elementoAdisminuir);
                    }
                    else
                    {
                        elementoAdisminuir.Cantidad = -cantidad;
                        ret = true;
                        context.Lotes.Update(elementoAdisminuir);
                    }
                }
            }
            //context.DetalleFacturas.Update(detalleFactura);
            return ret;

        }
    }
}
