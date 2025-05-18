namespace Vista
{
    partial class FrmCategoria
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
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            numid = new NumericUpDown();
            textBox1 = new TextBox();
            btnAceptar = new Button();
            ((System.ComponentModel.ISupportInitialize)numid).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(146, 97);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Descripcion";
            // 
            // numid
            // 
            numid.Location = new Point(101, 23);
            numid.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            numid.Name = "numid";
            numid.Size = new Size(120, 23);
            numid.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 5;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(12, 97);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += button1_Click;
            // 
            // FrmCategoria
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(247, 128);
            Controls.Add(btnAceptar);
            Controls.Add(textBox1);
            Controls.Add(numid);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Name = "FrmCategoria";
            Text = "Añadir Categoria";
            ((System.ComponentModel.ISupportInitialize)numid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        private NumericUpDown numid;
        private TextBox textBox1;
        private Button btnAceptar;
    }
}