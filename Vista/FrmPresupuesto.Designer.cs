namespace Vista
{
    partial class FrmPresupuesto
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
            dgvProducto = new DataGridView();
            ID = new Label();
            label2 = new Label();
            numId = new NumericUpDown();
            btnGuardar = new Button();
            btnCerrar = new Button();
            btnAddProducto = new Button();
            btnrmProducto = new Button();
            dgvProveedor = new DataGridView();
            dgvPedido = new DataGridView();
            label1 = new Label();
            label3 = new Label();
            numCantidad = new NumericUpDown();
            label4 = new Label();
            numPreciopropuesto = new NumericUpDown();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPreciopropuesto).BeginInit();
            SuspendLayout();
            // 
            // dgvProducto
            // 
            dgvProducto.AllowUserToAddRows = false;
            dgvProducto.AllowUserToDeleteRows = false;
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvProducto.Location = new Point(349, 32);
            dgvProducto.MultiSelect = false;
            dgvProducto.Name = "dgvProducto";
            dgvProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducto.Size = new Size(347, 338);
            dgvProducto.TabIndex = 1;
            dgvProducto.CellClick += dgvProducto_CellClick;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(119, 407);
            ID.Name = "ID";
            ID.Size = new Size(18, 15);
            ID.TabIndex = 2;
            ID.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 14);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 3;
            label2.Text = "Provedor";
            // 
            // numId
            // 
            numId.Location = new Point(143, 405);
            numId.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numId.Name = "numId";
            numId.Size = new Size(120, 23);
            numId.TabIndex = 8;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(14, 449);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(77, 26);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(1159, 449);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(81, 26);
            btnCerrar.TabIndex = 10;
            btnCerrar.Text = "Cancelar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnAddProducto
            // 
            btnAddProducto.Location = new Point(520, 376);
            btnAddProducto.Name = "btnAddProducto";
            btnAddProducto.Size = new Size(115, 29);
            btnAddProducto.TabIndex = 11;
            btnAddProducto.Text = "Agregar Producto";
            btnAddProducto.UseVisualStyleBackColor = true;
            btnAddProducto.Click += btnAddProducto_Click;
            // 
            // btnrmProducto
            // 
            btnrmProducto.Location = new Point(520, 411);
            btnrmProducto.Name = "btnrmProducto";
            btnrmProducto.Size = new Size(115, 29);
            btnrmProducto.TabIndex = 12;
            btnrmProducto.Text = "Eliminar Producto";
            btnrmProducto.UseVisualStyleBackColor = true;
            btnrmProducto.Click += btnrmProducto_Click;
            // 
            // dgvProveedor
            // 
            dgvProveedor.AllowUserToAddRows = false;
            dgvProveedor.AllowUserToDeleteRows = false;
            dgvProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedor.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvProveedor.Location = new Point(12, 32);
            dgvProveedor.MultiSelect = false;
            dgvProveedor.Name = "dgvProveedor";
            dgvProveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedor.Size = new Size(331, 338);
            dgvProveedor.TabIndex = 13;
            dgvProveedor.CellClick += dgvProveedor_CellClick;
            // 
            // dgvPedido
            // 
            dgvPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedido.Location = new Point(702, 32);
            dgvPedido.Name = "dgvPedido";
            dgvPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedido.Size = new Size(538, 408);
            dgvPedido.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(349, 14);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 15;
            label1.Text = "Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(702, 14);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 16;
            label3.Text = "Pedido";
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(75, 376);
            numCantidad.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(120, 23);
            numCantidad.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 378);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 18;
            label4.Text = "Cantidad";
            // 
            // numPreciopropuesto
            // 
            numPreciopropuesto.Location = new Point(298, 378);
            numPreciopropuesto.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numPreciopropuesto.Name = "numPreciopropuesto";
            numPreciopropuesto.Size = new Size(120, 23);
            numPreciopropuesto.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(202, 380);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 20;
            label5.Text = "PrecioPropuesto";
            // 
            // FrmPresupuesto
            // 
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCerrar;
            ClientSize = new Size(1252, 484);
            Controls.Add(label5);
            Controls.Add(numPreciopropuesto);
            Controls.Add(label4);
            Controls.Add(numCantidad);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dgvPedido);
            Controls.Add(dgvProveedor);
            Controls.Add(btnrmProducto);
            Controls.Add(btnAddProducto);
            Controls.Add(btnCerrar);
            Controls.Add(btnGuardar);
            Controls.Add(numId);
            Controls.Add(label2);
            Controls.Add(ID);
            Controls.Add(dgvProducto);
            Name = "FrmPresupuesto";
            Text = "Presupuesto";
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numId).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedido).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPreciopropuesto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvProducto;
        private Label ID;
        private Label label2;
        private NumericUpDown numId;
        private Button btnGuardar;
        private Button btnCerrar;
        private Button btnAddProducto;
        private Button btnrmProducto;
        private DataGridView dgvProveedor;
        private DataGridView dgvPedido;
        private Label label1;
        private Label label3;
        private NumericUpDown numCantidad;
        private Label label4;
        private NumericUpDown numPreciopropuesto;
        private Label label5;
    }
}