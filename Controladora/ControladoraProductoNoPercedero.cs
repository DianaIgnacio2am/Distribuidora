using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraProductoNoPercedero : Singleton<ControladoraProductoNoPercedero>
    {
        RepositorioProductosNoPercedero noPercedero;
        public ControladoraProductoNoPercedero()
        {
            noPercedero = new RepositorioProductosNoPercedero(new Context());
        }

        public string Añadir(ProductoNoPercedero t)
        {
            if (t == null) return "El Producto es nulo fallo la carga";

            noPercedero.Add(t);
            return (noPercedero.Guardar()) ?
                $"El Producto {t.Nombre} se cargo correctamente" :
                $"Fallo la carga del Producto {t.Nombre}";
        }

        public string Eliminar(ProductoNoPercedero t)
        {
            if (t == null) return "El Producto es nulo fallo la carga";

            noPercedero.Del(t);
            return (noPercedero.Guardar()) ?
                $"El Producto {t.Nombre} se Elimino correctamente" :
                $"Fallo la Eliminacion del Producto {t.Nombre}";
        }

        public string Modificar(ProductoNoPercedero t)
        {
            if (t == null) return "El Producto es nulo fallo la carga";

            noPercedero.Mod(t);
            return (noPercedero.Guardar()) ?
                $"El Producto {t.Nombre} se Modifico correctamente" :
                $"Fallo la Modificacion del Producto {t.Nombre}";
        }

        public ReadOnlyCollection<ProductoNoPercedero> Listar()
        {
            return noPercedero.Listar().AsReadOnly();
        }
    }
}
