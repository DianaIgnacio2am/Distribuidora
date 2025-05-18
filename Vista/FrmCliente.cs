using Entidades;
using Controladora;

namespace Vista
{
    public partial class FrmCliente : Form
    {
        Cliente cliente;
        public FrmCliente(Cliente? cliente = null)
        {
            InitializeComponent();
            if (cliente != null)
            {
                this.cliente = cliente;
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
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtDireccion.Text = cliente.Direccion;
            txtCorreo.Text = cliente.Correo;
            numCuit.Value = cliente.Cuit;
            numCuit.ReadOnly = true;


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
            if (string.IsNullOrEmpty(txtNombre.Text)) devolucion += "el nombre no puede ser nulo o vacio\n";
            if (txtNombre.Text.Length > 50) devolucion += "El nombre no puede superar los 50 chars\n";
            if (string.IsNullOrEmpty(txtApellido.Text)) devolucion += "El Apellido no puede ser nulo o vacio\n";
            if (string.IsNullOrEmpty(txtCorreo.Text)) devolucion += "El Correo no puede ser nulo o vacio\n";
            else if (!txtCorreo.Text.Contains("@"))
            {
                devolucion += "El correo debe contener '@'\n";
            }


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
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            string msg;
            if (ValidarDatos())
            {
                if (cliente == null)
                {
                    cliente = new Cliente
                    {
                        Nombre = txtNombre.Text,
                        Cuit = long.Parse(numCuit.Value.ToString()),
                        Direccion = txtDireccion.Text,
                        Apellido = txtApellido.Text,
                        Correo = txtCorreo.Text,
                        Habilitado = true

                    };

                    msg = ControladoraClientes.Instance.Añadir(cliente);
                }
                else
                {
                    cliente.Apellido = txtApellido.Text;
                    cliente.Nombre = txtNombre.Text;
                    cliente.Direccion = txtDireccion.Text;
                    cliente.Correo = txtCorreo.Text;
                    cliente.Cuit = long.Parse(numCuit.Text.ToString());
                    msg = ControladoraClientes.Instance.Modificar(cliente);
                }
                MessageBox.Show(msg, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}
