namespace Vista
{
    partial class FrmOrdenDeCompra
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
            dgvPresupuesto = new DataGridView();
            dgvDetalle = new DataGridView();
            label2 = new Label();
            numId = new NumericUpDown();
            ID = new Label();
            btnAddProducto = new Button();
            dgvOrdendeCompra = new DataGridView();
            label3 = new Label();
            btnAceptar = new Button();
            btnCerrar = new Button();
            btnrmPresupuesto = new Button();
            label4 = new Label();
            dgvProveedor = new DataGridView();
            label5 = new Label();
            numTotal = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvPresupuesto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrdendeCompra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTotal).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(474, -2);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 17;
            label1.Text = "Presupuestos";
            // 
            // dgvPresupuesto
            // 
            dgvPresupuesto.AllowUserToAddRows = false;
            dgvPresupuesto.AllowUserToDeleteRows = false;
            dgvPresupuesto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPresupuesto.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvPresupuesto.Location = new Point(478, 16);
            dgvPresupuesto.MultiSelect = false;
            dgvPresupuesto.Name = "dgvPresupuesto";
            dgvPresupuesto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPresupuesto.Size = new Size(346, 196);
            dgvPresupuesto.TabIndex = 16;
            dgvPresupuesto.CellClick += dgvPresupuesto_CellClick;
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AllowUserToDeleteRows = false;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvDetalle.Location = new Point(482, 283);
            dgvDetalle.MultiSelect = false;
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(346, 190);
            dgvDetalle.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(478, 265);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 18;
            label2.Text = "Detalle";
            // 
            // numId
            // 
            numId.Location = new Point(43, 12);
            numId.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numId.Name = "numId";
            numId.Size = new Size(120, 23);
            numId.TabIndex = 21;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(19, 14);
            ID.Name = "ID";
            ID.Size = new Size(18, 15);
            ID.TabIndex = 20;
            ID.Text = "ID";
            // 
            // btnAddProducto
            // 
            btnAddProducto.Location = new Point(478, 218);
            btnAddProducto.Name = "btnAddProducto";
            btnAddProducto.Size = new Size(144, 29);
            btnAddProducto.TabIndex = 22;
            btnAddProducto.Text = "Añadir Presupuesto";
            btnAddProducto.UseVisualStyleBackColor = true;
            btnAddProducto.Click += btnAddProducto_Click;
            // 
            // dgvOrdendeCompra
            // 
            dgvOrdendeCompra.AllowUserToAddRows = false;
            dgvOrdendeCompra.AllowUserToDeleteRows = false;
            dgvOrdendeCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdendeCompra.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvOrdendeCompra.Location = new Point(834, 16);
            dgvOrdendeCompra.Name = "dgvOrdendeCompra";
            dgvOrdendeCompra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrdendeCompra.Size = new Size(471, 457);
            dgvOrdendeCompra.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(834, -4);
            label3.Name = "label3";
            label3.Size = new Size(146, 15);
            label3.TabIndex = 24;
            label3.Text = "Detalles Orden de Compra";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(12, 492);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 25;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(1230, 479);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 26;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnrmPresupuesto
            // 
            btnrmPresupuesto.Location = new Point(680, 218);
            btnrmPresupuesto.Name = "btnrmPresupuesto";
            btnrmPresupuesto.Size = new Size(144, 29);
            btnrmPresupuesto.TabIndex = 27;
            btnrmPresupuesto.Text = "Eliminar Presupuesto";
            btnrmPresupuesto.UseVisualStyleBackColor = true;
            btnrmPresupuesto.Click += btnrmPresupuesto_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 38);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 28;
            label4.Text = "Proveedor";
            // 
            // dgvProveedor
            // 
            dgvProveedor.AllowUserToAddRows = false;
            dgvProveedor.AllowUserToDeleteRows = false;
            dgvProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedor.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvProveedor.Location = new Point(18, 56);
            dgvProveedor.MultiSelect = false;
            dgvProveedor.Name = "dgvProveedor";
            dgvProveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedor.Size = new Size(454, 430);
            dgvProveedor.TabIndex = 29;
            dgvProveedor.CellClick += dgvProveedor_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(314, 16);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 30;
            label5.Text = "Total";
            // 
            // numTotal
            // 
            numTotal.Enabled = false;
            numTotal.Location = new Point(352, 12);
            numTotal.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numTotal.Name = "numTotal";
            numTotal.Size = new Size(120, 23);
            numTotal.TabIndex = 31;
            // 
            // FrmOrdenDeCompra
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCerrar;
            ClientSize = new Size(1317, 527);
            Controls.Add(numTotal);
            Controls.Add(label5);
            Controls.Add(dgvProveedor);
            Controls.Add(label4);
            Controls.Add(btnrmPresupuesto);
            Controls.Add(btnCerrar);
            Controls.Add(btnAceptar);
            Controls.Add(label3);
            Controls.Add(dgvOrdendeCompra);
            Controls.Add(btnAddProducto);
            Controls.Add(numId);
            Controls.Add(ID);
            Controls.Add(dgvDetalle);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvPresupuesto);
            Name = "FrmOrdenDeCompra";
            Text = "OrdenDeCompra";
            ((System.ComponentModel.ISupportInitialize)dgvPresupuesto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)numId).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrdendeCompra).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTotal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvPresupuesto;
        private DataGridView dgvDetalle;
        private Label label2;
        private NumericUpDown numId;
        private Label ID;
        private Button btnAddProducto;
        private DataGridView dgvOrdendeCompra;
        private Label label3;
        private Button btnAceptar;
        private Button btnCerrar;
        private Button btnrmPresupuesto;
        private Label label4;
        private DataGridView dgvProveedor;
        private Label label5;
        private NumericUpDown numTotal;
    }
}