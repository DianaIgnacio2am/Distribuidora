namespace Vista
{
    partial class FrmInforme
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
            dgvEmailTarget = new DataGridView();
            txtEmailAddr = new TextBox();
            txtEmailPass = new TextBox();
            txtEmailTargetAdd = new TextBox();
            btnAñadir = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            checkinfome = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmailTarget).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Email Addr";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Email Pass";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 76);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 2;
            label3.Text = "Email Target";
            // 
            // dgvEmailTarget
            // 
            dgvEmailTarget.AllowUserToAddRows = false;
            dgvEmailTarget.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmailTarget.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvEmailTarget.EnableHeadersVisualStyles = false;
            dgvEmailTarget.Location = new Point(89, 76);
            dgvEmailTarget.Name = "dgvEmailTarget";
            dgvEmailTarget.RowTemplate.Height = 25;
            dgvEmailTarget.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmailTarget.Size = new Size(240, 150);
            dgvEmailTarget.TabIndex = 3;
            // 
            // txtEmailAddr
            // 
            txtEmailAddr.Location = new Point(89, 18);
            txtEmailAddr.Name = "txtEmailAddr";
            txtEmailAddr.Size = new Size(202, 23);
            txtEmailAddr.TabIndex = 4;
            // 
            // txtEmailPass
            // 
            txtEmailPass.Location = new Point(89, 47);
            txtEmailPass.Name = "txtEmailPass";
            txtEmailPass.PasswordChar = '*';
            txtEmailPass.Size = new Size(202, 23);
            txtEmailPass.TabIndex = 5;
            // 
            // txtEmailTargetAdd
            // 
            txtEmailTargetAdd.Location = new Point(335, 76);
            txtEmailTargetAdd.Name = "txtEmailTargetAdd";
            txtEmailTargetAdd.Size = new Size(197, 23);
            txtEmailTargetAdd.TabIndex = 6;
            // 
            // btnAñadir
            // 
            btnAñadir.Location = new Point(335, 105);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(75, 23);
            btnAñadir.TabIndex = 7;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(89, 232);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(335, 134);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // checkinfome
            // 
            checkinfome.AutoSize = true;
            checkinfome.Location = new Point(335, 22);
            checkinfome.Name = "checkinfome";
            checkinfome.Size = new Size(121, 19);
            checkinfome.TabIndex = 10;
            checkinfome.Text = "Habilitar Informes";
            checkinfome.UseVisualStyleBackColor = true;
            // 
            // FrmInforme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkinfome);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnAñadir);
            Controls.Add(txtEmailTargetAdd);
            Controls.Add(txtEmailPass);
            Controls.Add(txtEmailAddr);
            Controls.Add(dgvEmailTarget);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmInforme";
            Text = "Informes";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvEmailTarget).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dgvEmailTarget;
        private TextBox txtEmailAddr;
        private TextBox txtEmailPass;
        private TextBox txtEmailTargetAdd;
        private Button btnAñadir;
        private Button btnGuardar;
        private Button btnEliminar;
        private CheckBox checkinfome;
    }
}