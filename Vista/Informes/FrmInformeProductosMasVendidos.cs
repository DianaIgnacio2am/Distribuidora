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

namespace Vista.Informes
{
    public partial class FrmInformeProductosMasVendidos : Form
    {
        public FrmInformeProductosMasVendidos()
        {
            InitializeComponent();
            IniciarTabla();
        }

        private void IniciarTabla()
        {
            dgvProductos.DataSource = ControladoraInformes.Instance.MostrarProductosMasVendidos();
        }
    }
}
