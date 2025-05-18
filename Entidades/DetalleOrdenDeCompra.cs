
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    public class DetalleOrdenDeCompra: Detalle<Producto>
    {
        public int IdOrdenDeCompra { get; set; }
        public double MontoCU { get; set; }
        public int IdPresupuesto { get; set; }

        [NotMapped]
        public string NombreProducto 
        { 
            get
            {
                return Producto.Nombre;
            } 
        }
        public double SubTotal
        {
            get
            {
                return MontoCU * Cantidad;
            }
        }
    }
}
