using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoNoPercedero : Producto
    {
        public EnvaseTipo TipoDeEnvase { get; set; }

        public ProductoNoPercedero()
        {
            EsPerecedero = false; // Indica que este producto no es perecedero
        }
    }

}
