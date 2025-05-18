using System.Collections.ObjectModel;
using Entidades;
using Modelo;

namespace Controladora
{
    public class ControladoraRemito : Singleton<ControladoraRemito>
    {
        private RepositorioRemito repositorioRemito;

        public ControladoraRemito()
        {
            repositorioRemito = new RepositorioRemito(new Context());
        }
        public ReadOnlyCollection<Remito> Listar()
        {
            return repositorioRemito.Listar()
                .AsReadOnly();
        }

        public string Añadir(Remito t, OrdenDeCompra orden )
        {
            if (t == null) return "El Remito es nulo fallo la carga";
            if (t.Id < 0) return "El id Esta Mal Cargado";

            orden.Entregado = true;
            var retMarcarOrdenEntregada = ControladoraOrdenDeCompras.Instance.Modificar(orden);

            
            repositorioRemito.Add(t);


            return (repositorioRemito.Guardar()) ? 
                $"El remito {t.Id} se cargo correctamente":
                $"Fallo la carga del remito {t.Id}"; 

        }
        public string Modificar(Remito t)
        {
            return "No se puede modificar un Remito";
        }

        private string Eliminar(Remito t)
        {
            return "No se puede Eliminar un remito";
            /*
            if (t == null) return "El Remito es nulo fallo la carga";

            return (RepositorioRemito.Instance.Del(t)) ? 
                $"El remito {t.Id} se elimino correctamente":
                $"Fallo la Eliminacion del remito {t.Id}"; 
            */
        }

        public object ListarLotes()
        {
            return ControladoraLotes.Instance.Listar().Where(x => x.Habilitado == true)
                .ToList().AsReadOnly();
        }

        public ReadOnlyCollection<OrdenDeCompra> ListarOrdenesSinEntregar()
        {
            return ControladoraOrdenDeCompras.Instance.Listar()
                .Where(x => x.Entregado == false)
                .ToList()
                .AsReadOnly();
        }
        public ReadOnlyCollection<DetalleOrdenDeCompra> ListarDetallesOrdenesDeCompra(OrdenDeCompra orden)
        {
            var ordenalistar = ControladoraOrdenDeCompras.Instance.Listar().First(x => x.Id == orden.Id);
            if (ordenalistar == null) return new ReadOnlyCollection<DetalleOrdenDeCompra>(new List<DetalleOrdenDeCompra>());
            return ordenalistar.MostrarDetalles();

        }

        public OrdenDeCompra? MostrarOrdenDeCompraPorId(OrdenDeCompra ordenDeCompra)
        {
            if (ordenDeCompra == null) return null;
            if (ordenDeCompra.Id < 0) return null;
            return ControladoraOrdenDeCompras.Instance.Listar().First(x => x.Id == ordenDeCompra.Id);
        }

        public Remito MostrarRemitoPorId(Remito rem)
        {
            return repositorioRemito.Listar().First(x => x.Id == rem.Id);
            

        }
    }    
}
    