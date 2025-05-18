using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public sealed class RepositorioProductosPercedero : Repositorio<ProductoPercedero>
    {
        public RepositorioProductosPercedero(Context context)
        {
            this.context = context;
        }

        public override List<ProductoPercedero> Listar()
        {
            return context.ProductoPercederos
                .AsNoTracking()
                .Include(x => x.proveedores)
                .Include(x => x.categorias)
                .ToList();
        }

        public ProductoPercedero ObtenerPorId(int Tid)
        {
            ProductoPercedero pro = context.ProductoPercederos.First(x => x.Id == Tid);
            return pro ?? new ProductoPercedero();
        }

        public override void Add(ProductoPercedero t)
        {
            var listcat = t.categorias.ToList();
            var listpro = t.proveedores.ToList();
            t.categorias.Clear();
            t.proveedores.Clear();

            foreach (var prov in listpro)
            {
                var prove = context.Proveedores.First(x => x.Cuit == prov.Cuit);
                t.proveedores.Add(prove);
            }
            foreach (var categoria in listcat)
            {
                var cat = context.Categorias.First(x => x.Id == categoria.Id);
                t.categorias.Add(cat);
            }
            context.ProductoPercederos.Add(t);
        }

        public override void Del(ProductoPercedero t)
        {
            ProductoPercedero pro = context.ProductoPercederos.First(x => x.Id == t.Id);
            if (pro == null) return;
            pro.Habilitado = false;
        }

        public override void Mod(ProductoPercedero t)
        {
            ProductoPercedero pro = context.ProductoPercederos
                .Include(x => x.proveedores)
                .Include(x => x.categorias)
                .First(x => x.Id == t.Id);

            pro.Nombre = t.Nombre;
            pro.Precio = t.Precio;
            pro.Habilitado = t.Habilitado;
            pro.MesesHastaConsumoPreferente = t.MesesHastaConsumoPreferente;
            pro.MesesHastaVencimiento = t.MesesHastaVencimiento;
            pro.EsPerecedero = t.EsPerecedero;
            pro.proveedores.Clear();
            pro.categorias.Clear();
            
            foreach (var prov in t.proveedores)
            {
                var prove = context.Proveedores.First(x => x.Cuit == prov.Cuit);
                pro.proveedores.Add(prove);
            }
            
            foreach (var categoria in t.categorias)
            {
                var cate = context.Categorias.First(x => x.Id == categoria.Id);
                pro.categorias.Add(cate);  // Añade las categorías actualizadas
            }
            //List<Proveedor> proveedores = new List<Proveedor>();
            //foreach (var prov in t.proveedores)
            //{
            //    var prove = context.Proveedores.First(x => x.Cuit == prov.Cuit);
            //    proveedores.Add(prove);
            //}
            //t.proveedores = proveedores;
            //context.ProductoPercederos.Update(t);

        }
    }
}
