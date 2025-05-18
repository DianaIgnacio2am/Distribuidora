using System.Collections.ObjectModel;
using System.Reflection.Metadata.Ecma335;
using Entidades;
using Modelo;

namespace Controladora
{
    public class ControladoraCategorias : Singleton<ControladoraCategorias>
    {
        private RepositorioCategoria repositorioCategoria;
        public ControladoraCategorias()
        {
            repositorioCategoria = new(new Context());
        }

        public string Añadir(Categoria t)
        {
            if (t == null) return "La categoría es nula, fallo la carga";

            repositorioCategoria.Add(t);
            repositorioCategoria.Guardar();
            return $"La categoría {t.Descripcion} se cargó correctamente";
        }

        public string Eliminar(Categoria t)
        {
            if (t == null) return "La categoría es nula, fallo la carga";

            repositorioCategoria.Del(t);
            repositorioCategoria.Guardar();
            return $"La categoría {t.Descripcion} se eliminó correctamente";
        }

        public string Modificar(Categoria t)
        {
            if (t == null) return "La categoría es nula, fallo la carga";

            repositorioCategoria.Mod(t);
            repositorioCategoria.Guardar();
            return $"La categoría {t.Descripcion} se modificó correctamente";
        }

        public ReadOnlyCollection<Categoria> Listar()
        {
            return repositorioCategoria.Listar().AsReadOnly();
        }
    }
}
