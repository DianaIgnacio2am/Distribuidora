
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    public class DetalleFactura: Detalle<Producto>, ICloneable
    {
        public DetalleFactura() { }
        public int IdFactura { get; set; }

        public double Subtotal
        {
            get
            {
                return Producto.Precio * Cantidad;
            }
        }

        public string NombreProducto
        {
            get
            {
                return Producto.Nombre;
            }
        }

        private DetalleFactura(DetalleFactura detalle)
        {
            Id = detalle.Id;
            IdFactura = detalle.IdFactura;
            Producto = detalle.Producto;
            Cantidad = detalle.Cantidad;
        }
        public object Clone()
        {
            return new DetalleFactura(this);
        }
    }
}
