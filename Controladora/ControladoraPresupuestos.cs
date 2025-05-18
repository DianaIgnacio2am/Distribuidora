using System.Collections.ObjectModel;
using Entidades;
using Modelo;

namespace Controladora
{
    public class ControladoraPresupuestos : Singleton<ControladoraPresupuestos>
    {
        RepositorioPresupuesto repositorioPresupuestos;
        public ControladoraPresupuestos() {
            repositorioPresupuestos = new RepositorioPresupuesto(new Context());
        }

        public string Añadir(Presupuesto t)
        {
            if (t == null) return "El Presupuesto es nulo, falló la carga";
            if (t.MostrarDetalles() == null || !t.MostrarDetalles().Any()) return "El Presupuesto no tiene productos, falló la carga";
            if (t.Proveedor == null) return "El Proveedor es nulo, falló la carga";

            repositorioPresupuestos.Add(t);
            return repositorioPresupuestos.Guardar() ?
                $"El Presupuesto {t.Id} se cargó correctamente" :
                $"Falló la carga del Presupuesto {t.Id}";
        }

        public string Eliminar(Presupuesto t)
        {
           if (t == null) return "El Presupuesto es nulo fallo la carga";

           repositorioPresupuestos.Del(t);
           return (repositorioPresupuestos.Guardar()) ? 
                $"El Presupuesto {t.Id} se Elimino correctamente":
                $"Fallo la Eliminacion del Presupuesto {t.Id}";         
        }
         
        public string AceptarPresupuesto(Presupuesto t)
        {
            if (t == null) return "El Presupuesto es nulo fallo la carga";
            if (t.Aceptado == true) return "El presupuesto ya fue aceptado";

            t.Aceptado = true;
            repositorioPresupuestos.Mod(t);
            return (repositorioPresupuestos.Guardar()) ? 
                $"El Presupuesto {t.Id} se Acepto correctamente":
                $"Fallo la aceptacion del Presupuesto {t.Id}";    
        }
        public ReadOnlyCollection<Presupuesto> Listar()
        {
            return repositorioPresupuestos.Listar()
                .Where(x => x.Habilitado == true)
                .ToList()
                .AsReadOnly();
        }

        public ReadOnlyCollection<DetallePresupuesto> ListarDetalles(Presupuesto presupuesto)
        {
            Presupuesto pres = repositorioPresupuestos.Listar().First(x=> x.Id == presupuesto.Id);
            if (pres == null) return new ReadOnlyCollection<DetallePresupuesto>(new List<DetallePresupuesto>());
            return pres.MostrarDetalles();

        }

        public object ListarProductosPorProveedor(Proveedor proveedor)
        {
            if (proveedor == null) return new List<Producto>().AsReadOnly();
            if (proveedor.Cuit < 0) return new List<Producto>().AsReadOnly();
            var productos = ControladoraProductos.Instance
                .Listar()
                .Where(x => x.proveedores
                            .Any(x => x.Cuit == proveedor.Cuit))
                .ToList()
                .AsReadOnly();

            return productos;
        }

        public ReadOnlyCollection<Proveedor> ListarProveedores()
        {
            return ControladoraProveedores.Instance.Listar();
        }

        public ReadOnlyCollection<Presupuesto> ListarTodo()
        {
            return repositorioPresupuestos.Listar().AsReadOnly();
        }
    }
}

