using Controladora;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmOrdenesDeCompras : Form
    {
        public FrmOrdenesDeCompras()
        {
            InitializeComponent();
            CargaDatos();
        }

        private void CargaDatos()
        {
            ActualizarGrilla();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new FrmOrdenDeCompra())
            {
                form.ShowDialog();
                ActualizarGrilla();
            }
        }

        private void ActualizarGrilla()
        {
            dgvOrdenDeCompra.DataSource = null;
            dgvOrdenDeCompra.DataSource = ControladoraOrdenDeCompras.Instance.Listar();
            foreach (DataGridViewColumn column in dgvOrdenDeCompra.Columns)
            {
                column.Visible = column.Name == "Id" || column.Name == "NombreProveedor"
                                 || column.Name == "MontoTotal";
            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Verifica si hay filas seleccionadas en dgvPresupuestos
            if (dgvOrdenDeCompra.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una orden de Compra para eliminar.");
                return;
            }

            // Recupera el ID del presupuesto seleccionado
            int ordenId = Convert.ToInt32(dgvOrdenDeCompra.SelectedRows[0].Cells["Id"].Value.ToString());

            // Crea un objeto de Presupuesto con el ID recuperado
            var orden = new OrdenDeCompra { Id = ordenId };

            // Confirma la eliminación con el usuario
            var result = MessageBox.Show("¿Estás seguro de que deseas eliminar esta orden?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Llama al método Eliminar de la controladora con el objeto Presupuesto
                    ControladoraOrdenDeCompras.Instance.Eliminar(orden);

                    // Actualiza la grilla de presupuestos después de eliminar el presupuesto
                    ActualizarGrilla();

                    MessageBox.Show("Orden eliminado exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar la Orden de Compra: {ex.Message}");
                }
            }
        }

        private void dgvOrdenDeCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrdenDeCompra.SelectedRows.Count == 0) return;

            int ordenid = Convert.ToInt32(dgvOrdenDeCompra.SelectedRows[0].Cells["Id"].Value.ToString());

            var orden = new OrdenDeCompra { Id = ordenid };

            var detallesorden = ControladoraOrdenDeCompras.Instance.ListarDetalles(orden);

            dgvDetalles.DataSource = null;
            dgvDetalles.DataSource = detallesorden;

            foreach (DataGridViewColumn column in dgvDetalles.Columns)
            {
                column.Visible = column.Name == "IdPresupuesto" || column.Name == "NombreProducto" || column.Name == "MontoCU"
            || column.Name == "Cantidad" || column.Name == "SubTotal";
            }
        }


    }
}
