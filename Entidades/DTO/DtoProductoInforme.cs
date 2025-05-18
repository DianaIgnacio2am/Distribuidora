using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.DTO
{
    public class DtoProductoInforme
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int CantidadVendida { get; set; }
        public int StockRemanente { get; set; }

        public DtoProductoInforme(int Id, string Nombre, int CantidadVendida, int StockRemanente)
        {
            this.CantidadVendida = CantidadVendida;
            this.Id = Id;
            this.Nombre = Nombre;
            this.StockRemanente = StockRemanente;

        }
    }
}
