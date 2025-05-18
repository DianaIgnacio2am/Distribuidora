using System.Diagnostics;
using System.Net.Mail;
using System.Net;
using System.Text.Json;

using Entidades;
namespace Informes
{
    public class InformeEmail
    {
        /// <summary>
        /// Envia Informes por Email
        /// </summary>
        
 
        
        private static InformeEmail instance = new();       
        public static InformeEmail Instance
        { 
            get { return instance; }
        }

        public string EnviarEmailFactura(string titulo, List<DetalleFactura> desc)
        {
            string body = GenerarTablaDetalle(desc);
            return SendMail(titulo, body);

        }
        public string EnviarEmailFacturas(string titulo, List<Factura> facturas)
        {
            string body = GenerarTablaFacturas(facturas); 
            return SendMail(titulo, body);
        }

        private string GenerarTablaFacturas(List<Factura> facturas)
        {
            string body = @"
                <style>
                    table, td, th {
                        border: 1px solid black;
                        }
                </style>
                ";
            foreach (var item in facturas)
            {
                body += $"""
                <hr>
                <h3>Factura del {item.Fecha}, cliente: {item.NombreCliente}</h3>
                <table>
                    <tr>
                        <th>Producto</td>
                        <th>Cantidad</td>
                        <th>Precio CU</td>
                        <th>Subtotal</td>
                    </tr>
                """;
                foreach (var i in item.Detalles)
                {
                    body += $"""
                        <tr>
                            <td>{i.Producto.Nombre}</td>
                            <td>{i.Cantidad}</td>
                            <td>{i.Producto.Precio}</td>
                            <td>{i.Producto.Precio * i.Cantidad}</td>
                        </tr>
                        """;
                }
                body += $"""
                    <tr>
                        <td>Total</td>
                        <td></td>
                        <td></td>
                        <td>{CalcularTotal(item.Detalles)}</td>
                    </tr>
                    </table>
                    """;
            }
            return body;
        }

        private string GenerarTablaDetalle(List<DetalleFactura> desc)
        {
            // Esta seccion es el armado del mail html
            string body =
                @"
                <style>
                    table, td, th {
                        border: 1px solid black;
                    }
                </style>
                <table>
                    <tr>
                        <th>Producto</td>
                        <th>Cantidad</td>
                        <th>Precio CU</td>
                        <th>Subtotal</td>
                    </tr>";

            foreach (var i in desc)
            {
                body +=
                    @$"
                    <tr>
                       <td>{i.Producto.Nombre}</td>
                        <td>{i.Cantidad}</td>
                        <td>{i.Producto.Precio}</td>
                        <td>{i.Producto.Precio * i.Cantidad}</td>
                    </tr>";
            }

            body +=
                @$"
                <tr>
                    <td>Total</td>
                    <td></td>
                    <td></td>
                    <td>{CalcularTotal(desc)}</td>
                </tr>
            </table>";

            return body;
        }
        private double CalcularTotal(List<DetalleFactura> desc)
        {
            double total = 0;
            foreach (var i in desc)
            {
                total += i.Producto.Precio * i.Cantidad;
            }
            return total;
        }



        private string SendMail(string titulo, string body)
        {
            string? ret = null;
            string json;
            ConfigEmail config;
            try
            { // leemos el archivo de configuracion para obtener los certificados y mails destino de los informes
                json = File.ReadAllText("settings.json");
                config = JsonSerializer.Deserialize<ConfigEmail>(json);

            }
            catch (IOException)
            {
                ret = "No se pudo leer el archivo \"settings.json\"";
                throw;
            }

            foreach (var i in config.EmailTarget)
            {
                if (String.IsNullOrWhiteSpace(i)) return "Hay Emails mal cargados";

            }

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential(config.EmailAddr, config.EmailPass);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;

            MailMessage mail = new MailMessage();
            mail.Subject = titulo;
            mail.IsBodyHtml = true;
            mail.Body = body;
            mail.Sender = new MailAddress(config.EmailAddr);
            foreach (var i in config.EmailTarget) mail.To.Add(i);
            mail.From = new MailAddress(config.EmailAddr);

            try
            {
                smtp.Send(mail);
                mail.Dispose();
            }
            catch (Exception)
            {
                ret = "No se pudo comunicar con el server SMTP";
                throw;
            }
            //Decimos que se envio el email correctamente si el valor del retorno sigue siendo nulo en otro caso tendra la descripcion del error.
            return (ret == null) ?
                "Se envio el Email Correctamente" :
                ret;
            //
        }
    }
}
