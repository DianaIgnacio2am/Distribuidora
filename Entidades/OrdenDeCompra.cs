using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

namespace Entidades
{
    public class OrdenDeCompra
    {
        public int Id { get; set; } 
        public Proveedor Proveedor { get; set; }
        public long IdProveedor { get; set; }
        public bool Entregado { get; set; }

        public List<DetalleOrdenDeCompra> detalles = new List<DetalleOrdenDeCompra>();
        public void AñadirDetalle(DetalleOrdenDeCompra detalle)
        {
            detalles.Add(detalle);
        }

        public bool EliminarDetalle(DetalleOrdenDeCompra detalle)
        {
            var aeliminar = detalles.Find(x => x.Id == detalle.Id);
            if (aeliminar == null) return false;
            return detalles.Remove(aeliminar);
        }

        public ReadOnlyCollection<DetalleOrdenDeCompra> MostrarDetalles()
        {
            return detalles.AsReadOnly();
        }

        [NotMapped]
        public double MontoTotal
        {
            get
            {
                return detalles.Sum(x => x.SubTotal);
            }
        }
        [NotMapped]
        public string NombreProveedor
        {
            get
            {
                return Proveedor.Nombre;
            }
        }
    }
}
