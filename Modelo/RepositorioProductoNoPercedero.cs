using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public sealed class RepositorioProductosNoPercedero : Repositorio<ProductoNoPercedero>
    {
        public RepositorioProductosNoPercedero(Context context)
        {
            this.context = context;
        }

        public override List<ProductoNoPercedero> Listar()
        {
            return context.ProductoNoPercederos
                .AsNoTracking()
                .Include(x => x.proveedores)
                .Include(x => x.categorias)
                .ToList();
        }

        public ProductoNoPercedero ObtenerPorId(int Tid)
        {
            ProductoNoPercedero pro = context.ProductoNoPercederos.First(x => x.Id == Tid);
            return pro ?? new ProductoNoPercedero();
        }

        public override void Add(ProductoNoPercedero t)
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
            context.ProductoNoPercederos.Add(t);
        }

        public override void Del(ProductoNoPercedero t)
        {
            ProductoNoPercedero pro = context.ProductoNoPercederos.First(x => x.Id == t.Id);
            if (pro == null) return;
            pro.Habilitado = false;
        }

        public override void Mod(ProductoNoPercedero t)
        {
            ProductoNoPercedero pro = context.ProductoNoPercederos
                .Include(x => x.proveedores)
                .Include(x => x.categorias)
                .First(x => x.Id == t.Id);

            pro.Nombre = t.Nombre;
            pro.Precio = t.Precio;
            pro.Habilitado = t.Habilitado;
            pro.TipoDeEnvase = t.TipoDeEnvase;
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
                var cat = context.Categorias.First(x => x.Id == categoria.Id);
                pro.categorias.Add(cat); 
            }
        }
    }
}
