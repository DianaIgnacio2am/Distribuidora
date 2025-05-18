using System.Collections.ObjectModel;
using Entidades;
using Modelo;

namespace Controladora
{
    public class ControladoraOrdenDeCompras : Singleton<ControladoraOrdenDeCompras>
    {
        private RepositorioOrdenDeCompra repositorioOrdenDeCompra;
        public ControladoraOrdenDeCompras()
        {
            repositorioOrdenDeCompra = new(new Context());
        }

        public string Añadir(OrdenDeCompra t)
        {
            if (t == null) return "El OrdenDeCompra es nulo fallo la carga";
            if (t.Proveedor == null) return "No se cargo el proveedor";
            
            // checkea que los detalles sean validos
            if (ProductoCheck(t.MostrarDetalles())) return "Hay referencias a productos no existentes";

            repositorioOrdenDeCompra.Add(t);
            return (repositorioOrdenDeCompra.Guardar()) ? 
                $"El OrdenDeCompra {t.Id} se cargo correctamente":
                $"Fallo la carga del OrdenDeCompra {t.Id}"; 
        }


        private bool ProductoCheck(ReadOnlyCollection<DetalleOrdenDeCompra> ldetalles)
        {
            bool ret = false;

            var lproductos = new RepositorioProductos(new Context()).Listar();
            Parallel.ForEach(ldetalles, (ll) =>
            {
                var producto = lproductos.FirstOrDefault(x => x.Id == ll.Producto.Id);
                ret = (producto == null) ? true : false;

            });
            return ret;
        }


        public string Eliminar(OrdenDeCompra t)
        {
           if (t == null) return "El OrdenDeCompra es nulo fallo la carga";
           if (t.Id < 0) return "El Id esta mal cargado";
            
           repositorioOrdenDeCompra.Del(t);
           return (repositorioOrdenDeCompra.Guardar()) ? 
                $"El OrdenDeCompra {t.Id} se Elimino correctamente":
                $"Fallo la Eliminacion del OrdenDeCompra {t.Id}";         
        }

        public string Modificar(OrdenDeCompra t)
        {
            if (t == null) return "El OrdenDeCompra es nulo fallo la carga";

            repositorioOrdenDeCompra.Mod(t);
            return (repositorioOrdenDeCompra.Guardar()) ? 
                $"El OrdenDeCompra {t.Id} se Modifico correctamente":
                $"Fallo la Modificacion del OrdenDeCompra {t.Id}";    
        }

        public ReadOnlyCollection<OrdenDeCompra> Listar()
        {
            return repositorioOrdenDeCompra.Listar().AsReadOnly();
        }

        public ReadOnlyCollection<DetalleOrdenDeCompra> ListarDetalles(OrdenDeCompra orden)
        {
            var ordenalistar = repositorioOrdenDeCompra.Listar().First(x => x.Id == orden.Id);
            if (ordenalistar == null) return new ReadOnlyCollection<DetalleOrdenDeCompra>(new List<DetalleOrdenDeCompra>());
            return ordenalistar.MostrarDetalles();

        }

        public Presupuesto? MostrarPresupuestoPorId(Presupuesto? presupuesto)
        {
            if (presupuesto == null) return null;
            if (presupuesto.Id < 0) return null;
            var pres = ControladoraPresupuestos.Instance.Listar().First(x => x.Id == presupuesto.Id);
            return pres;
        }

        public object ListarProveedores()
        {
            return ControladoraProveedores.Instance.Listar()
                .Where(x => x.Habilitado == true)
                .ToList()
                .AsReadOnly();
        }

        public ReadOnlyCollection<DetallePresupuesto> ListarDetallesDePresupuesto(Presupuesto presupuesto)
        {
            Presupuesto pres = ControladoraPresupuestos.Instance.Listar().First(x => x.Id == presupuesto.Id);
            if (pres == null) return new ReadOnlyCollection<DetallePresupuesto>(new List<DetallePresupuesto>());
            return pres.MostrarDetalles();
        }

        public ReadOnlyCollection<Presupuesto>? ListarPresupuestosPorProveedorHabilitadosAceptado(Proveedor proveedor)
        {
            if (proveedor == null) return null;
            if (proveedor.Cuit < 0) return null;
            var presupuestos = ControladoraPresupuestos.Instance.Listar()
                .Where(x => x.Proveedor.Cuit == proveedor.Cuit)
                .Where(x => x.Habilitado == true)
                .Where(x => x.Aceptado == true)
                .ToList()
                .AsReadOnly();
            return presupuestos;
        }
    }
}

