using Controladora;
using Entidades;
using System.Collections.ObjectModel;

namespace Vista
{
    public partial class FrmFacturas : Form
    {

        public FrmFacturas()
        {
            InitializeComponent();
  
            ActualizarGrillas();
        }
        private void ActualizarGrillas()
        {
            dgvFacturas.DataSource = null;
            dgvFacturas.DataSource = ControladoraFacturas.Instance.Listar();

            foreach (DataGridViewColumn column in dgvFacturas.Columns)
            {
                column.Visible = column.Name == "Total" || column.Name == "Fecha"
                    || column.Name == "NombreCliente" || column.Name == "Cuit";
            }

        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var form = new FrmFactura();
            form.ShowDialog();
            ActualizarGrillas();
        }

 
        private void ActualizarGrillaDetalles(Factura fac)
        {
            dgvDetalles.DataSource = null;
            dgvDetalles.DataSource = fac.Detalles;

            foreach (DataGridViewColumn column in dgvDetalles.Columns)
            {
                column.Visible = column.Name == "Cantidad" || column.Name == "NombreProducto"
                    || column.Name == "PrecioUnitario" || column.Name == "Subtotal";
            }
            
 
        }
        private void dgvFacturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFacturas.SelectedRows.Count > 0 )
            {
                var factura = ControladoraFacturas.Instance.ObtenerPorId((Factura)dgvFacturas.SelectedRows[0].DataBoundItem);
                ActualizarGrillaDetalles(factura);
            }
        }

    }
}
