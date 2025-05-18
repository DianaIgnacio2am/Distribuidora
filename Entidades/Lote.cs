
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    public class Lote : Detalle<Producto>, ICloneable
    {
        public int IdRemito {  get; set; }
        public DateTime Fecha { get; set; }
        public bool Habilitado { get; set; }
        public int CantRecibida { get; set; }

        [NotMapped]
        public string NombreProducto
        {
            get
            {
                return Producto.Nombre;
            }
        }

        public Lote() { }

        /// ICLONEABLE IMPLEMENTATION
        ///  <summary>
        /// ICLONEABLE IMPLEMENTATION        
        private Lote(Lote lote)
        {
            Id = lote.Id;
            Cantidad = lote.Cantidad;
            
            IdRemito = lote.IdRemito;
            Fecha = lote.Fecha;
            Habilitado = lote.Habilitado;
            CantRecibida = CantRecibida;

        }
        public object Clone()
        {
            return new Lote(this);
        }
    }

}
