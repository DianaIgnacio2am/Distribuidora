using System.Reflection.Metadata.Ecma335;
using System.Transactions;
using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public sealed class RepositorioCategoria : Repositorio<Categoria>
    {
  
        public RepositorioCategoria(Context context)
        {
        }

        public override List<Categoria> Listar()
        {
            return context.Categorias
                .AsNoTracking()
                .ToList();
        }

        public Categoria ObtenerPorId(int Tid)
        {
            Categoria cat = context.Categorias.FirstOrDefault(x => x.Id == Tid);
            return cat ?? new Categoria();
        }

        public override void Add(Categoria t)
        {
            context.Categorias.Add(t);
        }

        public override void Del(Categoria t)
        {
            Categoria cat = context.Categorias.First(x => x.Id == t.Id);
            if (cat == null) return;
            context.Categorias.Remove(cat);
        }

        public override void Mod(Categoria t)
        {
            context.Categorias.Update(t);
        }


    }
}
