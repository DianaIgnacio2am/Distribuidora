using Controladora;
using Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Informes
{
    public partial class FrmInformeFacturaPorFecha : Form
    {
        private ReadOnlyCollection<Factura>? facturas;
        private DateTime fecini, fecfin;
        public FrmInformeFacturaPorFecha()
        {
            InitializeComponent();
            if (ControladoraInformes.Instance.RecuperarConfig().Informar == false) btnEnviarEmail.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (dateInicio.Value >= dateFin.Value)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            //es por si mandas un email mantener el state de las fechas
            fecini = dateInicio.Value;
            fecfin = dateFin.Value;

            facturas = ControladoraInformes.Instance.MostrarFacturasEnRangoDeFechas(dateInicio.Value, dateFin.Value);


            if (facturas == null)
            {
                MessageBox.Show("No se encontraron facturas en el rango de fechas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            RefrescarTablaFacturas(facturas);

        }
        private void RefrescarTablaFacturas(ReadOnlyCollection<Factura> list)
        {
            dgvDetalles.DataSource = null;
            dgvFactura.DataSource = null;
            dgvFactura.DataSource = list;
            foreach (DataGridViewColumn column in dgvFactura.Columns)
            {
                column.Visible = column.Name == "Id" || column.Name == "Total" || column.Name == "Fecha" || column.Name == "NombreCliente";
            }
        }

        private void dgvFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFactura.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Falta seleccionar una linea");
                return;
            }

            Factura? fac = (Factura)dgvFactura.SelectedRows[0].DataBoundItem;

            fac = facturas.FirstOrDefault(x => x.Id == fac.Id);
            if (fac == null)
            {
                MessageBox.Show("No se logro encontrar la factura");
                return;
            }

            RefrescarTablaDetalles(fac.Detalles);
        }
        private void RefrescarTablaDetalles(List<DetalleFactura> list)
        {
            dgvDetalles.DataSource = null;
            dgvDetalles.DataSource = list;
            foreach (DataGridViewColumn column in dgvDetalles.Columns)
            {
                column.Visible = column.Name == "Subtotal" || column.Name == "NombreProducto" || column.Name == "Cantidad";
            }
        }

        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            if (facturas == null || facturas.Count <= 0)
            {
                MessageBox.Show("No hay facturas para mandar email");
                return;
            }
            string msg = ControladoraInformes.Instance.EnviarEmail($"Facturas del {fecini.ToString()} hasta {fecfin.ToString()}", facturas.ToList());
            MessageBox.Show(msg);
        }
    }
}