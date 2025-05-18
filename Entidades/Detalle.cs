using System.ComponentModel;

namespace Entidades
{
    public class Detalle <T> where T: Producto
    {
        public int Id { get; set; }

        public int Cantidad { get; set; }

        public T Producto { get; set; }

    }

}