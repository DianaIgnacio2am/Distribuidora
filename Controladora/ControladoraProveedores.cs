using System.Collections.ObjectModel;
using Entidades;
using Modelo;

namespace Controladora
{
    public class ControladoraProveedores : Singleton<ControladoraProveedores>
    {
        private RepositorioProveedor repositorioProveedor;
        public ControladoraProveedores()
        {
            repositorioProveedor = new RepositorioProveedor(new Context());
        }

        public string Añadir(Proveedor t)
        {
            if (t == null) return "El Proveedor es nulo fallo la carga";

            try
            {
                repositorioProveedor.Add(t);
                return repositorioProveedor.Guardar() ?
                    $"El Proveedor {t.Nombre} se cargó correctamente" :
                    $"Falló la carga del Proveedor {t.Nombre}";
            }
            catch (InvalidOperationException ex)
            {
                return ex.Message; // Captura la excepción y muestra el mensaje adecuado
            }
        }

        public string Eliminar(long t)
        {
            var proveedor = repositorioProveedor.Listar().FirstOrDefault(x => x.Cuit == t);

            if (proveedor == null) return "El Proveedor es nulo fallo la baja";

            repositorioProveedor.Del(proveedor);
            return (repositorioProveedor.Guardar()) ?
                $"El Proveedor {proveedor.Nombre} se eliminó correctamente" :
                $"Falló la eliminación del Proveedor {t}";
        }

        public string Modificar(Proveedor t)
        {
            if (t == null) return "El Proveedor es nulo fallo la modificación";

            repositorioProveedor.Mod(t);
            return (repositorioProveedor.Guardar()) ?
                $"El Proveedor {t.Nombre} se modificó correctamente" :
                $"Falló la modificación del Proveedor {t.Nombre}";
        }

        public ReadOnlyCollection<Proveedor> Listar()
        {
            return repositorioProveedor.Listar()
                .Where(x => x.Habilitado == true)
                .ToList()
                .AsReadOnly();
        }

    }
}
