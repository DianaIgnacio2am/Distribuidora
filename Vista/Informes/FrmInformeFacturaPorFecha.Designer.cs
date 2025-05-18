namespace Vista.Informes
{
    partial class FrmInformeFacturaPorFecha
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
            btnBuscar = new Button();
            dateInicio = new DateTimePicker();
            dateFin = new DateTimePicker();
            dgvFactura = new DataGridView();
            dgvDetalles = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnEnviarEmail = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(26, 111);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(200, 26);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Hacer Busqueda";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dateInicio
            // 
            dateInicio.Location = new Point(26, 24);
            dateInicio.Name = "dateInicio";
            dateInicio.Size = new Size(200, 23);
            dateInicio.TabIndex = 1;
            // 
            // dateFin
            // 
            dateFin.Location = new Point(26, 72);
            dateFin.Name = "dateFin";
            dateFin.Size = new Size(200, 23);
            dateFin.TabIndex = 2;
            // 
            // dgvFactura
            // 
            dgvFactura.AllowUserToAddRows = false;
            dgvFactura.AllowUserToDeleteRows = false;
            dgvFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFactura.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFactura.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvFactura.Location = new Point(271, 24);
            dgvFactura.MultiSelect = false;
            dgvFactura.Name = "dgvFactura";
            dgvFactura.RowHeadersVisible = false;
            dgvFactura.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFactura.Size = new Size(475, 469);
            dgvFactura.TabIndex = 3;
            dgvFactura.CellClick += dgvFactura_CellClick;
            // 
            // dgvDetalles
            // 
            dgvDetalles.AllowUserToAddRows = false;
            dgvDetalles.AllowUserToDeleteRows = false;
            dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvDetalles.Location = new Point(763, 24);
            dgvDetalles.MultiSelect = false;
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.RowHeadersVisible = false;
            dgvDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalles.Size = new Size(480, 469);
            dgvDetalles.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(271, 6);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 5;
            label1.Text = "Facturas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(763, 6);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 6;
            label2.Text = "DetallesFactura";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 6);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 7;
            label3.Text = "Fecha Inicio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 54);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 8;
            label4.Text = "Fecha Fin";
            // 
            // btnEnviarEmail
            // 
            btnEnviarEmail.Location = new Point(26, 143);
            btnEnviarEmail.Name = "btnEnviarEmail";
            btnEnviarEmail.Size = new Size(200, 26);
            btnEnviarEmail.TabIndex = 9;
            btnEnviarEmail.Text = "Enviar Informe Por Email";
            btnEnviarEmail.UseVisualStyleBackColor = true;
            btnEnviarEmail.Click += btnEnviarEmail_Click;
            // 
            // FrmInformeFacturaPorFecha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1255, 505);
            Controls.Add(btnEnviarEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvDetalles);
            Controls.Add(dgvFactura);
            Controls.Add(dateFin);
            Controls.Add(dateInicio);
            Controls.Add(btnBuscar);
            Name = "FrmInformeFacturaPorFecha";
            Text = "Informe: Facturas";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvFactura).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private DateTimePicker dateInicio;
        private DateTimePicker dateFin;
        private DataGridView dgvFactura;
        private DataGridView dgvDetalles;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnEnviarEmail;
    }
}