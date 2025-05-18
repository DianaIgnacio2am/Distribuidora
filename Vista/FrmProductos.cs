using Controladora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;
using Controladora;
using Entidades;

namespace Vista
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            ActualizarGrilla();

        }
        private void ConfigurarDataGridView()
        {
            dgvProductos.AutoGenerateColumns = false;

            // Crear una columna para el ID
            var colId = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "Id",
                Name = "Id"
            };

            // Crear una columna para el nombre
            var colNombre = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                Name = "Nombre"
            };

            // Crear una columna para el precio
            var colPrecio = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Precio",
                HeaderText = "Precio",
                Name = "Precio"
            };
            var colHabilitado = new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "Habilitado",
                HeaderText = "Habilitado",
                Name = "Habilitado"
            };

            var colPercedero = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EsPerecedero",
                HeaderText = "EsPerecedero",
                Name = "EsPerecedero"
            };


            // Agregar las columnas al DataGridView
            dgvProductos.Columns.Add(colId);
            dgvProductos.Columns.Add(colNombre);
            dgvProductos.Columns.Add(colPrecio);
            dgvProductos.Columns.Add(colHabilitado);
            dgvProductos.Columns.Add(colPercedero);
        }

        private void ActualizarGrilla()
        {
            dgvProductos.DataSource = null;

            // Obtener la lista de productos y proyectar los datos
            var productos = ControladoraProductos.Instance.Listar()
                .Select(p => new
                {
                    p.Id,
                    p.Nombre,
                    p.Precio,
                    p.Habilitado,
                    p.EsPerecedero
                })
                .ToList();

            dgvProductos.DataSource = productos;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var form = new FrmProducto();
            form.ShowDialog();
            ActualizarGrilla();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una línea para eliminar");
                return;
            }

            // Recorre las filas seleccionadas
            foreach (DataGridViewRow fila in dgvProductos.SelectedRows)
            {
                try
                {
                    // Obtén el ID del producto desde la columna "colId"
                    int id = Convert.ToInt32(fila.Cells["Id"].Value);

                    // Busca el producto con el ID correspondiente
                    var producto = ControladoraProductos.Instance.Listar().FirstOrDefault(p => p.Id == id);

                    if (producto != null)
                    {
                        string devolucion = (producto.EsPerecedero) ?
                            ControladoraProductoPercedero.Instance.Eliminar(producto as ProductoPercedero) :
                            ControladoraProductoNoPercedero.Instance.Eliminar(producto as ProductoNoPercedero);
                        MessageBox.Show(devolucion);
                    }
                    else
                    {
                        MessageBox.Show($"No se encontró el producto con el ID {id}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el producto: {ex.Message}");
                }
            }

            // Actualiza la grilla después de eliminar
            ActualizarGrilla();
        }

        public void ActualizarGeneralizaciones()
        {
            numHastaVencimiento.Enabled = true;
            numConsumoPreferente.Enabled = true;
            cmbTipoEnvase.Enabled = true;

            var selectedRow = dgvProductos.SelectedRows[0];
            var Producto = new Entidades.Producto
            {
                Id = Convert.ToInt32(selectedRow.Cells["Id"].Value)
            };

            bool esPercedero = (ControladoraProductos.Instance.MostrarPorId(Producto).GetType().ToString() == "Entidades.ProductoPercedero") ?
                true : false;
            // Nacho evadamos usar esto porque da error mejor usa el classname
            //bool esPercedero = Convert.ToBoolean(selectedRow.Cells["EsPerecedero"].Value);
            if (esPercedero)
            {
                ProductoPercedero prod = (ProductoPercedero)ControladoraProductos.Instance.MostrarPorId(Producto);
                if (prod == null) return;


                numConsumoPreferente.Value = prod.MesesHastaConsumoPreferente;
                numHastaVencimiento.Value = prod.MesesHastaVencimiento;

                cmbTipoEnvase.SelectedIndex = -1;
                cmbTipoEnvase.Enabled = false;
            }
            else
            {
                ProductoNoPercedero prod = (ProductoNoPercedero)ControladoraProductos.Instance.MostrarPorId(Producto);
                if (prod == null) return;

                cmbTipoEnvase.Items.Clear();
                cmbTipoEnvase.Items.Add(prod.TipoDeEnvase.ToString());
                cmbTipoEnvase.SelectedIndex = 0;

                numHastaVencimiento.Value = 0;
                numConsumoPreferente.Value = 0;
                numConsumoPreferente.Enabled = false;
                numHastaVencimiento.Enabled = false;

            }
        }
        private void MostrarStock()
        {
            var selectedRow = dgvProductos.SelectedRows[0];
            var Producto = new Entidades.Producto
            {
                Id = Convert.ToInt32(selectedRow.Cells["Id"].Value)
            };
            numStock.Value = ControladoraProductos.Instance.MostrarStock(Producto);
        }
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == 0) return;
            ActualizarGrillaProveedores();
            ActualizarGrillaCategorias();
            ActualizarGeneralizaciones();
            MostrarStock();
        }

        private void ActualizarGrillaCategorias()
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                Producto producto = new Producto
                {
                    Id = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells["Id"].Value),
                };
                dgvCategorias.DataSource = ControladoraProductos.Instance.ListarCategorias(producto);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count < 1)
            {
                MessageBox.Show("Seleccione una línea para modificar");
                return;
            }

            Producto producto = new Producto
            {
                Id = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells["Id"].Value),
                //Nombre = dgvProductos.SelectedRows[0].Cells["Nombre"].Value as String,
                //Precio = Convert.ToDouble(dgvProductos.SelectedRows[0].Cells["Precio"].Value),
                //Habilitado = Convert.ToBoolean(dgvProductos.SelectedRows[0].Cells["Habilitado"].Value),
                //EsPerecedero = Convert.ToBoolean(dgvProductos.SelectedRows[0].Cells["EsPerecedero"].Value)
            };
            foreach (Proveedor prov in ControladoraProductos.Instance.ListarProveedores(producto))
            {
                producto.AñadirProveedor(prov);
            }

            var formModificar = new FrmProducto(producto);
            formModificar.ShowDialog();
            ActualizarGrilla();
            ActualizarGrillaProveedores();
        }
        private void ActualizarGrillaProveedores()
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                Producto producto = new Producto
                {
                    Id = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells["Id"].Value),
                };
                dgvProveedores.DataSource = ControladoraProductos.Instance.ListarProveedores(producto);
            }
        }

    }
}

