using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public sealed class RepositorioProveedor : Repositorio<Proveedor>
    {
        public RepositorioProveedor(Context context)
        {
            this.context = context;
        }

        public override List<Proveedor> Listar()
        {
            return context.Proveedores
                .AsNoTracking()
                .ToList();
        }

        public Proveedor ObtenerPorId(long Tid)
        {
            Proveedor pro = context.Proveedores.First(x => x.Cuit == Tid);
            return pro ?? new Proveedor();
        }

        public override void Add(Proveedor t)
        {
            context.Proveedores.Add(t);
        }

        public override void Del(Proveedor t)
        {
            Proveedor pro = context.Proveedores.First(x => x.Cuit == t.Cuit);
            if (pro == null) return;
            pro.Habilitado = false;
        }

        public override void Mod(Proveedor t)
        {
            context.Proveedores.Update(t);
        }


    }
}
