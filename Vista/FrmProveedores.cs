using Entidades;
using Controladora;

namespace Vista
{

    public partial class FrmProveedores : Form
    {

        public FrmProveedores()
        {

            InitializeComponent();
            ActualizarGrilla();
        }
        private void ActualizarGrilla()
        {

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ControladoraProveedores.Instance.Listar();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var form = new FrmProveedor();
            form.ShowDialog();
            ActualizarGrilla();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Seleccione una linea para modificar");
                return;
            }

            Proveedor proveedor = new Proveedor()
            {
                Nombre = dataGridView1.SelectedRows[0].Cells["Nombre"].Value.ToString(),
                Cuit = (Int64)dataGridView1.SelectedRows[0].Cells["Cuit"].Value,
                RazonSocial = dataGridView1.SelectedRows[0].Cells["RazonSocial"].Value.ToString(),
                Direccion = dataGridView1.SelectedRows[0].Cells["Direccion"].Value.ToString(),
                Habilitado = bool.Parse(dataGridView1.SelectedRows[0].Cells["Habilitado"].Value.ToString())
            };

            var formModificar = new FrmProveedor(proveedor);
            formModificar.ShowDialog();
            ActualizarGrilla();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 0)
            {
                MessageBox.Show("Seleccione una linea para eliminar");
                return;
            }

            foreach (DataGridViewRow Fila in dataGridView1.SelectedRows)
            {  // itera por un loop y elimina las lineas seleccionadas 1 a la vez. 
                string devolucion = ControladoraProveedores.Instance.Eliminar(Int64.Parse(Fila.Cells["Cuit"].Value.ToString()));
                MessageBox.Show(devolucion);
                ActualizarGrilla();
            }
        }
    }
}
