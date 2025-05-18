
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    public class DetallePresupuesto: Detalle<Producto>
    {
        public int IdPresupuesto { get; set; }

        public double MontoCUPropuesto { get; set; }

        [NotMapped]
        public string NombreDelProducto {
            get
            {
                return Producto.Nombre;
            }
        }
        public double Subtotal { 
            get
            {
                return MontoCUPropuesto * Cantidad;
            } 
        }
    }
}
