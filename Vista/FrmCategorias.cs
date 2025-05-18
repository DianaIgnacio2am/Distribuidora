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

namespace Vista
{
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
            RecargarTabla();
        }

        private void RecargarTabla()
        {

            dgvCategorias.DataSource =  ControladoraCategorias.Instance.Listar();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            new FrmCategoria().ShowDialog();
            RecargarTabla();
        }
    }
}
