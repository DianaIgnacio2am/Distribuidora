using Controladora;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmPresupuesto : Form
    {
        private Presupuesto presupuesto = new Presupuesto();
        private int id = 0;
        public FrmPresupuesto()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            dgvProveedor.DataSource = null;
            dgvProveedor.DataSource = ControladoraPresupuestos.Instance.ListarProveedores();

            var presupuestolist = ControladoraPresupuestos.Instance.ListarTodo();
            numId.Value = (presupuestolist.Count > 0) ?
                presupuestolist.Max(x => x.Id + 1) :
                0;
            numId.Enabled = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener el proveedor seleccionado del DataGridView
            if (dgvProveedor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un proveedor.");
                return;
            }
            var proveedorSeleccionado = (Proveedor)dgvProveedor.SelectedRows[0].DataBoundItem;
            proveedorSeleccionado = ControladoraProveedores.Instance.Listar().First(x => x.Cuit == proveedorSeleccionado.Cuit);

            // Crear una nueva instancia de Presupuesto
            var presupuesto = new Presupuesto
            {
                Fecha = DateTime.Now,
                Proveedor = proveedorSeleccionado,
                Habilitado = true,
                Aceptado = false,
            };

            foreach (var detalle in GetDetallesFromDataGridView())
            {
                presupuesto.AñadirDetalle(detalle);
            }

            // Usar la controladora para guardar el presupuesto y sus detalles
            try
            {
                // Guardar el presupuesto usando la controladora
                string resultado = ControladoraPresupuestos.Instance.Añadir(presupuesto);
                MessageBox.Show(resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el presupuesto: {ex.Message}");

            }
            this.Close();
        }


        private List<DetallePresupuesto> GetDetallesFromDataGridView()
        {
            var detalles = new List<DetallePresupuesto>();

            foreach (DataGridViewRow row in dgvPedido.Rows)
            {
                if (row.DataBoundItem is DetallePresupuesto detalle)
                {
                    detalles.Add(detalle);
                }
            }

            return detalles;
        }

        private void btnAddProducto_Click(object sender, EventArgs e)
        {
            if (VerificacionesDetalles()) return;

            if (dgvProducto.SelectedRows.Count > 0 && dgvProveedor.SelectedRows.Count > 0)
            {
                var selectedRow = dgvProducto.SelectedRows[0] as DataGridViewRow;
                Producto producto = (Producto)selectedRow.DataBoundItem;

                try
                {
                    // Verifica si el valor de numCantidad está dentro del rango válido para int
                    int cantidad = Convert.ToInt32(numCantidad.Value);
                    if (cantidad < int.MinValue || cantidad > int.MaxValue)
                    {
                        MessageBox.Show("La cantidad está fuera del rango permitido.");
                        return;
                    }

                    // Verifica si el producto ya está en los detalles del presupuesto
                    bool productoExistente = presupuesto.MostrarDetalles().Any(d => d.Producto.Id == producto.Id);
                    if (productoExistente)
                    {
                        MessageBox.Show("El producto ya está agregado al presupuesto.");
                        return;
                    }

                    // Crear el detalle del presupuesto
                    DetallePresupuesto detalle = new DetallePresupuesto
                    {
                        Id = id++,
                        Producto = producto,
                        Cantidad = cantidad,
                        MontoCUPropuesto = Convert.ToDouble(numPreciopropuesto.Value),
                        IdPresupuesto = (int)numId.Value
                    };

                    // Añadir el detalle al presupuesto
                    presupuesto.AñadirDetalle(detalle);

                    //bloqueamos el dgv de proveedor porque solo se puede cargar un presupuesto
                    //donde todos los productos provengan de un mismo proveedor.
                    dgvProveedor.Enabled = false;

                    // Actualizar el DataGridView
                    dgvPedido.DataSource = null;
                    dgvPedido.DataSource = presupuesto.MostrarDetalles();

                    // Configura las columnas a mostrar y sus encabezados
                    //foreach (DataGridViewColumn column in dgvPedido.Columns)
                    //{
                    //    column.Visible = column.Name == "IdPresupuesto" || column.Name == "Cantidad"
                    //        || column.Name == "NombreDelProducto";
                    //}
                }
                catch (OverflowException ex)
                {
                    MessageBox.Show($"Error de desbordamiento: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar producto: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para agregar el producto.");
            }
        }


        private bool VerificacionesDetalles()
        {
            string ret = "";

            if (numCantidad.Value <= 0) ret += "Cantidad de productos invalida\n";
            if (numPreciopropuesto.Value <= 0) ret += "Precio C/U Invalido\n";

            if (ret == "")
            {
                return false;
            }
            MessageBox.Show(ret);
            return true;

        }

        private bool VerificacionesPresupuesto()
        {
            string ret = "";
            if (numId.Value < 0) ret += "No es un codigo id Valido";

            if (ret == "")
            {
                return false;
            }
            MessageBox.Show(ret); return true;
        }

        private void btnrmProducto_Click(object sender, EventArgs e)
        {
            if (dgvPedido.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.");
                return;
            }

            // Confirmar la eliminación
            var confirmResult = MessageBox.Show("¿Estás seguro de que quieres eliminar este producto del presupuesto?",
                                                 "Confirmación de Eliminación",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    // Obtener el detalle seleccionado
                    var detalleSeleccionado = (DetallePresupuesto)dgvPedido.SelectedRows[0].DataBoundItem;

                    // Eliminar el detalle del presupuesto
                    presupuesto.EliminarDetalle(detalleSeleccionado);

                    // Actualizar el DataGridView
                    dgvPedido.DataSource = null;
                    dgvPedido.DataSource = presupuesto.MostrarDetalles();

                    // Configura las columnas a mostrar y sus encabezados
                    dgvPedido.Columns["IDPresupuesto"].Visible = true;
                    dgvPedido.Columns["Cantidad"].Visible = true;
                    dgvPedido.Columns["NombreDelProducto"].Visible = true;

                    dgvPedido.Columns["IDPresupuesto"].HeaderText = "ID Presupuesto";
                    dgvPedido.Columns["Cantidad"].HeaderText = "Cantidad";
                    dgvPedido.Columns["NombreDelProducto"].HeaderText = "Producto";

                    // Oculta todas las demás columnas
                    foreach (DataGridViewColumn column in dgvPedido.Columns)
                    {
                        if (column.Name != "IDPresupuesto" && column.Name != "Cantidad" && column.Name != "NombreDelProducto")
                        {
                            column.Visible = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el producto: {ex.Message}");
                }
            }
        }

        private void dgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProveedor.SelectedRows.Count == 0) return;

            if (dgvProveedor.SelectedRows.Count > 0)
            {
                var proveedor = new Proveedor
                {
                    Cuit = Convert.ToInt64(dgvProveedor.SelectedRows[0].Cells["Cuit"].Value.ToString()),
                };
                dgvProducto.DataSource = ControladoraPresupuestos.Instance.ListarProductosPorProveedor(proveedor);
            }
        }
    }
}
