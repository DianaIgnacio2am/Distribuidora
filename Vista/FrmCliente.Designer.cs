
namespace Vista
{
    partial class FrmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDireccion = new TextBox();
            txtCorreo = new TextBox();
            BtnAceptar = new Button();
            BtnCancelar = new Button();
            numCuit = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numCuit).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 29);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Cuit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 59);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 88);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 117);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 146);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 4;
            label5.Text = "Correo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(92, 51);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(173, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(91, 80);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(174, 23);
            txtApellido.TabIndex = 7;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(92, 109);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(173, 23);
            txtDireccion.TabIndex = 8;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(91, 138);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(174, 23);
            txtCorreo.TabIndex = 9;
            // 
            // BtnAceptar
            // 
            BtnAceptar.Location = new Point(29, 190);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(75, 23);
            BtnAceptar.TabIndex = 10;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = true;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(190, 190);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 23);
            BtnCancelar.TabIndex = 11;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // numCuit
            // 
            numCuit.Location = new Point(92, 22);
            numCuit.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            numCuit.Name = "numCuit";
            numCuit.Size = new Size(173, 23);
            numCuit.TabIndex = 12;
            // 
            // FrmCliente
            // 
            AcceptButton = BtnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnCancelar;
            ClientSize = new Size(304, 245);
            ControlBox = false;
            Controls.Add(numCuit);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnAceptar);
            Controls.Add(txtCorreo);
            Controls.Add(txtDireccion);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCliente";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numCuit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDireccion;
        private TextBox txtCorreo;
        private Button BtnAceptar;
        private Button BtnCancelar;
        private NumericUpDown numCuit;

        public EventHandler button1_Click_1 { get; private set; }
    }
}