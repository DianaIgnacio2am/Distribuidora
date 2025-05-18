using Controladora;
using Informes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmInforme : Form
    {
        public FrmInforme()
        {
            InitializeComponent();

            ConfigEmail config = ControladoraInformes.Instance.RecuperarConfig();
            CargaDatos(config);
        }

        private void CargaDatos(ConfigEmail ce)
        {
            txtEmailAddr.Text = ce.EmailAddr;
            txtEmailPass.Text = ce.EmailPass;

            dgvEmailTarget.DataSource = null;
            dgvEmailTarget.Columns.Add("EmailTarget", "EmailTarget");

            // Agregar los datos al DataGridView
            foreach (var str in ce.EmailTarget)
            {
                dgvEmailTarget.Rows.Add(str);
            }
            checkinfome.Checked = ce.Informar;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<string> emailTarget = new List<string>();

            foreach (DataGridViewRow row in dgvEmailTarget.Rows)
            {
                if (row.Cells["EmailTarget"].Value != null)
                {
                    emailTarget.Add(row.Cells["EmailTarget"].Value.ToString());
                }
            }

            ConfigEmail config = new ConfigEmail
            {
                EmailAddr = txtEmailAddr.Text,
                EmailPass = txtEmailPass.Text,
                EmailTarget = emailTarget,
                Informar = checkinfome.Checked

            };

            ControladoraInformes.Instance.GuardarConfig(config);

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            List<string> emailTarget = new List<string>();
            emailTarget.Add(txtEmailTargetAdd.Text);
            foreach (DataGridViewRow row in dgvEmailTarget.Rows)
            {
                if (row.Cells["EmailTarget"].Value != null)
                {
                    emailTarget.Add(row.Cells["EmailTarget"].Value.ToString());
                }
            }

            // Agregar los datos al DataGridView
            dgvEmailTarget.Rows.Add(txtEmailTargetAdd.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmailTarget.SelectedRows.Count > 0)
                {
                    // Elimina la fila seleccionada
                    dgvEmailTarget.Rows.RemoveAt(dgvEmailTarget.SelectedRows[0].Index);
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una fila para eliminar EmailTarget.");
                }
            }
            catch (Exception) { throw; }
        }
    }
}
