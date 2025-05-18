using Vista.Informes;

namespace Vista
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario secundario actual si hay alguno
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            var Frm = new FrmClientes();
            Frm.MdiParent = this;
            Frm.Show();

        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            var Frm = new FrmFacturas();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            var Frm = new FrmProveedores();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            var Frm = new FrmProductos();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void remitosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            var Frm = new FrmRemitos();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void ordenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            var Frm = new FrmOrdenesDeCompras();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void pedidosPresupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            var Frm = new FrmPresupuestos();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void gestionarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            var Frm = new FrmInforme();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            var Frm = new FrmCategorias();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void facturasPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            var Frm = new FrmInformeFacturaPorFecha();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void productoMasVendidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            var Frm = new FrmInformeProductosMasVendidos();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void facturasPorClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            var Frm = new FrmInformeFacturasPorCliente();
            Frm.MdiParent = this;
            Frm.Show();
        }
    }
}