using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }  
        public double Precio { get; set; }  
        public bool Habilitado { get; set; }
        public bool EsPerecedero { get; set; }

        public List<Proveedor> proveedores = new List<Proveedor>();

        public void AñadirProveedor(Proveedor proveedor)
        {
            if(proveedor == null) return;
            proveedores.Add(proveedor);
        }
        public bool EliminarProveedor(Proveedor proveedor)
        {
            var pAEliminar = proveedores.FirstOrDefault(x => x.Cuit == proveedor.Cuit);
            if (pAEliminar == null) return false;
            return proveedores.Remove(pAEliminar);
        }

        public List<Categoria> categorias = new List<Categoria>();

        public void AñadirCategoria(Categoria cat) {
            categorias.Add(cat);
        }

        public bool EliminarCategoria(Categoria cat) {
            var cAEliminar = categorias.FirstOrDefault(x => x.Id == cat.Id);
            if (cAEliminar == null) return false;
            return categorias.Remove(cAEliminar);
        }

    }
}
