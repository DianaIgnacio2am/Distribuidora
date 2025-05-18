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
    public partial class FrmCategoria : Form
    {
        private Categoria? categoria;
        public FrmCategoria()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void CargarDatos()
        {
            var list = ControladoraCategorias.Instance.Listar();
            var num = (list.Count == 0) ?
                1:
                list.Max(x => x.Id + 1);

            numid.Value = num;
            numid.Enabled = false;
        }

        private bool ValidarDatos()
        {
            string devolucion = "";

            if (string.IsNullOrEmpty(textBox1.Text))
                devolucion += "La descripción no puede ser nula o vacía\n";
            else if (textBox1.Text.Length > 100) // Ajusta el límite según sea necesario
                devolucion += "La descripción no puede superar los 100 caracteres\n";

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



        private void button1_Click(object sender, EventArgs e)
        {
            string msg;
            if (ValidarDatos())
            {
                if (categoria == null)
                {
                    categoria = new Categoria
                    {
                        Descripcion = textBox1.Text
                    };

                    msg = ControladoraCategorias.Instance.Añadir(categoria);
                }
                else
                {
                    categoria.Descripcion = textBox1.Text;
                    categoria.Id = (int)numid.Value; // Solo si quieres permitir modificaciones del ID

                    msg = ControladoraCategorias.Instance.Modificar(categoria);
                }
                MessageBox.Show(msg, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}
