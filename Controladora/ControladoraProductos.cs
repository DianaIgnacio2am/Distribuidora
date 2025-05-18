using System.Collections.ObjectModel;
using Entidades;
using Modelo;

namespace Controladora
{
    public class ControladoraProductos : Singleton<ControladoraProductos>
    {
        public ReadOnlyCollection<Producto> Listar()
        {
            return new RepositorioProductos(new Context()).Listar()
                .Where(x => x.Habilitado == true)
                .ToList()
                .AsReadOnly();
        }

        public ReadOnlyCollection<Proveedor> ListarProveedores(Producto producto)
        {
            Producto productoalistar = new RepositorioProductos(new Context()).Listar().First(x => x.Id == producto.Id);
            if (productoalistar == null) return new List<Proveedor>().AsReadOnly();
            return productoalistar.proveedores.AsReadOnly();

        }
        public ReadOnlyCollection<Categoria> ListarCategorias(Producto producto)
        {
            Producto productoalistar = new RepositorioProductos(new Context()).Listar().First(x => x.Id == producto.Id);
            return productoalistar.categorias.AsReadOnly();

        }

        public Producto? MostrarPorId(Producto producto)
        {
            if (producto == null) return null;
            if (producto.Id < 0) return null;
            var lista = new RepositorioProductos(new Context()).Listar();
            if (lista.Any(x=> x.Id == producto.Id)){
                return lista.First(x => x.Id == producto.Id);
            }
            return null;
        }

        public ReadOnlyCollection<Proveedor> ListarProveedores()
        {
            return ControladoraProveedores.Instance.Listar()
                .Where(x => x.Habilitado == true)
                .ToList()
                .AsReadOnly();
        }

        public ReadOnlyCollection<Categoria> ListarCategorias()
        {
            return ControladoraCategorias.Instance.Listar();
        }

        public int MostrarStock(Producto producto)
        {
            return ControladoraLotes.Instance.MostrarStockDeProducto(producto);
        }
    }
}