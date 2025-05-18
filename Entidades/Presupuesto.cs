    using System.Collections.ObjectModel;
    using System.ComponentModel.DataAnnotations.Schema;

    namespace Entidades
{
    public class Presupuesto
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public bool Habilitado { get; set; }
        public bool Aceptado { get; set; }
        public Proveedor Proveedor { get; set; }
        public long IdProveedor { get; set; }

        [NotMapped]
        public string ProveedorNombre
        {
            get
            {
                return Proveedor.Nombre;
            }
        }

        public List<DetallePresupuesto> detalles = new List<DetallePresupuesto>();
        
        public void AñadirDetalle(DetallePresupuesto det) {
            detalles.Add(det);
        }

        public bool EliminarDetalle(DetallePresupuesto det) {
            var dAEliminar = detalles.FirstOrDefault(x => x.Id == det.Id);
            if (dAEliminar == null) return false;
            return detalles.Remove(dAEliminar);
        }

        public ReadOnlyCollection<DetallePresupuesto> MostrarDetalles()
        {
            return detalles.AsReadOnly();
        }
    }
}
