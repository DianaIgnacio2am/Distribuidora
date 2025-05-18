using System.Collections.ObjectModel;
using Entidades;
using Modelo;

namespace Controladora
{
    public class ControladoraClientes : Singleton<ControladoraClientes>
    {
        private RepositorioClientes repositorioClientes;
        public ControladoraClientes()
        {
            repositorioClientes = new(new Context());
        }

        public string Añadir(Cliente t)
        {
            if (t == null) return "El Cliente es nulo, fallo la carga";
            if (t.Cuit == 0) return "Cuit no puede ser 0";
            try
            {
                repositorioClientes.Add(t);
                return repositorioClientes.Guardar() ?
                    $"El Cliente con el CUIT {t.Cuit} se cargó correctamente" :
                    $"Falló la carga del Cliente con el CUIT {t.Cuit}";
            }
            catch (Exception ex)
            {
                // Captura cualquier excepción no prevista
                return $"Ocurrió un error inesperado: {ex.Message}";
            }
        }

        public string Eliminar(long cuit)
        {
            // Buscar el cliente por CUIT antes de eliminar
            var cliente = repositorioClientes.Listar().FirstOrDefault(x => x.Cuit == cuit);
            if (cliente == null) return "El Cliente no existe";

            repositorioClientes.Del(cliente);
            return (repositorioClientes.Guardar()) ?
                $"El Cliente {cliente.Nombre} se eliminó correctamente" :
                $"Falló la eliminación del Cliente con el CUIT {cuit}";
        }

        public string Modificar(Cliente t)
        {
            if (t == null) return "El Cliente es nulo, fallo la carga";

            repositorioClientes.Mod(t);
            return (repositorioClientes.Guardar()) ?
                $"El Cliente con el CUIT {t.Cuit} se modificó correctamente" :
                $"Falló la modificación del Cliente con el CUIT {t.Cuit}";
        }

        public ReadOnlyCollection<Cliente> Listar()
        {
            return repositorioClientes.Listar().Where(x => x.Habilitado == true)
                .ToList()
                .AsReadOnly();
        }
        public ReadOnlyCollection<Cliente> ListarTodos()
        {
            return repositorioClientes.Listar()
                .ToList()
                .AsReadOnly();
        }
    }
}
