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
    public partial class FrmOrdenDeCompra : Form
    {
        private OrdenDeCompra orden = new OrdenDeCompra();
        private List<DetalleOrdenDeCompra> detalles = new List<DetalleOrdenDeCompra>();
        private int detalleid = 0;
        public FrmOrdenDeCompra()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            var listaOrden = ControladoraOrdenDeCompras.Instance.Listar();
            numId.Value = (listaOrden.Count > 0) ?
                listaOrden.Max(x => x.Id + 1) :
                0;
            numId.Enabled = false;

            //Asegúrate de que solo las columnas que deseas mostrar están visibles
            foreach (DataGridViewColumn column in dgvPresupuesto.Columns)
            {
                column.Visible = column.Name == "Id" || column.Name == "Fecha" || column.Name == "ProveedorNombre";
            }

            dgvProveedor.DataSource = null;
            dgvProveedor.DataSource = ControladoraOrdenDeCompras.Instance.ListarProveedores();

        }

        private void btnAddProducto_Click(object sender, EventArgs e)
        {
            if (dgvPresupuesto.SelectedRows.Count > 0)
            {
                dgvProveedor.Enabled = false;
                foreach (DataGridViewRow selectedRow in dgvPresupuesto.SelectedRows)
                {
                    Presupuesto? pres = new Presupuesto
                    {
                        Id = Convert.ToInt32(selectedRow.Cells["Id"].Value.ToString()),
                    };
                    pres = ControladoraOrdenDeCompras.Instance.MostrarPresupuestoPorId(pres);

                    if (pres == null)
                    {
                        MessageBox.Show("No existe Presupuesto por ese Id");
                        return;
                    }

                    var listadetalle = ControladoraOrdenDeCompras.Instance.ListarDetallesDePresupuesto(pres);

                    foreach (var detalle in listadetalle)
                    {

                        orden.AñadirDetalle(new DetalleOrdenDeCompra
                        {
                            Cantidad = detalle.Cantidad,
                            Id = detalleid++,
                            IdOrdenDeCompra = Convert.ToInt32(numId.Value),
                            MontoCU = detalle.MontoCUPropuesto,
                            Producto = detalle.Producto,
                        });
                    }

                    dgvOrdendeCompra.DataSource = null;
                    dgvOrdendeCompra.DataSource = orden.MostrarDetalles();
                    foreach (DataGridViewColumn column in dgvOrdendeCompra.Columns)
                    {
                        column.Visible = column.Name == "IdPresupuesto" || column.Name == "NombreProducto" || column.Name == "MontoCU"
                                         || column.Name == "Cantidad"|| column.Name == "SubTotal";
                    }
                    numTotal.Value = Convert.ToDecimal(orden.MontoTotal);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para añadir Proveedor al producto.");
            }
        }

        private void dgvPresupuesto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si hay filas seleccionadas en dgvPresupuesto
            if (dgvPresupuesto.SelectedRows.Count == 0) return;

            // Recupera el ID del presupuesto seleccionado
            int presupuestoId = Convert.ToInt32(dgvPresupuesto.SelectedRows[0].Cells["Id"].Value.ToString());
            var presupuesto = new Presupuesto
            {
                Id = presupuestoId,
            };

            // Obtén los detalles del presupuesto usando el método de la controladora
            var detallesPresupuesto = ControladoraOrdenDeCompras.Instance.ListarDetallesDePresupuesto(presupuesto);

            // Crea una lista para mostrar el proveedor y los detalles del presupuesto
            var proveedorYDetalles = detallesPresupuesto.Select(d => new
            {

                d.NombreDelProducto,
                d.MontoCUPropuesto,
                d.Cantidad,
                d.Subtotal
            }).ToList();

            // Asigna la lista de proveedor y detalles al DataSource de dgvProveedor
            dgvDetalle.DataSource = null;
            dgvDetalle.DataSource = proveedorYDetalles;

            foreach (DataGridViewColumn column in dgvDetalle.Columns)
            {
                column.Visible = column.Name == "NombreDelProducto" || column.Name == "MontoCUPropuesto"
                                 || column.Name == "Cantidad" || column.Name == "Subtotal";
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Validaciones()
        {
            string ret = "";
            if (numId.Value < 0) ret += "El numero de Id es invalido\n";

            if (orden.MostrarDetalles().Count == 0) ret += "No hay detalles en la orden de compra\n";

            if (ret == "")
            {
                return false;
            }
            MessageBox.Show(ret);
            return true;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validaciones()) return;

            orden.Proveedor = (Proveedor)dgvProveedor.SelectedRows[0].DataBoundItem;
            string msg = ControladoraOrdenDeCompras.Instance.Añadir(orden);
            MessageBox.Show(msg);
            this.Close();
        }

        private void dgvProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProveedor.SelectedRows.Count == 0) return;

            var selectedRow = dgvProveedor.SelectedRows[0];
            var proveedor = new Proveedor
            {
                Cuit = Convert.ToInt64(selectedRow.Cells["Cuit"].Value),
            };

            var presupuestos = ControladoraOrdenDeCompras.Instance.ListarPresupuestosPorProveedorHabilitadosAceptado(proveedor);

            dgvPresupuesto.DataSource = null;
            dgvPresupuesto.DataSource = presupuestos;

            foreach (DataGridViewColumn column in dgvPresupuesto.Columns)
            {
                column.Visible = column.Name == "Id" || column.Name == "Fecha"
                                 || column.Name == "ProveedorNombre";
            }
        }

        private void btnrmPresupuesto_Click(object sender, EventArgs e)
        {
            if (dgvOrdendeCompra.SelectedRows.Count == 0) return;
            var selectedRow = dgvOrdendeCompra.SelectedRows[0];

            var presupuesto = new Presupuesto
            {
                Id = Convert.ToInt32(selectedRow.Cells["IdPresupuesto"].Value.ToString()),
            };

            var listaAEliminar = orden.MostrarDetalles().Where(x => x.IdPresupuesto == presupuesto.Id).ToList();
            foreach (var detalle in listaAEliminar)
            {
                orden.EliminarDetalle(detalle);
            }

            dgvOrdendeCompra.DataSource = null;
            dgvOrdendeCompra.DataSource = orden.MostrarDetalles();
            numTotal.Value = Convert.ToDecimal(orden.MontoTotal);
        }
    }
}
