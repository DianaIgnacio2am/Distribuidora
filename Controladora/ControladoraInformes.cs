using Entidades;
using Entidades.DTO;
using Informes;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraInformes : Singleton<ControladoraInformes>
    {
        const string configpath = "settings.json";

        private RepositorioFactura repositorioFactura = new(new Context());

        public ReadOnlyCollection<Factura>? MostrarFacturasEnRangoDeFechas(DateTime FechaInicio, DateTime FechaFinal)
        {
            if (FechaFinal < FechaInicio) return null;
            
            ReadOnlyCollection<Factura> list = repositorioFactura.ObtenerFacturasEnRangoFechas(FechaInicio, FechaFinal);
            return list;
        }

        public ReadOnlyCollection<Factura>? MostrarFacturasDeClienteEnRangoDeFechas(Cliente cli, DateTime fecInicio, DateTime fecFin)
        {
            if (fecFin < fecInicio) return null;
            if (cli.Cuit <= 0) return null;
            
            ReadOnlyCollection<Factura> list = repositorioFactura.ObtenerFacturasDeClienteEnRangoFechas(cli, fecInicio, fecFin);
            return list;
        }
        
        public List<DtoProductoInforme>? MostrarProductosMasVendidos()
        {
            return repositorioFactura.ObtenerInformeProductoMasUsados();
        }

        public void GuardarConfig(ConfigEmail config)
        {
            try
            {
                string json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(configpath, json);
 
            }
            catch (IOException) { throw; }
        }
        public string EnviarEmail(string titulo, List<DetalleFactura> detalles)
        {
            if (detalles == null || detalles.Count == 0)
                return "La lista de detalles está vacía o es nula.";

            // Utiliza la instancia singleton de InformeEmail para enviar el correo
            return InformeEmail.Instance.EnviarEmailFactura(titulo, detalles);
        }
        public string EnviarEmail(string titulo, List<Factura> facturas)
        {
            if (facturas == null || facturas.Count == 0)
                return "La lista de facturas está vacía o es nula.";

            
            return InformeEmail.Instance.EnviarEmailFacturas(titulo, facturas);
        }
        public bool Informa
        {
            get
            {
                string jsonString = File.ReadAllText(configpath);
                return JsonSerializer.Deserialize<ConfigEmail>(jsonString).Informar;
            }
        }
        public ConfigEmail RecuperarConfig()
        {
            try
            {
                if (!File.Exists(configpath))
                {
                    string json = JsonSerializer.Serialize(new ConfigEmail { EmailAddr = "", EmailPass = "", EmailTarget = new List<String>() }, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(configpath, json);
                }
            }
            catch (IOException ex) { throw; }

            string jsonString = File.ReadAllText(configpath);
            return JsonSerializer.Deserialize<ConfigEmail>(jsonString);
        }
    }
}
