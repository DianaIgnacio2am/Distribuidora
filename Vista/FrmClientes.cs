using Entidades;
using Controladora;

namespace Vista
{
    public partial class FrmClientes : Form
    {
        Cliente cliente;
        public FrmClientes()
        {
            InitializeComponent();
            ActualizarGrilla();
        }
        private void ActualizarGrilla()
        {

            dgvCliente.DataSource = null;
            dgvCliente.DataSource = ControladoraClientes.Instance.Listar();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            var form = new FrmCliente();
            form.ShowDialog();
            ActualizarGrilla();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count < 1)
            {
                MessageBox.Show("Seleccione una linea para modificar");
                return;
            }

            Cliente cliente = new Cliente()
            {
                Nombre = dgvCliente.SelectedRows[0].Cells["Nombre"].Value.ToString(),
                Cuit = (Int64)dgvCliente.SelectedRows[0].Cells["Cuit"].Value,
                Apellido = dgvCliente.SelectedRows[0].Cells["Apellido"].Value.ToString(),
                Direccion = dgvCliente.SelectedRows[0].Cells["Direccion"].Value.ToString(),
                Correo = dgvCliente.SelectedRows[0].Cells["Correo"].Value.ToString(),
            };

            var formModificar = new FrmCliente(cliente);
            formModificar.ShowDialog();
            ActualizarGrilla();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count < 0)
            {
                MessageBox.Show("Seleccione una linea para eliminar");
                return;
            }

            foreach (DataGridViewRow Fila in dgvCliente.SelectedRows)
            {  // itera por un loop y elimina las lineas seleccionadas 1 a la vez. 
                string devolucion = ControladoraClientes.Instance.Eliminar(long.Parse(Fila.Cells["Cuit"].Value.ToString()));
                MessageBox.Show(devolucion);
                ActualizarGrilla();
            }
        }


    }
}
