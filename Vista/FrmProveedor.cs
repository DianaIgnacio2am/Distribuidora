using Entidades;
using Controladora;

namespace Vista
{
    public partial class FrmProveedor : Form
    {
        Proveedor proveedor;
        public FrmProveedor(Proveedor? proveedor = null)
        {

            InitializeComponent();

            if (proveedor != null)
            {
                this.proveedor = proveedor;
                this.Text = "Modificar Proveedor";
                CargarDatos();
            }
            else
            {
                this.Text = "Agregar Proveedor";

            }

        }

        private void CargarDatos()
        {
            txtDireccion.Text = proveedor.Direccion;
            txtNombre.Text = proveedor.Nombre;
            txtSocial.Text = proveedor.RazonSocial;
            numCuit.Value = proveedor.Cuit;
            numCuit.ReadOnly = true;
            checkBoxHabilitado.Checked = proveedor.Habilitado;
        }
        private bool ValidarDatos()
        {
            string devolucion = "";

            /*
             * complicado de leer pero en estas lineas estan todas las comprobaciones 
             * que pude pensar en el momento.
             */

            if (string.IsNullOrEmpty(txtDireccion.Text)) devolucion += "La direccion no deberia ser nulo o vacio\n";
            if (txtDireccion.Text.Length > 200) devolucion += "La direccion no puede superar los 200 chars\n";
            if (string.IsNullOrEmpty(txtSocial.Text)) devolucion += "La razon social no puede ser nulo o vacio\n";
            if (txtSocial.Text.Length > 50) devolucion += "La razon social no puede superar los 50 chars\n";
            if (string.IsNullOrEmpty(txtNombre.Text)) devolucion += "El Nombre no puede ser nulo o vacio\n";
            if (numCuit.Value <= 0) { devolucion += "NO es un cuit válido"; };

            if (devolucion == "")
            {
                return true;
            }
            else
            {
                MessageBox.Show(devolucion);
                return false;
            }

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            string msg;
            if (ValidarDatos())
            {
                if (proveedor == null)
                {
                    proveedor = new Proveedor
                    {
                        Nombre = txtNombre.Text,
                        Cuit = (Int64)numCuit.Value,
                        Direccion = txtDireccion.Text,
                        RazonSocial = txtSocial.Text,
                        Habilitado = checkBoxHabilitado.Checked,
                    };
                    msg = ControladoraProveedores.Instance.Añadir(proveedor);
                }
                else
                {

                    proveedor.Nombre = txtNombre.Text;
                    proveedor.Direccion = txtDireccion.Text;
                    proveedor.RazonSocial = txtSocial.Text;
                    proveedor.Cuit = (Int64)numCuit.Value;
                    proveedor.Habilitado = checkBoxHabilitado.Checked;
                    msg = ControladoraProveedores.Instance.Modificar(proveedor);
                }
                MessageBox.Show(msg, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }


        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
