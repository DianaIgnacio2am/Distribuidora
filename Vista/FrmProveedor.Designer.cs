namespace Vista
{
    partial class FrmProveedor
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
            BtnAceptar = new Button();
            txtNombre = new TextBox();
            txtDireccion = new TextBox();
            txtSocial = new TextBox();
            numCuit = new NumericUpDown();
            Nombre = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            checkBoxHabilitado = new CheckBox();
            label4 = new Label();
            BtnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numCuit).BeginInit();
            SuspendLayout();
            // 
            // BtnAceptar
            // 
            BtnAceptar.Location = new Point(19, 195);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(75, 23);
            BtnAceptar.TabIndex = 0;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = true;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(110, 19);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(110, 53);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 23);
            txtDireccion.TabIndex = 2;
            // 
            // txtSocial
            // 
            txtSocial.Location = new Point(110, 88);
            txtSocial.Name = "txtSocial";
            txtSocial.Size = new Size(100, 23);
            txtSocial.TabIndex = 3;
            // 
            // numCuit
            // 
            numCuit.Location = new Point(110, 117);
            numCuit.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            numCuit.Name = "numCuit";
            numCuit.Size = new Size(100, 23);
            numCuit.TabIndex = 4;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(24, 22);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 5;
            Nombre.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 61);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 6;
            label1.Text = "Direccion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 88);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 7;
            label2.Text = "RazonSocial";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 117);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 8;
            label3.Text = "Cuit";
            // 
            // checkBoxHabilitado
            // 
            checkBoxHabilitado.AutoSize = true;
            checkBoxHabilitado.Checked = true;
            checkBoxHabilitado.CheckState = CheckState.Checked;
            checkBoxHabilitado.Location = new Point(110, 154);
            checkBoxHabilitado.Name = "checkBoxHabilitado";
            checkBoxHabilitado.Size = new Size(15, 14);
            checkBoxHabilitado.TabIndex = 9;
            checkBoxHabilitado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 153);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 10;
            label4.Text = "Habilitado";
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(135, 195);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 23);
            BtnCancelar.TabIndex = 11;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // FrmProveedor
            // 
            AcceptButton = BtnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnCancelar;
            ClientSize = new Size(228, 230);
            Controls.Add(BtnCancelar);
            Controls.Add(label4);
            Controls.Add(checkBoxHabilitado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Nombre);
            Controls.Add(numCuit);
            Controls.Add(txtSocial);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(BtnAceptar);
            Name = "FrmProveedor";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numCuit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button BtnAceptarr;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private TextBox txtSocial;
        private NumericUpDown numCuit;
        private Label Nombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox checkBoxHabilitado;
        private Label label4;
        private Button BtnCancelar;
        private Button BtnAceptar;
    }
}