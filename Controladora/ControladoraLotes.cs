using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraLotes : Singleton<ControladoraLotes>
    {
        private RepositorioLote repositorioLotes;
        public ControladoraLotes()
        {
            repositorioLotes = new(new Context());
        }
 
        public string DisminuirStock(Factura factura)
        {
            foreach (var detalle in factura.Detalles)
            {
                if (detalle == null) return "El detalle es nulo";
                if (detalle.Producto.Id < 0) return "Esta mal cargada la Id de producto";
                var productos = ControladoraProductos.Instance.Listar();
                if (!productos.Any(x => x.Id == detalle.Producto.Id)) return "No hay Productos con esa id";
               
            }
            var ret = repositorioLotes.DisminuirStock(factura);
            repositorioLotes.Guardar();
            return (ret) ?
                "Se Descontaron los productos":
                "Se fallo al diminuir el stock";

        }

        public int MostrarStockDeProducto(Producto producto)
        {
            if (producto == null) return 0;
            if (producto.Id < 0) return 0;
            var lotes = repositorioLotes.Listar();
            if (!lotes.Any(x => x.Producto.Id == producto.Id)) return 0; 

            var CantidadStock = lotes
                .Where(x => x.Producto.Id == producto.Id)
                .Sum(x=> x.Cantidad);
            return CantidadStock;
        }

        public ReadOnlyCollection<Lote> Listar()
        {
            return repositorioLotes.Listar().Where(x=> x.Habilitado == true)
                    .ToList().AsReadOnly();
        }
    }
}
