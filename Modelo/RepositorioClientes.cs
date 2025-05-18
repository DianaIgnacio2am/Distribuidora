using Entidades;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace Modelo
{
    public sealed class RepositorioClientes : Repositorio<Cliente>
    {
        public RepositorioClientes(Context context)
        {

            this.context = context;
        }

        public override List<Cliente> Listar()
        {
            return context.Clientes
                .AsNoTracking()
                .ToList();
        }

        public Cliente ObtenerPorId(Int64 Tid)
        {
            Cliente cli = context.Clientes.FirstOrDefault(x => x.Cuit == Tid);
            return cli ?? new Cliente();
        }

        public override void Add(Cliente t)
        {
            context.Clientes.Add(t);
        }

        public override void Del(Cliente t)
        {
            Cliente cli = context.Clientes.First(x => x.Cuit == t.Cuit);
            if (cli == null) return;
            cli.Habilitado = false;
        }

        public override void Mod(Cliente t)
        {
            context.Clientes.Update(t);
        }


    }
}

