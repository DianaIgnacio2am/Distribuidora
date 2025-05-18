using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    public class Cliente
    {
        public Int64 Cuit { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public bool Habilitado { get; set; }

        [NotMapped]
        public string NombreCompleto
        {
            get { return $"{Nombre} {Apellido}"; }
        }

    }
}
