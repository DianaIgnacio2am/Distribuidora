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
    public partial class FrmPresupuestos : Form
    {
        public FrmPresupuestos()
        {
            InitializeComponent();
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            // Recupera la lista de presupuestos
            var presupuestos = ControladoraPresupuestos.Instance.Listar();

            // Establece el DataSource del DataGridView
            dgvPresupuestos.DataSource = presupuestos;

            // Asegúrate de que solo las columnas que deseas mostrar están visibles
            foreach (DataGridViewColumn column in dgvPresupuestos.Columns)
            {
                column.Visible = column.Name == "Id" || column.Name == "Fecha" || column.Name == "Habilitado"
                                 || column.Name == "Aceptado" || column.Name == "Proveedor";
            }

            // Configura el formato del proveedor para mostrar solo el nombre
            if (dgvPresupuestos.Columns["Proveedor"] != null)
            {
                dgvPresupuestos.Columns["Proveedor"].DefaultCellStyle.Format = "Proveedor";
                dgvPresupuestos.Columns["Proveedor"].ValueType = typeof(string);
                dgvPresupuestos.Columns["Proveedor"].HeaderText = "Proveedor";
                dgvPresupuestos.CellFormatting += (sender, e) =>
                {
                    if (e.ColumnIndex == dgvPresupuestos.Columns["Proveedor"].Index)
                    {
                        var proveedor = e.Value as Proveedor;
                        if (proveedor != null)
                        {
                            e.Value = proveedor.Nombre;
                            e.FormattingApplied = true;
                        }
                    }
                };
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new FrmPresupuesto())
            {
                form.ShowDialog();
                ActualizarGrilla();
            }
        }

        private void dgvPresupuestos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si hay filas seleccionadas en dgvPresupuestos
            if (dgvPresupuestos.SelectedRows.Count == 0) return;

            // Recupera el ID del presupuesto seleccionado
            int presupuestoId = Convert.ToInt32(dgvPresupuestos.SelectedRows[0].Cells["Id"].Value.ToString());

            // recupera Presupuesto con el ID 
            var presupuesto = new Presupuesto { Id = presupuestoId };

            // Obtén los detalles del presupuesto usando el método de la controladora
            var detallesPresupuesto = ControladoraPresupuestos.Instance.ListarDetalles(presupuesto);

            // Asigna la lista de detalles al DataSource de dgvdetallesPresupuesto
            dgvdetallesPresupuesto.DataSource = null;
            dgvdetallesPresupuesto.DataSource = detallesPresupuesto;

            foreach (DataGridViewColumn column in dgvdetallesPresupuesto.Columns)
            {
                column.Visible = column.Name == "NombreDelProducto" || column.Name == "MontoCUPropuesto" || column.Name == "Cantidad"
                                 || column.Name == "Subtotal";
            }

            numtotal.Value = Convert.ToDecimal(detallesPresupuesto.Sum(x => x.Subtotal).ToString());

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Verifica si hay filas seleccionadas en dgvPresupuestos
            if (dgvPresupuestos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un presupuesto para eliminar.");
                return;
            }

            // Recupera el ID del presupuesto seleccionado
            int presupuestoId = Convert.ToInt32(dgvPresupuestos.SelectedRows[0].Cells["Id"].Value.ToString());

            // Crea un objeto de Presupuesto con el ID recuperado
            var presupuesto = new Presupuesto { Id = presupuestoId };

            // Confirma la eliminación con el usuario
            var result = MessageBox.Show("¿Estás seguro de que deseas eliminar este presupuesto?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Llama al método Eliminar de la controladora con el objeto Presupuesto
                    ControladoraPresupuestos.Instance.Eliminar(presupuesto);

                    // Actualiza la grilla de presupuestos después de eliminar el presupuesto
                    ActualizarGrilla();


                    dgvdetallesPresupuesto.DataSource = null;

                    MessageBox.Show("Presupuesto eliminado exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el presupuesto: {ex.Message}");
                }
            }
        }

        private void btnAceptarPresupuesto_Click(object sender, EventArgs e)
        {
            if (dgvPresupuestos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un presupuesto para aceptar.");
                return;
            }
            if (dgvPresupuestos.SelectedRows.Count > 0)
            {
                Presupuesto prep = dgvPresupuestos.SelectedRows[0].DataBoundItem as Presupuesto;
                string msg = ControladoraPresupuestos.Instance.AceptarPresupuesto(prep);
                MessageBox.Show(msg);
                ActualizarGrilla();
            }
        }
    }
}
