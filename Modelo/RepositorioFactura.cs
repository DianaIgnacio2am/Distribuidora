using System.Collections.ObjectModel;
using Entidades;
using Entidades.DTO;
using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public sealed class RepositorioFactura : Repositorio<Factura>
    {
        public RepositorioFactura(Context context)
        {
            this.context = context;
        }

        public override List<Factura> Listar()
        {
            return context.Facturas
                .AsNoTracking()
                .Include(x => x.Detalles)
                .Include(x => x.Cliente)
                .ToList();
        }

        public override void Add(Factura t)
        {
            t.Cliente = context.Clientes.FirstOrDefault(x => x.Cuit == t.Cliente.Cuit);

            var list = new List<DetalleFactura>();

            int contador = 0;
            foreach (var detalle in t.Detalles)
            {
                list.Add((DetalleFactura)detalle.Clone());
                list.Last().Producto = detalle.Producto;
                list.Last().Id = contador++;
            }

            foreach (var detalle in list)
            {
                detalle.Producto = (detalle.Producto.EsPerecedero) ?
                    context.ProductoPercederos.FirstOrDefault(x => x.Id == detalle.Producto.Id) :
                    context.ProductoNoPercederos.FirstOrDefault(x => x.Id == detalle.Producto.Id);
            }

            t.Detalles = list;

            context.Facturas.Add(t);
        }

        public override void Del(Factura t)
        {
            Factura fac = context.Facturas.First(x => x.Id == t.Id);
            if (fac == null) return;
            context.Facturas.Remove(fac);
        }

        public override void Mod(Factura t)
        {
            context.Facturas.Update(t);
        }

        public Factura ObtenerPorId(Factura fac)
        {
            var factura = context.Facturas
                            .Include(x => x.Detalles)
                                .ThenInclude(x => x.Producto)
                            .FirstOrDefault(x => x.Id == fac.Id);
            return factura;
        }

        public ReadOnlyCollection<Factura> ObtenerFacturasDeClienteEnRangoFechas(Cliente cli, DateTime fecInicio, DateTime fecFin)
        {
            return context.Facturas
                .AsNoTracking()
                .Include(x => x.Detalles)
                    .ThenInclude(x => x.Producto)
                .Include(x => x.Cliente)
                .Where(x => x.Fecha > fecInicio && x.Fecha < fecFin && x.Cliente.Cuit == cli.Cuit)
                .ToList().AsReadOnly();
        }
        public ReadOnlyCollection<Factura> ObtenerFacturasEnRangoFechas(DateTime fecInicio, DateTime fecFinal)
        {
            return context.Facturas
                .AsNoTracking()
                .Include(x => x.Detalles)
                    .ThenInclude(x=>x.Producto)
                .Include(x => x.Cliente)
                .Where(x => (x.Fecha > fecInicio && x.Fecha < fecFinal))
                .ToList().AsReadOnly();

        }

        public List<DtoProductoInforme> ObtenerInformeProductoMasUsados()
        {
            var list
                = context.DetalleFacturas
                    .GroupBy(df => df.Producto)
                    .Select(g => new DtoProductoInforme
                    (
                        g.Key.Id,
                        g.Key.Nombre,
                        g.Sum(df => df.Cantidad),
                        0
                    ))
                    .ToList()
                    .OrderByDescending(x => x.CantidadVendida);
            foreach (var item in list)
            {
                item.StockRemanente = context.Lotes.Where(x => x.Producto.Id == item.Id).Sum(x => x.Cantidad);
            }

            
            return list.ToList();
        }
    }
}
