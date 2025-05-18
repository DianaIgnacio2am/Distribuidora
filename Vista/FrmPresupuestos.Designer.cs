namespace Vista
{
    partial class FrmPresupuestos
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
            numtotal = new NumericUpDown();
            label3 = new Label();
            btnAceptarPresupuesto = new Button();
            label2 = new Label();
            label1 = new Label();
            dgvdetallesPresupuesto = new DataGridView();
            dgvPresupuestos = new DataGridView();
            BtnAdd = new Button();
            BtnEliminar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numtotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvdetallesPresupuesto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPresupuestos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numtotal);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnAceptarPresupuesto);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dgvdetallesPresupuesto);
            groupBox1.Controls.Add(dgvPresupuestos);
            groupBox1.Controls.Add(BtnAdd);
            groupBox1.Controls.Add(BtnEliminar);
            groupBox1.Location = new Point(12, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1229, 502);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // numtotal
            // 
            numtotal.Enabled = false;
            numtotal.InterceptArrowKeys = false;
            numtotal.Location = new Point(770, 473);
            numtotal.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            numtotal.Name = "numtotal";
            numtotal.Size = new Size(120, 23);
            numtotal.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(729, 477);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 8;
            label3.Text = "Total:";
            // 
            // btnAceptarPresupuesto
            // 
            btnAceptarPresupuesto.Location = new Point(576, 473);
            btnAceptarPresupuesto.Name = "btnAceptarPresupuesto";
            btnAceptarPresupuesto.Size = new Size(128, 23);
            btnAceptarPresupuesto.TabIndex = 7;
            btnAceptarPresupuesto.Text = "AceptarPresupuesto";
            btnAceptarPresupuesto.UseVisualStyleBackColor = true;
            btnAceptarPresupuesto.Click += btnAceptarPresupuesto_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(573, 7);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 6;
            label2.Text = "Detalles";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 5;
            label1.Text = "Presupuesto";
            // 
            // dgvdetallesPresupuesto
            // 
            dgvdetallesPresupuesto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvdetallesPresupuesto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdetallesPresupuesto.Location = new Point(573, 25);
            dgvdetallesPresupuesto.Name = "dgvdetallesPresupuesto";
            dgvdetallesPresupuesto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvdetallesPresupuesto.Size = new Size(640, 442);
            dgvdetallesPresupuesto.TabIndex = 4;
            // 
            // dgvPresupuestos
            // 
            dgvPresupuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPresupuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPresupuestos.Location = new Point(6, 22);
            dgvPresupuestos.Name = "dgvPresupuestos";
            dgvPresupuestos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPresupuestos.Size = new Size(561, 443);
            dgvPresupuestos.TabIndex = 3;
            dgvPresupuestos.CellClick += dgvPresupuestos_CellClick;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(6, 471);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(75, 23);
            BtnAdd.TabIndex = 0;
            BtnAdd.Text = "Añadir";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(87, 471);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(75, 23);
            BtnEliminar.TabIndex = 2;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // FrmPresupuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1253, 516);
            Controls.Add(groupBox1);
            Name = "FrmPresupuestos";
            Text = "PedidosDePresupuestos";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numtotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvdetallesPresupuesto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPresupuestos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvPresupuestos;
        private Button BtnAdd;
        private Button BtnEliminar;
        private DataGridView dgvdetallesPresupuesto;
        private Label label2;
        private Label label1;
        private Button btnAceptarPresupuesto;
        private NumericUpDown numtotal;
        private Label label3;
    }
}