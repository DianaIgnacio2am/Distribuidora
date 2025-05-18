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

namespace Vista
{
    public partial class FrmRemitos : Form
    {
        public FrmRemitos()
        {
            InitializeComponent();
            ActualizarGrilla();
        }
        private void ActualizarGrilla()
        {
            dgvRemito.DataSource = null;
            dgvRemito.DataSource = ControladoraRemito.Instance.Listar();
            foreach (DataGridViewColumn column in dgvRemito.Columns)
            {
               column.Visible = column.Name == "Id" || column.Name == "NombreProveedor";
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var form = new FrmRemito();
            form.ShowDialog();
            ActualizarGrilla();
        }

        private void dgvRemito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRemito.SelectedRows.Count == 0) return;

            int ordenid = Convert.ToInt32(dgvRemito.SelectedRows[0].Cells["Id"].Value.ToString());

            var rem = new Remito { Id = ordenid };

            rem = ControladoraRemito.Instance.MostrarRemitoPorId(rem);
            dgvDetallesRemito.DataSource = null;
            dgvDetallesRemito.DataSource = rem.Lotes;
            foreach (DataGridViewColumn column in dgvDetallesRemito.Columns)
            {
                column.Visible = column.Name == "Id" || column.Name == "Fecha"
                    || column.Name == "Cantidad" || column.Name == "NombreProducto" || column.Name == "CantRecibida"; 
            }
        }
    }
}
