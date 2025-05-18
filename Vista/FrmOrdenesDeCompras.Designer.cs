namespace Vista
{
    partial class FrmOrdenesDeCompras
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
            label2 = new Label();
            label1 = new Label();
            dgvDetalles = new DataGridView();
            dgvOrdenDeCompra = new DataGridView();
            BtnAdd = new Button();
            BtnEliminar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenDeCompra).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(BtnEliminar);
            groupBox1.Controls.Add(BtnAdd);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dgvDetalles);
            groupBox1.Controls.Add(dgvOrdenDeCompra);
            groupBox1.Location = new Point(12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1244, 500);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 4);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 6;
            label2.Text = "Orden de Compra";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(484, 4);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 5;
            label1.Text = "Detalles";
            // 
            // dgvDetalles
            // 
            dgvDetalles.AllowUserToAddRows = false;
            dgvDetalles.AllowUserToDeleteRows = false;
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvDetalles.Location = new Point(484, 22);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalles.Size = new Size(754, 472);
            dgvDetalles.TabIndex = 4;
            // 
            // dgvOrdenDeCompra
            // 
            dgvOrdenDeCompra.AllowUserToAddRows = false;
            dgvOrdenDeCompra.AllowUserToDeleteRows = false;
            dgvOrdenDeCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvOrdenDeCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenDeCompra.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvOrdenDeCompra.Location = new Point(6, 22);
            dgvOrdenDeCompra.Name = "dgvOrdenDeCompra";
            dgvOrdenDeCompra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrdenDeCompra.Size = new Size(472, 449);
            dgvOrdenDeCompra.TabIndex = 3;
            dgvOrdenDeCompra.CellClick += dgvOrdenDeCompra_CellClick;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(6, 477);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(75, 23);
            BtnAdd.TabIndex = 0;
            BtnAdd.Text = "Añadir";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(87, 477);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(75, 23);
            BtnEliminar.TabIndex = 2;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // FrmOrdenesDeCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 515);
            Controls.Add(groupBox1);
            Name = "FrmOrdenesDeCompras";
            Text = "OrdenDeCompra";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenDeCompra).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvOrdenDeCompra;
        private Button BtnAdd;
        private Button BtnEliminar;
        private Label label2;
        private Label label1;
        private DataGridView dgvDetalles;
    }
}