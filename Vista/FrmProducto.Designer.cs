namespace Vista
{
    partial class FrmProducto
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
            numId = new NumericUpDown();
            txtNombre = new TextBox();
            numPrecio = new NumericUpDown();
            checkHabilitado = new CheckBox();
            btnacept = new Button();
            btncancel = new Button();
            label6 = new Label();
            label7 = new Label();
            dgvProveedorAñadido = new DataGridView();
            dgvProveedor = new DataGridView();
            btnaddProveedor = new Button();
            btnrmProveedor = new Button();
            checkpercedero = new CheckBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            numConsumoPreferente = new NumericUpDown();
            numvencimiento = new NumericUpDown();
            cmbEnvase = new ComboBox();
            dgvCategoria = new DataGridView();
            label11 = new Label();
            dgvCategoriaAñadida = new DataGridView();
            btnaddCategoria = new Button();
            btnrmCategoria = new Button();
            ((System.ComponentModel.ISupportInitialize)numId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProveedorAñadido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numConsumoPreferente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numvencimiento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategoriaAñadida).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 20);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 48);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 80);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 111);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 3;
            label4.Text = "Habilitado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(373, 9);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 4;
            label5.Text = "Categoria";
            // 
            // numId
            // 
            numId.Location = new Point(70, 12);
            numId.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            numId.Name = "numId";
            numId.Size = new Size(120, 23);
            numId.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(71, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(120, 23);
            txtNombre.TabIndex = 6;
            // 
            // numPrecio
            // 
            numPrecio.Location = new Point(71, 72);
            numPrecio.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new Size(120, 23);
            numPrecio.TabIndex = 7;
            // 
            // checkHabilitado
            // 
            checkHabilitado.AutoSize = true;
            checkHabilitado.Checked = true;
            checkHabilitado.CheckState = CheckState.Checked;
            checkHabilitado.Location = new Point(71, 112);
            checkHabilitado.Name = "checkHabilitado";
            checkHabilitado.Size = new Size(15, 14);
            checkHabilitado.TabIndex = 8;
            checkHabilitado.UseVisualStyleBackColor = true;
            // 
            // btnacept
            // 
            btnacept.Location = new Point(14, 475);
            btnacept.Name = "btnacept";
            btnacept.Size = new Size(72, 30);
            btnacept.TabIndex = 10;
            btnacept.Text = "Aceptar";
            btnacept.UseVisualStyleBackColor = true;
            btnacept.Click += btnacept_Click;
            // 
            // btncancel
            // 
            btncancel.Location = new Point(92, 475);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(69, 30);
            btncancel.TabIndex = 11;
            btncancel.Text = "Cancelar";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btnCerrar;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(679, 275);
            label6.Name = "label6";
            label6.Size = new Size(123, 15);
            label6.TabIndex = 12;
            label6.Text = "Proveedores añadidos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(679, 9);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 13;
            label7.Text = "Proveedores";
            // 
            // dgvProveedorAñadido
            // 
            dgvProveedorAñadido.AllowUserToAddRows = false;
            dgvProveedorAñadido.AllowUserToDeleteRows = false;
            dgvProveedorAñadido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedorAñadido.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvProveedorAñadido.Location = new Point(679, 293);
            dgvProveedorAñadido.Name = "dgvProveedorAñadido";
            dgvProveedorAñadido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedorAñadido.Size = new Size(510, 212);
            dgvProveedorAñadido.TabIndex = 14;
            // 
            // dgvProveedor
            // 
            dgvProveedor.AllowUserToAddRows = false;
            dgvProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedor.Location = new Point(679, 30);
            dgvProveedor.Name = "dgvProveedor";
            dgvProveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedor.Size = new Size(510, 215);
            dgvProveedor.TabIndex = 15;
            // 
            // btnaddProveedor
            // 
            btnaddProveedor.Location = new Point(679, 251);
            btnaddProveedor.Name = "btnaddProveedor";
            btnaddProveedor.Size = new Size(72, 21);
            btnaddProveedor.TabIndex = 16;
            btnaddProveedor.Text = "Añadir";
            btnaddProveedor.UseVisualStyleBackColor = true;
            btnaddProveedor.Click += btnaddProveedor_Click;
            // 
            // btnrmProveedor
            // 
            btnrmProveedor.Location = new Point(757, 251);
            btnrmProveedor.Name = "btnrmProveedor";
            btnrmProveedor.Size = new Size(72, 21);
            btnrmProveedor.TabIndex = 17;
            btnrmProveedor.Text = "Eliminar";
            btnrmProveedor.UseVisualStyleBackColor = true;
            btnrmProveedor.Click += btnrmProveedor_Click;
            // 
            // checkpercedero
            // 
            checkpercedero.AutoSize = true;
            checkpercedero.Location = new Point(14, 196);
            checkpercedero.Name = "checkpercedero";
            checkpercedero.Size = new Size(79, 19);
            checkpercedero.TabIndex = 18;
            checkpercedero.Text = "Percedero";
            checkpercedero.UseVisualStyleBackColor = true;
            checkpercedero.CheckedChanged += checkpercedero_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 218);
            label8.Name = "label8";
            label8.Size = new Size(185, 15);
            label8.TabIndex = 20;
            label8.Text = "Meses Hasta Consumo Preferente";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(128, 277);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 21;
            label9.Text = "Tipo Envase";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(55, 247);
            label10.Name = "label10";
            label10.Size = new Size(142, 15);
            label10.TabIndex = 22;
            label10.Text = "Meses Hasta Vencimiento";
            // 
            // numConsumoPreferente
            // 
            numConsumoPreferente.Enabled = false;
            numConsumoPreferente.Location = new Point(217, 210);
            numConsumoPreferente.Name = "numConsumoPreferente";
            numConsumoPreferente.Size = new Size(120, 23);
            numConsumoPreferente.TabIndex = 23;
            // 
            // numvencimiento
            // 
            numvencimiento.Enabled = false;
            numvencimiento.Location = new Point(216, 240);
            numvencimiento.Name = "numvencimiento";
            numvencimiento.Size = new Size(120, 23);
            numvencimiento.TabIndex = 24;
            // 
            // cmbEnvase
            // 
            cmbEnvase.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEnvase.FormattingEnabled = true;
            cmbEnvase.Location = new Point(215, 269);
            cmbEnvase.Name = "cmbEnvase";
            cmbEnvase.Size = new Size(121, 23);
            cmbEnvase.TabIndex = 25;
            // 
            // dgvCategoria
            // 
            dgvCategoria.AllowUserToAddRows = false;
            dgvCategoria.AllowUserToDeleteRows = false;
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvCategoria.Location = new Point(373, 30);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategoria.Size = new Size(300, 215);
            dgvCategoria.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(373, 275);
            label11.Name = "label11";
            label11.Size = new Size(108, 15);
            label11.TabIndex = 27;
            label11.Text = "Categoria Añadida ";
            // 
            // dgvCategoriaAñadida
            // 
            dgvCategoriaAñadida.AllowUserToAddRows = false;
            dgvCategoriaAñadida.AllowUserToDeleteRows = false;
            dgvCategoriaAñadida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoriaAñadida.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvCategoriaAñadida.Location = new Point(373, 293);
            dgvCategoriaAñadida.Name = "dgvCategoriaAñadida";
            dgvCategoriaAñadida.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategoriaAñadida.Size = new Size(300, 212);
            dgvCategoriaAñadida.TabIndex = 28;
            // 
            // btnaddCategoria
            // 
            btnaddCategoria.Location = new Point(373, 251);
            btnaddCategoria.Name = "btnaddCategoria";
            btnaddCategoria.Size = new Size(72, 21);
            btnaddCategoria.TabIndex = 29;
            btnaddCategoria.Text = "Añadir";
            btnaddCategoria.UseVisualStyleBackColor = true;
            btnaddCategoria.Click += btnaddCategoria_Click;
            // 
            // btnrmCategoria
            // 
            btnrmCategoria.Location = new Point(451, 251);
            btnrmCategoria.Name = "btnrmCategoria";
            btnrmCategoria.Size = new Size(72, 21);
            btnrmCategoria.TabIndex = 30;
            btnrmCategoria.Text = "Eliminar";
            btnrmCategoria.UseVisualStyleBackColor = true;
            btnrmCategoria.Click += btnrmCategoria_Click;
            // 
            // FrmProducto
            // 
            AcceptButton = btnacept;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btncancel;
            ClientSize = new Size(1239, 517);
            Controls.Add(btnrmCategoria);
            Controls.Add(btnaddCategoria);
            Controls.Add(dgvCategoriaAñadida);
            Controls.Add(label11);
            Controls.Add(dgvCategoria);
            Controls.Add(cmbEnvase);
            Controls.Add(numvencimiento);
            Controls.Add(numConsumoPreferente);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(checkpercedero);
            Controls.Add(btnrmProveedor);
            Controls.Add(btnaddProveedor);
            Controls.Add(dgvProveedor);
            Controls.Add(dgvProveedorAñadido);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btncancel);
            Controls.Add(btnacept);
            Controls.Add(checkHabilitado);
            Controls.Add(numPrecio);
            Controls.Add(txtNombre);
            Controls.Add(numId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmProducto";
            Text = "Producto";
            ((System.ComponentModel.ISupportInitialize)numId).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProveedorAñadido).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).EndInit();
            ((System.ComponentModel.ISupportInitialize)numConsumoPreferente).EndInit();
            ((System.ComponentModel.ISupportInitialize)numvencimiento).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategoriaAñadida).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown numId;
        private TextBox txtNombre;
        private NumericUpDown numPrecio;
        private CheckBox checkHabilitado;
        private Button btnacept;
        private Button btncancel;
        private Label label6;
        private Label label7;
        private DataGridView dgvProveedorAñadido;
        private DataGridView dgvProveedor;
        private Button btnaddProveedor;
        private Button btnrmProveedor;
        private CheckBox checkpercedero;
        private Label label8;
        private Label label9;
        private Label label10;
        private NumericUpDown numConsumoPreferente;
        private NumericUpDown numvencimiento;
        private ComboBox cmbEnvase;
        private DataGridView dgvCategoria;
        private Label label11;
        private DataGridView dgvCategoriaAñadida;
        private Button btnaddCategoria;
        private Button btnrmCategoria;
    }
}