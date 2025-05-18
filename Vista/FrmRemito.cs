using Controladora;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmRemito : Form
    {
        public FrmRemito()
        {
            InitializeComponent();
            ActualizarTablaOrdendeCompra();
        }
        private void ActualizarTablaOrdendeCompra()
        {
            dgvOrdenDeCompra.DataSource = null;
            dgvOrdenDeCompra.DataSource = ControladoraRemito.Instance.ListarOrdenesSinEntregar();
            foreach (DataGridViewColumn column in dgvOrdenDeCompra.Columns)
            {
                column.Visible = column.Name == "Id" || column.Name == "NombreProveedor"
                                 || column.Name == "MontoTotal";
            }
            numId.Value = (ControladoraRemito.Instance.Listar().Count) > 0 ?
                ControladoraRemito.Instance.Listar().Max(x=> x.Id+1):
                0;
        }

        private void dgvOrdenDeCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrdenDeCompra.SelectedRows.Count == 0) return;

            int ordenid = Convert.ToInt32(dgvOrdenDeCompra.SelectedRows[0].Cells["Id"].Value.ToString());

            var orden = new OrdenDeCompra { Id = ordenid };

            var detallesorden = ControladoraRemito.Instance.ListarDetallesOrdenesDeCompra(orden);

            dgvDetalles.DataSource = null;
            dgvDetalles.DataSource = detallesorden;

            foreach (DataGridViewColumn column in dgvDetalles.Columns)
            {
                column.Visible = column.Name == "IdPresupuesto" || column.Name == "NombreProducto" || column.Name == "MontoCU"
            || column.Name == "Cantidad" || column.Name == "SubTotal";
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (dgvOrdenDeCompra.SelectedRows.Count <= 0) return;
            var selectedRow = dgvOrdenDeCompra.SelectedRows[0];
            var orden = new OrdenDeCompra
            {
                Id = Convert.ToInt32(selectedRow.Cells["Id"].Value.ToString()),
            };
            orden = ControladoraRemito.Instance.MostrarOrdenDeCompraPorId(orden);
            orden.Entregado = true;
            if (orden == null) return;

            var remito = new Remito
            {
                Proveedor = orden.Proveedor,
            };
            foreach (var detalle in ControladoraRemito.Instance.ListarDetallesOrdenesDeCompra(orden)) 
            {
                Lote lote = new Lote
                {
                    Id = detalle.Id,
                    Cantidad = detalle.Cantidad,
                    Fecha = DateTime.Now,
                    Habilitado = true,
                    Producto = detalle.Producto,
                };
                remito.AñadirLote(lote);
            }

            var msg = ControladoraRemito.Instance.Añadir(remito, orden);
            MessageBox.Show(msg);
            this.Close();
        }
    }
}
