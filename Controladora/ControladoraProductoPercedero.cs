using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraProductoPercedero : Singleton<ControladoraProductoPercedero>
    {
        RepositorioProductosPercedero Percedero;
        public ControladoraProductoPercedero()
        {
            Percedero = new RepositorioProductosPercedero(new Context());
        }
        public string Añadir(ProductoPercedero t)
        {
            if (t == null) return "El Producto es nulo fallo la carga";

            Percedero.Add(t);
            return (Percedero.Guardar()) ?
                $"El Producto {t.Nombre} se cargo correctamente" :
                $"Fallo la carga del Producto {t.Nombre}";
        }

        public string Eliminar(ProductoPercedero t)
        {
            if (t == null) return "El Producto es nulo fallo la carga";

            Percedero.Del(t);
            return (Percedero.Guardar()) ?
                $"El Producto {t.Nombre} se Elimino correctamente" :
                $"Fallo la eliminacion del Producto {t.Nombre}";
        }

        public string Modificar(ProductoPercedero t)
        {
            if (t == null) return "El Producto es nulo fallo la carga";

            Percedero.Mod(t);
            return (Percedero.Guardar()) ?
                $"El Producto {t.Nombre} se Modifico correctamente" :
                $"Fallo la Modificacion del Producto {t.Nombre}";
        }
    }
}
