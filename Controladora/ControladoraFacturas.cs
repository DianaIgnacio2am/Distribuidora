using System.Collections.ObjectModel;
using Entidades;
using Modelo;

namespace Controladora
{
    public class ControladoraFacturas : Singleton<ControladoraFacturas>
    {
        private RepositorioFactura repositorioFacturas;
        public ControladoraFacturas()
        {
            repositorioFacturas = new(new Context());
        }

        public string Añadir(Factura t)
        {
            if (t == null) return "La Factura es nula, fallo la carga";

            if (t.Cliente == null || t.Cliente.Cuit == 0) return "Debe seleccionar un cliente antes de agregar la factura";

            string checkstock = "";

            if (t.MostrarDetalles().Count <= 0) return "Se debe Cargar un detalle en la factura antes de agregarla";

            foreach (var detalle in t.MostrarDetalles())
            {
                if (detalle.Cantidad > ControladoraLotes.Instance.MostrarStockDeProducto(detalle.Producto))
                {
                    checkstock += $"No hay existencias en stock para realizar la venta de {detalle.Producto.Nombre}\n";
                }
            }
            if (checkstock != "") return checkstock;

            try
            {
                repositorioFacturas.Add(t);
                bool resultado = repositorioFacturas.Guardar();
                t = ObtenerPorId(t);
                string resultadolote = ControladoraLotes.Instance.DisminuirStock(t);
 
                var detallesList = t.Detalles;

                if (resultado && resultadolote == "Se Descontaron los productos")
                {
                    if (ControladoraInformes.Instance.Informa) { 
 
                        string emailResult = ControladoraInformes.Instance.EnviarEmail(
                            "Factura Cargada",
                            detallesList // Pasa la lista convertida
                        );
                    return $"La Factura con el ID {t.Id} se cargó correctamente. {emailResult}";
                    }
                    return $"La Factura con el ID {t.Id} se cargó correctamente.";
                }
                else
                {
                    return $"Falló la carga de la Factura con el ID {t.Id}";
                }
            }
            catch (Exception ex)
            {
                // Captura cualquier excepción no prevista
                return $"Ocurrió un error inesperado: {ex.Message}";
            }
        }



        public ReadOnlyCollection<Factura> Listar()
        {
            return repositorioFacturas.Listar()
                .AsReadOnly();
        }

        public Factura ObtenerPorId(Factura fac)
        {
            return repositorioFacturas.ObtenerPorId(fac);
        }

        public ReadOnlyCollection<DetalleFactura> ListarDetallesFactura(Factura factura)
        {
            Factura facturaalistar = ControladoraFacturas.Instance.Listar().First(x => x.Id == factura.Id);
            if (facturaalistar == null) return new ReadOnlyCollection<DetalleFactura>(new List<DetalleFactura>());
            return facturaalistar.MostrarDetalles();

        }

        public ReadOnlyCollection<Producto> ListarProductos()
        {
            return ControladoraProductos.Instance.Listar();
        }

        public ReadOnlyCollection<Cliente> ListarClientes()
        {
            return ControladoraClientes.Instance.Listar();
        }
    }
}
    