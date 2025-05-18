namespace Vista
{
    partial class FrmProductos
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
            groupBox1 = new GroupBox();
            numStock = new NumericUpDown();
            label6 = new Label();
            btnModificar = new Button();
            label3 = new Label();
            dgvProveedores = new DataGridView();
            label2 = new Label();
            dgvProductos = new DataGridView();
            BtnAdd = new Button();
            BtnEliminar = new Button();
            dgvCategorias = new DataGridView();
            label1 = new Label();
            numConsumoPreferente = new NumericUpDown();
            numHastaVencimiento = new NumericUpDown();
            label8 = new Label();
            label7 = new Label();
            label9 = new Label();
            cmbTipoEnvase = new ComboBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numConsumoPreferente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHastaVencimiento).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numStock);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dgvProveedores);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dgvProductos);
            groupBox1.Controls.Add(BtnAdd);
            groupBox1.Controls.Add(BtnEliminar);
            groupBox1.Location = new Point(12, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1258, 305);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // numStock
            // 
            numStock.Enabled = false;
            numStock.Location = new Point(317, 269);
            numStock.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numStock.Name = "numStock";
            numStock.Size = new Size(120, 23);
            numStock.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(275, 271);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 12;
            label6.Text = "Stock";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(87, 263);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(675, 9);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 10;
            label3.Text = "Proveedores";
            // 
            // dgvProveedores
            // 
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(675, 22);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedores.Size = new Size(577, 235);
            dgvProveedores.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 4);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 8;
            label2.Text = "Productos";
            // 
            // dgvProductos
            // 
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvProductos.Location = new Point(6, 22);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(663, 235);
            dgvProductos.TabIndex = 3;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(6, 263);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(75, 23);
            BtnAdd.TabIndex = 0;
            BtnAdd.Text = "Añadir";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(168, 263);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(75, 23);
            BtnEliminar.TabIndex = 2;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // dgvCategorias
            // 
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvCategorias.Location = new Point(768, 333);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(250, 182);
            dgvCategorias.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(771, 315);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 7;
            label1.Text = "Categorias";
            // 
            // numConsumoPreferente
            // 
            numConsumoPreferente.Enabled = false;
            numConsumoPreferente.Location = new Point(164, 33);
            numConsumoPreferente.Name = "numConsumoPreferente";
            numConsumoPreferente.ReadOnly = true;
            numConsumoPreferente.Size = new Size(120, 23);
            numConsumoPreferente.TabIndex = 15;
            // 
            // numHastaVencimiento
            // 
            numHastaVencimiento.Enabled = false;
            numHastaVencimiento.Location = new Point(164, 68);
            numHastaVencimiento.Name = "numHastaVencimiento";
            numHastaVencimiento.ReadOnly = true;
            numHastaVencimiento.Size = new Size(120, 23);
            numHastaVencimiento.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 70);
            label8.Name = "label8";
            label8.Size = new Size(142, 15);
            label8.TabIndex = 16;
            label8.Text = "Meses Hasta Vencimiento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 35);
            label7.Name = "label7";
            label7.Size = new Size(152, 15);
            label7.TabIndex = 14;
            label7.Text = "Meses Consumo Preferente";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 35);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 18;
            label9.Text = "Tipo Envase";
            // 
            // cmbTipoEnvase
            // 
            cmbTipoEnvase.FormattingEnabled = true;
            cmbTipoEnvase.Location = new Point(81, 32);
            cmbTipoEnvase.Name = "cmbTipoEnvase";
            cmbTipoEnvase.Size = new Size(121, 23);
            cmbTipoEnvase.TabIndex = 19;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(numConsumoPreferente);
            groupBox2.Controls.Add(numHastaVencimiento);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(12, 323);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(396, 202);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Productos Percederos";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(cmbTipoEnvase);
            groupBox3.Location = new Point(414, 323);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(348, 202);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            groupBox3.Text = "Productos No Percederos";
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 616);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(dgvCategorias);
            Controls.Add(groupBox1);
            Name = "FrmProductos";
            Text = "Productos";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)numConsumoPreferente).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHastaVencimiento).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvProductos;
        private Button BtnAdd;
        private Button BtnEliminar;
        private DataGridView dgvCategorias;
        private Label label2;
        private Label label1;
        private DataGridView dgvProveedores;
        private Label label3;
        private Button btnModificar;
        private DataGridView dgvPercedero;
        private DataGridView dgvNoPercedero;
        private Label label5;
        private NumericUpDown numStock;
        private Label label6;
        private NumericUpDown numConsumoPreferente;
        private NumericUpDown numHastaVencimiento;
        private Label label8;
        private Label label7;
        private Label label9;
        private ComboBox cmbTipoEnvase;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}