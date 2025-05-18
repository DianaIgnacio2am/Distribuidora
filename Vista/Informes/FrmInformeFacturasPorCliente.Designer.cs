namespace Vista.Informes
{
    partial class FrmInformeFacturasPorCliente
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
            btnEnviarEmail = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvDetalle = new DataGridView();
            dgvFactura = new DataGridView();
            dateFin = new DateTimePicker();
            dateInicio = new DateTimePicker();
            btnBusqueda = new Button();
            dgvCliente = new DataGridView();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            SuspendLayout();
            // 
            // btnEnviarEmail
            // 
            btnEnviarEmail.Location = new Point(20, 470);
            btnEnviarEmail.Name = "btnEnviarEmail";
            btnEnviarEmail.Size = new Size(239, 26);
            btnEnviarEmail.TabIndex = 19;
            btnEnviarEmail.Text = "Enviar Informe Por Email";
            btnEnviarEmail.UseVisualStyleBackColor = true;
            btnEnviarEmail.Click += btnEnviarEmail_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 59);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 18;
            label4.Text = "Fecha Fin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 11);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 17;
            label3.Text = "Fecha Inicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(757, 11);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 16;
            label2.Text = "DetallesFactura";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(265, 11);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 15;
            label1.Text = "Facturas";
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AllowUserToDeleteRows = false;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvDetalle.Location = new Point(757, 29);
            dgvDetalle.MultiSelect = false;
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.RowHeadersVisible = false;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(480, 469);
            dgvDetalle.TabIndex = 14;
            // 
            // dgvFactura
            // 
            dgvFactura.AllowUserToAddRows = false;
            dgvFactura.AllowUserToDeleteRows = false;
            dgvFactura.AllowUserToResizeColumns = false;
            dgvFactura.AllowUserToResizeRows = false;
            dgvFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFactura.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvFactura.Location = new Point(265, 29);
            dgvFactura.MultiSelect = false;
            dgvFactura.Name = "dgvFactura";
            dgvFactura.RowHeadersVisible = false;
            dgvFactura.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFactura.Size = new Size(475, 469);
            dgvFactura.TabIndex = 13;
            dgvFactura.CellClick += dgvFactura_CellClick;
            // 
            // dateFin
            // 
            dateFin.Location = new Point(20, 77);
            dateFin.Name = "dateFin";
            dateFin.Size = new Size(239, 23);
            dateFin.TabIndex = 12;
            // 
            // dateInicio
            // 
            dateInicio.Location = new Point(20, 29);
            dateInicio.Name = "dateInicio";
            dateInicio.Size = new Size(239, 23);
            dateInicio.TabIndex = 11;
            // 
            // btnBusqueda
            // 
            btnBusqueda.Location = new Point(20, 438);
            btnBusqueda.Name = "btnBusqueda";
            btnBusqueda.Size = new Size(239, 26);
            btnBusqueda.TabIndex = 10;
            btnBusqueda.Text = "Hacer Busqueda";
            btnBusqueda.UseVisualStyleBackColor = true;
            btnBusqueda.Click += btnBusqueda_Click;
            // 
            // dgvCliente
            // 
            dgvCliente.AllowUserToAddRows = false;
            dgvCliente.AllowUserToDeleteRows = false;
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvCliente.Location = new Point(20, 126);
            dgvCliente.MultiSelect = false;
            dgvCliente.Name = "dgvCliente";
            dgvCliente.RowHeadersVisible = false;
            dgvCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCliente.Size = new Size(239, 306);
            dgvCliente.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 108);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 21;
            label5.Text = "Clientes";
            // 
            // FrmInformeFacturasPorCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 508);
            Controls.Add(label5);
            Controls.Add(dgvCliente);
            Controls.Add(btnEnviarEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvDetalle);
            Controls.Add(dgvFactura);
            Controls.Add(dateFin);
            Controls.Add(dateInicio);
            Controls.Add(btnBusqueda);
            Name = "FrmInformeFacturasPorCliente";
            Text = "Informe: Clientes";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnviarEmail;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvDetalle;
        private DataGridView dgvFactura;
        private DateTimePicker dateFin;
        private DateTimePicker dateInicio;
        private Button btnBusqueda;
        private DataGridView dgvCliente;
        private Label label5;
    }
}