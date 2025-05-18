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

namespace Vista
{
    public partial class FrmFactura : Form
    {
        private Factura factura = new Factura();
        private int detalleid;
        public FrmFactura()
        {
            InitializeComponent();
            ActualizarGrilla();
            CargarDatos();
 
        }

        private void ActualizarGrilla()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = ControladoraFacturas.Instance.ListarProductos();

            dgvClientes.DataSource = null;
            dgvClientes.DataSource = ControladoraFacturas.Instance.ListarClientes();


            foreach (DataGridViewColumn column in dgvDetalles.Columns)
            {
                column.Visible = column.Name == "Id" || column.Name == "Producto" || column.Name == "Cantidad"
                    || column.Name == "PrecioUnitario" || column.Name == "Subtotal";
            }

            foreach (DataGridViewColumn column in dgvClientes.Columns)
            {
                column.Visible = column.Name == "Cuit" || column.Name == "NombreCompleto" || column.Name == "Correo";
            }

            foreach (DataGridViewColumn column in dgvProductos.Columns)
            {
                column.Visible = column.Name == "Id" || column.Name == "Nombre" || column.Name == "Precio";
            }

        }

        private void CargarDatos()
        {
 

            var listdetalle = ControladoraFacturas.Instance.Listar();
            numid.Value = (listdetalle.Count > 0) ?
                listdetalle.Max(x => x.Id + 1) :
                0;

            numid.Enabled = false; // Deshabilitar el control para que no se pueda modificar

            numtotal.Enabled = false; // Deshabilitar el control para que no se pueda modificar

            // Recuperar los lotes asociados a la factura y actualizar el DataGridView
            //            var listaDetalles = ControladoraFacturas.Instance.ListarDetallesFactura(factura);

            // Actualizar el total
            ActualizarTotal();
        }

        private void ActualizarTotal()
        {
            // Recalcular el total de la factura
            decimal total = 0;
            foreach (var detalle in factura.MostrarDetalles())
            {
                total += (decimal)(detalle.Producto.Precio * detalle.Cantidad);
            }
            numtotal.Value = total;
        }

        private bool ValidarDatos()
        {
            string devolucion = "";

            if (string.IsNullOrEmpty(numid.Text)) devolucion += "El ID no puede ser nulo o vacío\n";
            //if (dgvClientes.Enabled == true) devolucion += "Debe seleccionar un cliente\n";

            if (devolucion == "")
            {
                return true;
            }
            else
            {
                MessageBox.Show(devolucion, "Errores de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Validar los datos antes de continuar
            if (ValidarDatos())
            {
                factura.Total = Convert.ToDouble(numtotal.Value);
                factura.Fecha = datepick.Value;
                factura.Cliente = new Cliente { Cuit = (long)dgvClientes.SelectedRows[0].Cells["Cuit"].Value };

                string mensaje = ControladoraFacturas.Instance.Añadir(factura);
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void btnAddDetalle_Click(object sender, EventArgs e)
        {

            // No quiero que cambien de cliente una vez que ya empezaron a armar la factura
            dgvClientes.Enabled = false;

            if (ValidarDatosdetalle()) return;
            if (dgvProductos.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow selectedRow in dgvProductos.SelectedRows)
                {
                    Producto producto = (Producto)selectedRow.DataBoundItem;
                    var checkcolicion = factura.MostrarDetalles().Count(x => x.Producto.Id == producto.Id);
                    if (checkcolicion != 0)
                    {
                        MessageBox.Show("El Producto ya fue cargado");
                        return;
                    }

                    factura.AñadirDetalle(new DetalleFactura
                    {
 
                        Cantidad = (int)numCantidad.Value,
                        Producto = ControladoraProductos.Instance.Listar().First(x => x.Id == producto.Id),
                    });
                    ActualizarGrillaDetalles();
                }
            }
        }
        private void ActualizarGrillaDetalles()
        {
            var detalles = factura.MostrarDetalles();
            dgvDetalles.DataSource = null;
            if (detalles.Any())
            {
                var loteDatos = detalles.Select(detalle => new
                {
                    Id = detalle.Id,
                    Producto = detalle.Producto.Nombre,
                    CantidadDeProductos = detalle.Cantidad,
                    Subtotal = detalle.Subtotal,
                    PrecioUnitario = detalle.Producto.Precio,
                }).ToList();

                dgvDetalles.DataSource = loteDatos;
                numtotal.Value = (Decimal)loteDatos.Sum(x => x.Subtotal);
            }
        }


        // metodo para validar los datos del detalle
        private bool ValidarDatosdetalle()
        {
            string devolucion = "";

            // Validar la selección del producto
            if (dgvProductos.CurrentRow == null)
                devolucion += "Debe seleccionar un producto para añadir al lote\n";

            // Validar la cantidad de productos
            if (numCantidad.Value <= 0)
                devolucion += "La cantidad de productos debe ser mayor que cero\n";

            if (devolucion == "")
            {
                return false;
            }
            else
            {
                MessageBox.Show(devolucion, "Errores de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDetalles.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow selectedRow in dgvDetalles.SelectedRows)
                {
                    DetalleFactura det = new DetalleFactura
                    {
                        Id = Convert.ToInt32(selectedRow.Cells["Id"].Value),
                    };
                    var detalleAborrar = factura.MostrarDetalles().First(x => x.Id == det.Id);
                    factura.EliminarDetalle(detalleAborrar);
                    ActualizarGrillaDetalles();
                    detalleid--;
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar Proveedor del producto.");
            }
        }
    }
}