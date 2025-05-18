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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class FrmProducto : Form
    {
        private Producto nuevoproducto = new Producto();
        private bool mod = false;
        public FrmProducto(Producto? producto = null)
        {
            InitializeComponent();
            CargarNumid();
            CargarTabla();
            cargarcombo();

            if (producto != null)
            {
                nuevoproducto = ControladoraProductos.Instance.MostrarPorId(producto);
                mod = true;
                InicializarFormulario();
            }
        }
        private void cargarcombo()
        {
            cmbEnvase.DataSource = Enum.GetValues(typeof(EnvaseTipo));
        }
        private void InicializarFormulario()
        {
            numId.Value = nuevoproducto.Id;
            nuevoproducto = ControladoraProductos.Instance.MostrarPorId(nuevoproducto);
            numId.Enabled = false;
            txtNombre.Text = nuevoproducto.Nombre;
            numPrecio.Value = (decimal)nuevoproducto.Precio;
            checkHabilitado.Checked = nuevoproducto.Habilitado;
            dgvProveedorAñadido.DataSource = nuevoproducto.proveedores.AsReadOnly();
            checkpercedero.Checked = nuevoproducto.EsPerecedero;
            checkpercedero.Enabled = false;

            if (nuevoproducto.EsPerecedero)
            {
                var Prodperc = (ProductoPercedero)nuevoproducto;
                numConsumoPreferente.Value = Prodperc.MesesHastaConsumoPreferente;
                numvencimiento.Value = Prodperc.MesesHastaVencimiento;
            }

        }

        private void CargarTabla()
        {
            dgvProveedor.DataSource = null;
            dgvProveedor.DataSource = ControladoraProductos.Instance.ListarProveedores();
            
            dgvCategoria.DataSource = null;
            dgvCategoria.DataSource = ControladoraCategorias.Instance.Listar();

            if (mod)
            {
                
                dgvProveedorAñadido.DataSource = nuevoproducto.proveedores.AsReadOnly();
                
                dgvCategoriaAñadida.DataSource = null;
                dgvCategoriaAñadida.DataSource = nuevoproducto.categorias.AsReadOnly();

            }
        }

        private void CargarNumid()
        {
            var listprod = ControladoraProductos.Instance.Listar();
            numId.Value = (listprod.Count > 0) ?
                listprod.Max(x => x.Id + 1) :
                0;
            numId.Enabled = false;
        }


        private bool ValidarDatos()
        {
            string devolucion = "";

            // Validar Nombre
            if (string.IsNullOrEmpty(txtNombre.Text)) { devolucion += "El nombre del producto no puede estar vacío.\n"; }
            if (txtNombre.Text.Length > 100) { devolucion += "El nombre del producto no puede superar los 100 caracteres.\n"; }

            // Validar Precio
            if (numPrecio.Value <= 0)
            {
                devolucion += "El precio debe ser mayor a cero.\n";
            }

            // Validar ID (Si es necesario)
            if (!mod && ControladoraProductos.Instance.Listar().Any(p => p.Id == (int)numId.Value))
            {
                devolucion += "Ya existe un producto con el mismo ID.\n";
            }

            // Validar Categoría Seleccionada (wip)
            //devolucion += "Debe seleccionar una categoría.\n";

            // Validar Tipo de Producto
            if (!checkpercedero.Checked && cmbEnvase.SelectedItem == null)
            {
                devolucion += "Debe seleccionar un tipo de envase para el producto no perecedero.\n";
            }

            if (checkpercedero.Checked) // Producto Perecedero
            {
                if (numConsumoPreferente.Value <= 0 || numvencimiento.Value <= 0)
                {
                    devolucion += "Los meses hasta consumo preferente y vencimiento deben ser mayores a cero.\n";
                }
            }

            if (devolucion == "")
            {
                return true;
            }
            else
            {
                MessageBox.Show(devolucion, "Errores de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnacept_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {

                if (checkpercedero.Checked) // Producto Perecedero
                {
                    var productoPerecedero = new ProductoPercedero
                    {

                        Nombre = txtNombre.Text,
                        Precio = (double)numPrecio.Value,
                        Habilitado = checkHabilitado.Checked,
                        MesesHastaConsumoPreferente = (int)numConsumoPreferente.Value,
                        MesesHastaVencimiento = (int)numvencimiento.Value,
                        EsPerecedero = checkpercedero.Checked
                    };

                    if (mod) productoPerecedero.Id = (int)numId.Value;

                    foreach (var proveedor in nuevoproducto.proveedores)
                    {
                        productoPerecedero.AñadirProveedor(proveedor);
                    }

                    foreach (var cat in nuevoproducto.categorias)
                    {
                        productoPerecedero.AñadirCategoria(cat);
                    }

                    string mensaje = mod
                        ? ControladoraProductoPercedero.Instance.Modificar(productoPerecedero)
                        : ControladoraProductoPercedero.Instance.Añadir(productoPerecedero);

                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // Producto No Perecedero
                {
                    var productoNoPerecedero = new ProductoNoPercedero
                    {
                        Nombre = txtNombre.Text,
                        Precio = (double)numPrecio.Value,
                        Habilitado = checkHabilitado.Checked,
                        TipoDeEnvase = (EnvaseTipo)cmbEnvase.SelectedItem,
                    };

                    if (mod) productoNoPerecedero.Id = (int)numId.Value;

                    foreach (var proveedor in nuevoproducto.proveedores)
                    {
                        productoNoPerecedero.AñadirProveedor(proveedor);
                    }
                    foreach (var cat in nuevoproducto.categorias)
                    {
                        productoNoPerecedero.AñadirCategoria(cat);
                    }

                    string mensaje = mod
                        ? ControladoraProductoNoPercedero.Instance.Modificar(productoNoPerecedero)
                        : ControladoraProductoNoPercedero.Instance.Añadir(productoNoPerecedero);

                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Close();
            }
        }

        private void btnCerrar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnaddProveedor_Click(object sender, EventArgs e)
        {
            if (dgvProveedor.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow selectedRow in dgvProveedor.SelectedRows)
                {
                    Proveedor proveedor = (Proveedor)selectedRow.DataBoundItem;
                    var checkcolicion = nuevoproducto.proveedores.Contains(proveedor);
                    if (checkcolicion)
                    {
                        MessageBox.Show("El proveedor ya fue cargado");
                        return;
                    }
                    nuevoproducto.AñadirProveedor(proveedor);
                    dgvProveedorAñadido.DataSource = null;
                    dgvProveedorAñadido.DataSource = nuevoproducto.proveedores.AsReadOnly();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para añadir Proveedor al producto.");
            }
        }


        private void btnrmProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProveedorAñadido.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow selectedRow in dgvProveedorAñadido.SelectedRows)
                    {
                        Proveedor proveedor = (Proveedor)selectedRow.DataBoundItem;
                        nuevoproducto.EliminarProveedor(proveedor);
                        dgvProveedorAñadido.DataSource = null;
                        dgvProveedorAñadido.DataSource = nuevoproducto.proveedores.AsReadOnly();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una fila para eliminar Proveedor del producto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnaddCategoria_Click(object sender, EventArgs e)
        {
            if (dgvCategoria.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow selectedRow in dgvCategoria.SelectedRows)
                {
                    var cat = (Categoria)selectedRow.DataBoundItem;
                    var checkcolicion = nuevoproducto.categorias.Contains(cat);
                    if (checkcolicion)
                    {
                        MessageBox.Show("La Categoria ya fue cargada");
                        return;
                    }
                    nuevoproducto.AñadirCategoria(cat);
                    dgvCategoriaAñadida.DataSource = null;
                    dgvCategoriaAñadida.DataSource = nuevoproducto.categorias.AsReadOnly();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para añadir Categoria al producto.");
            }
        }

        private void checkpercedero_CheckedChanged(object sender, EventArgs e)
        {
            bool esPerecedero = checkpercedero.Checked;

            numConsumoPreferente.Enabled = esPerecedero;
            numvencimiento.Enabled = esPerecedero;
            cmbEnvase.Enabled = !esPerecedero;
        }

        private void btnrmCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCategoriaAñadida.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow selectedRow in dgvCategoriaAñadida.SelectedRows)
                    {
                        var cat = (Categoria)selectedRow.DataBoundItem;
                        nuevoproducto.EliminarCategoria(cat);
                        dgvCategoriaAñadida.DataSource = null;
                        dgvCategoriaAñadida.DataSource = nuevoproducto.categorias.AsReadOnly();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una fila para eliminar Categoria del producto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
