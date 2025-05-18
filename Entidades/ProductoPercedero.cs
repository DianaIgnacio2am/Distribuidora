using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoPercedero : Producto
    {
        public int MesesHastaConsumoPreferente { get; set; }
        public int MesesHastaVencimiento { get; set; }

        public ProductoPercedero()
        {
            EsPerecedero = true; // Indica que este producto es perecedero
        }
    }

}
