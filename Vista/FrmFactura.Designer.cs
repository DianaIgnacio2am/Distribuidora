namespace Vista
{
    partial class FrmFactura
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
            btnAceptar = new Button();
            btnCancelar = new Button();
            numid = new NumericUpDown();
            label1 = new Label();
            numtotal = new NumericUpDown();
            label2 = new Label();
            datepick = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            dgvProductos = new DataGridView();
            dgvDetalles = new DataGridView();
            numCantidad = new NumericUpDown();
            Unidades = new Label();
            btnAddDetalle = new Button();
            label5 = new Label();
            label6 = new Label();
            btnEliminar = new Button();
            dgvClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numtotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(10, 380);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(82, 26);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1174, 380);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 26);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCerrar_Click;
            // 
            // numid
            // 
            numid.Location = new Point(37, 351);
            numid.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            numid.Name = "numid";
            numid.Size = new Size(120, 23);
            numid.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 353);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 3;
            label1.Text = "ID";
            // 
            // numtotal
            // 
            numtotal.DecimalPlaces = 2;
            numtotal.Enabled = false;
            numtotal.Location = new Point(202, 351);
            numtotal.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            numtotal.Name = "numtotal";
            numtotal.ReadOnly = true;
            numtotal.Size = new Size(120, 23);
            numtotal.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 355);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 5;
            label2.Text = "Total";
            // 
            // datepick
            // 
            datepick.Location = new Point(378, 353);
            datepick.Name = "datepick";
            datepick.Size = new Size(120, 23);
            datepick.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(334, 357);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 7;
            label3.Text = "Fecha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 6);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 8;
            label4.Text = "Cliente";
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvProductos.Location = new Point(428, 27);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(413, 318);
            dgvProductos.TabIndex = 11;
            // 
            // dgvDetalles
            // 
            dgvDetalles.AllowUserToAddRows = false;
            dgvDetalles.AllowUserToDeleteRows = false;
            dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvDetalles.Location = new Point(847, 27);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalles.Size = new Size(407, 318);
            dgvDetalles.TabIndex = 12;
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(586, 355);
            numCantidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(120, 23);
            numCantidad.TabIndex = 13;
            // 
            // Unidades
            // 
            Unidades.AutoSize = true;
            Unidades.Location = new Point(512, 363);
            Unidades.Name = "Unidades";
            Unidades.Size = new Size(56, 15);
            Unidades.TabIndex = 14;
            Unidades.Text = "Unidades";
            // 
            // btnAddDetalle
            // 
            btnAddDetalle.Location = new Point(716, 351);
            btnAddDetalle.Name = "btnAddDetalle";
            btnAddDetalle.Size = new Size(80, 31);
            btnAddDetalle.TabIndex = 15;
            btnAddDetalle.Text = "Añadir";
            btnAddDetalle.UseVisualStyleBackColor = true;
            btnAddDetalle.Click += btnAddDetalle_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(847, 6);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 16;
            label5.Text = "Detalles";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(428, 9);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 17;
            label6.Text = "Productos";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(802, 351);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(80, 31);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvClientes.Location = new Point(10, 27);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(412, 318);
            dgvClientes.TabIndex = 19;
            // 
            // FrmFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 413);
            Controls.Add(dgvClientes);
            Controls.Add(btnEliminar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnAddDetalle);
            Controls.Add(Unidades);
            Controls.Add(numCantidad);
            Controls.Add(dgvDetalles);
            Controls.Add(dgvProductos);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(datepick);
            Controls.Add(label2);
            Controls.Add(numtotal);
            Controls.Add(label1);
            Controls.Add(numid);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "FrmFactura";
            Text = "Agregar Factura";
            ((System.ComponentModel.ISupportInitialize)numid).EndInit();
            ((System.ComponentModel.ISupportInitialize)numtotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        private NumericUpDown numid;
        private Label label1;
        private NumericUpDown numtotal;
        private Label label2;
        private DateTimePicker datepick;
        private Label label3;
        private Label label4;
        private DataGridView dgvProductos;
        private DataGridView dgvDetalles;
        private NumericUpDown numCantidad;
        private Label Unidades;
        private Button btnAddDetalle;
        private Label label5;
        private Label label6;
        private Button btnEliminar;
        private DataGridView dgvClientes;
    }
}