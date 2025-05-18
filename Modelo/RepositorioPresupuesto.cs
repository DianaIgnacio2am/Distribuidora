using System.Collections.ObjectModel;
using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public sealed class RepositorioPresupuesto : Repositorio<Presupuesto>
    {
        public RepositorioPresupuesto(Context context)
        {
            this.context = context;
        }

        public override List<Presupuesto> Listar()
        {
            return context.Presupuestos
                .AsNoTracking()
                .Include(x => x.detalles)
                    .ThenInclude(x => x.Producto)
                .Include(x => x.Proveedor)
                .ToList();
        }

        public Presupuesto ObtenerPorId(int Tid)
        {
            Presupuesto pre = context.Presupuestos.First(x => x.Id == Tid);
            return pre ?? new Presupuesto();
        }

        public override void Add(Presupuesto t)
        {
            t.Proveedor = context.Proveedores.First(x => x.Cuit == t.Proveedor.Cuit);
            
            foreach (var detalle in t.detalles)
            {
                detalle.IdPresupuesto = t.Id;

                detalle.Producto = detalle.Producto.EsPerecedero ?
                    context.ProductoPercederos.First(x => x.Id == detalle.Producto.Id) :
                    context.ProductoNoPercederos.First(x => x.Id == detalle.Producto.Id);
                

            }
            context.Presupuestos.Add(t);
        }

        public override void Del(Presupuesto t)
        {
            Presupuesto pre = context.Presupuestos.First(x => x.Id == t.Id);
            if (pre == null) return;
            pre.Habilitado = false;
        }

        public override void Mod(Presupuesto t)
        { // más que modificar es un marcar como aceptado
            var pre = context.Presupuestos.First(x => x.Id == t.Id);
            pre.Aceptado = t.Aceptado;
            
        }
    }
}