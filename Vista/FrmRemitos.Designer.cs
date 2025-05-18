namespace Vista
{
    partial class FrmRemitos
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
            dgvDetallesRemito = new DataGridView();
            dgvRemito = new DataGridView();
            BtnAdd = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesRemito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRemito).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dgvDetallesRemito);
            groupBox1.Controls.Add(dgvRemito);
            groupBox1.Controls.Add(BtnAdd);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1257, 478);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(562, 4);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 7;
            label2.Text = "Detalles";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 4);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 6;
            label1.Text = "Remitos";
            // 
            // dgvDetallesRemito
            // 
            dgvDetallesRemito.AllowUserToAddRows = false;
            dgvDetallesRemito.AllowUserToDeleteRows = false;
            dgvDetallesRemito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetallesRemito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallesRemito.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvDetallesRemito.Location = new Point(562, 22);
            dgvDetallesRemito.Name = "dgvDetallesRemito";
            dgvDetallesRemito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetallesRemito.Size = new Size(689, 427);
            dgvDetallesRemito.TabIndex = 4;
            // 
            // dgvRemito
            // 
            dgvRemito.AllowUserToAddRows = false;
            dgvRemito.AllowUserToDeleteRows = false;
            dgvRemito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRemito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRemito.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvRemito.Location = new Point(6, 22);
            dgvRemito.Name = "dgvRemito";
            dgvRemito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRemito.Size = new Size(550, 427);
            dgvRemito.TabIndex = 3;
            dgvRemito.CellClick += dgvRemito_CellClick;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(6, 455);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(75, 23);
            BtnAdd.TabIndex = 0;
            BtnAdd.Text = "Añadir";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // FrmRemitos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1281, 502);
            Controls.Add(groupBox1);
            Name = "FrmRemitos";
            Text = "Remitos";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesRemito).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRemito).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvRemito;
        private Button BtnAdd;
        private Label label2;
        private Label label1;
        private DataGridView dgvDetallesRemito;
    }
}