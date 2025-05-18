
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    public class Categoria
    {
        public Int32 Id { get; set; }
        public string Descripcion { get; set; }
    }
}
