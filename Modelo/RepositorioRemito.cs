using System.Collections.ObjectModel;
using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public sealed class RepositorioRemito : Repositorio<Remito>
    {

        public RepositorioRemito(Context context)
        {
            this.context = context;
        }

        public override List<Remito> Listar()
        {
            return context.Remitos
                .AsNoTracking()
                .Include(x => x.Lotes)
                    .ThenInclude(x => x.Producto)
                .Include(x => x.Proveedor)
                .ToList();
        }

        public Remito ObtenerPorId(int Tid)
        {
            Remito rem = context.Remitos.First(x => x.Id == Tid);
            return rem ?? new Remito();
        }

        public override void Add(Remito t)
        {
            if (t.Lotes == null) return;
            
            t.Proveedor = context.Proveedores.First(x => x.Cuit == t.Proveedor.Cuit);

            var listaLotes = new List<Lote>();

       
            foreach (var lote in t.Lotes)
            {
                listaLotes.Add((Lote)lote.Clone());
                listaLotes.Last().Producto = lote.Producto;
                listaLotes.Last().CantRecibida = lote.Cantidad;
            }
   
            foreach (var lote in listaLotes)
            {
                lote.Producto = (lote.Producto.EsPerecedero) ?
                    context.ProductoPercederos.FirstOrDefault(x => x.Id == lote.Producto.Id) :
                    context.ProductoNoPercederos.FirstOrDefault(x => x.Id == lote.Producto.Id);

            }
     
            t.Lotes = listaLotes;
  
            context.Remitos.Add(t);
        }


        public override void Del(Remito t)
        {
            Remito rem = context.Remitos.First(x => x.Id == t.Id);
            if (rem == null) return;
            context.Remitos.Remove(rem);
        }

        public override void Mod(Remito t)
        {
            context.Remitos.Update(t);
        }
    }
}
