    using System.Collections.ObjectModel;
    using System.ComponentModel.DataAnnotations.Schema;

    namespace Entidades
{
    public class Remito
    {
        public int Id { get; set; }

        public Proveedor Proveedor { get; set; }

        public List<Lote> Lotes = new List<Lote>();
        public void AñadirLote(Lote lote)
        {
            try
            {
                Lotes.Add(lote);
            }
            catch (Exception)
            {
                throw;
            }
        }
        [NotMapped]
        public string NombreProveedor
        {
            get
            {
                return Proveedor.Nombre;
            }
        }
    }
}
