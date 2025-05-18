using Controladora;
using Entidades;
using Modelo;
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
    public partial class FrmInformeFacturasPorCliente : Form
    {
        private ReadOnlyCollection<Factura> facturas;
        private DateTime fecini, fecfin;
        public FrmInformeFacturasPorCliente()
        {
            InitializeComponent();
            IniciarTablaClientes();
            if (ControladoraInformes.Instance.RecuperarConfig().Informar == false) btnEnviarEmail.Enabled = false;

        }

        private void IniciarTablaClientes()
        {
            dgvCliente.DataSource = ControladoraClientes.Instance.ListarTodos();
            foreach (DataGridViewColumn column in dgvCliente.Columns)
            {
                column.Visible = column.Name == "Cuit" || column.Name == "NombreCompleto";
            }
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                Cliente cli = (Cliente)dgvCliente.SelectedRows[0].DataBoundItem;

                //es por si mandas un email mantener el state de las fechas
                fecini = dateInicio.Value;
                fecfin = dateFin.Value;
                var lista = ControladoraInformes.Instance.MostrarFacturasDeClienteEnRangoDeFechas(cli, dateInicio.Value, dateFin.Value);

                if (lista == null)
                {
                    MessageBox.Show("Hubo un error obteniendo la lista de Facturas para el cliente");
                    return;
                }

                RefrescarTablaFacturas(lista);
                facturas = lista;
            }
        }

        private bool Check()
        {
            bool ret = true;
            string msg = "";
            if (dateInicio.Value >= dateFin.Value) msg += "La fecha final no puede ser igual o mayor que la de inicio\n";
            if (dgvCliente.SelectedRows.Count <= 0) msg += "Tenes que seleccionar un cliente primero\n";

            if (msg != "")
            {
                MessageBox.Show(msg);
                ret = false;
            }
            return ret;
        }

        private void RefrescarTablaFacturas(ReadOnlyCollection<Factura> list)
        {
            dgvDetalle.DataSource = null;
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
            dgvDetalle.DataSource = null;
            dgvDetalle.DataSource = list;
            foreach (DataGridViewColumn column in dgvDetalle.Columns)
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
            string msg = ControladoraInformes.Instance.EnviarEmail($"Facturas cliente: {facturas[0].NombreCliente} del {fecini.ToString()} hasta {fecfin.ToString()}", facturas.ToList());
            MessageBox.Show(msg);
        }
    }
}
