namespace Vista
{
    partial class FrmRemito
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
            dgvOrdenDeCompra = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            dgvDetalles = new DataGridView();
            BtnAdd = new Button();
            label3 = new Label();
            numId = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenDeCompra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numId).BeginInit();
            SuspendLayout();
            // 
            // dgvOrdenDeCompra
            // 
            dgvOrdenDeCompra.AllowUserToAddRows = false;
            dgvOrdenDeCompra.AllowUserToDeleteRows = false;
            dgvOrdenDeCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrdenDeCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenDeCompra.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvOrdenDeCompra.Location = new Point(12, 23);
            dgvOrdenDeCompra.Name = "dgvOrdenDeCompra";
            dgvOrdenDeCompra.RowTemplate.Height = 25;
            dgvOrdenDeCompra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrdenDeCompra.Size = new Size(368, 235);
            dgvOrdenDeCompra.TabIndex = 4;
            dgvOrdenDeCompra.CellClick += dgvOrdenDeCompra_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 7;
            label1.Text = "Orden de Compra";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(386, 9);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 8;
            label2.Text = "Detalles";
            // 
            // dgvDetalles
            // 
            dgvDetalles.AllowUserToAddRows = false;
            dgvDetalles.AllowUserToDeleteRows = false;
            dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvDetalles.Location = new Point(386, 23);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.RowTemplate.Height = 25;
            dgvDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalles.Size = new Size(368, 235);
            dgvDetalles.TabIndex = 9;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(12, 264);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(165, 23);
            BtnAdd.TabIndex = 10;
            BtnAdd.Text = "Certificar Llegada Productos";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 269);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 11;
            label3.Text = "Id";
            // 
            // numId
            // 
            numId.Enabled = false;
            numId.Location = new Point(248, 266);
            numId.Name = "numId";
            numId.Size = new Size(120, 23);
            numId.TabIndex = 12;
            // 
            // FrmRemito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 293);
            Controls.Add(numId);
            Controls.Add(label3);
            Controls.Add(BtnAdd);
            Controls.Add(dgvDetalles);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvOrdenDeCompra);
            Name = "FrmRemito";
            Text = "Remito";
            ((System.ComponentModel.ISupportInitialize)dgvOrdenDeCompra).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            ((System.ComponentModel.ISupportInitialize)numId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrdenDeCompra;
        private Label label1;
        private Label label2;
        private DataGridView dgvDetalles;
        private Button BtnAdd;
        private Label label3;
        private NumericUpDown numId;
    }
}