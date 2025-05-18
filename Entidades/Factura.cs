using System.Collections.ObjectModel;

namespace Entidades
{
    public class Factura
    {
        public int Id { get; set; }
        public double Total { get; set; }
        public DateTime Fecha { get; set; }

        public long IdCliente { get; set; }
        public Cliente Cliente { get; set; }

        public List<DetalleFactura> Detalles = new List<DetalleFactura>();

        public string NombreCliente
        {
            get
            {
                return Cliente.NombreCompleto;
            }
        }
        public long Cuit
        {
            get
            {
                return Cliente.Cuit;
            }
        }

        public void AñadirDetalle(DetalleFactura detalle)
        {
            Detalles.Add(detalle);
        }

        public bool EliminarDetalle(DetalleFactura detalle)
        {
            var aeliminar = Detalles.Find(x => x.Id == detalle.Id);
            if (aeliminar == null) return false;
            return Detalles.Remove(aeliminar);
        }

        public ReadOnlyCollection<DetalleFactura> MostrarDetalles()
        {
            return Detalles.AsReadOnly();
        }
    }
}
