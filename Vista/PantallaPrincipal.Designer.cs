namespace Vista
{
    partial class PantallaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            gestionarToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            proveedoresToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            remitosToolStripMenuItem = new ToolStripMenuItem();
            ordenDeCompraToolStripMenuItem = new ToolStripMenuItem();
            pedidosPresupuestoToolStripMenuItem = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            informesToolStrip = new ToolStripMenuItem();
            facturasPorFechaToolStripMenuItem = new ToolStripMenuItem();
            facturasPorClienteToolStripMenuItem = new ToolStripMenuItem();
            productoMasVendidoToolStripMenuItem = new ToolStripMenuItem();
            configToolStripMenuItem = new ToolStripMenuItem();
            informesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { gestionarToolStripMenuItem, informesToolStrip, configToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gestionarToolStripMenuItem
            // 
            gestionarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, ventasToolStripMenuItem, proveedoresToolStripMenuItem, productosToolStripMenuItem, remitosToolStripMenuItem, ordenDeCompraToolStripMenuItem, pedidosPresupuestoToolStripMenuItem, categoriasToolStripMenuItem });
            gestionarToolStripMenuItem.Name = "gestionarToolStripMenuItem";
            gestionarToolStripMenuItem.Size = new Size(69, 20);
            gestionarToolStripMenuItem.Text = "Gestionar";
            gestionarToolStripMenuItem.Click += gestionarToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(164, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(164, 22);
            ventasToolStripMenuItem.Text = "Ventas";
            ventasToolStripMenuItem.Click += ventasToolStripMenuItem_Click;
            // 
            // proveedoresToolStripMenuItem
            // 
            proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            proveedoresToolStripMenuItem.Size = new Size(164, 22);
            proveedoresToolStripMenuItem.Text = "Proveedores";
            proveedoresToolStripMenuItem.Click += proveedoresToolStripMenuItem_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(164, 22);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // remitosToolStripMenuItem
            // 
            remitosToolStripMenuItem.Name = "remitosToolStripMenuItem";
            remitosToolStripMenuItem.Size = new Size(164, 22);
            remitosToolStripMenuItem.Text = "Remitos";
            remitosToolStripMenuItem.Click += remitosToolStripMenuItem_Click;
            // 
            // ordenDeCompraToolStripMenuItem
            // 
            ordenDeCompraToolStripMenuItem.Name = "ordenDeCompraToolStripMenuItem";
            ordenDeCompraToolStripMenuItem.Size = new Size(164, 22);
            ordenDeCompraToolStripMenuItem.Text = "OrdenDeCompra";
            ordenDeCompraToolStripMenuItem.Click += ordenDeCompraToolStripMenuItem_Click;
            // 
            // pedidosPresupuestoToolStripMenuItem
            // 
            pedidosPresupuestoToolStripMenuItem.Name = "pedidosPresupuestoToolStripMenuItem";
            pedidosPresupuestoToolStripMenuItem.Size = new Size(164, 22);
            pedidosPresupuestoToolStripMenuItem.Text = "Presupuesto";
            pedidosPresupuestoToolStripMenuItem.Click += pedidosPresupuestoToolStripMenuItem_Click;
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(164, 22);
            categoriasToolStripMenuItem.Text = "Categorias";
            categoriasToolStripMenuItem.Click += categoriasToolStripMenuItem_Click;
            // 
            // informesToolStrip
            // 
            informesToolStrip.DropDownItems.AddRange(new ToolStripItem[] { facturasPorFechaToolStripMenuItem, facturasPorClienteToolStripMenuItem, productoMasVendidoToolStripMenuItem });
            informesToolStrip.Name = "informesToolStrip";
            informesToolStrip.Size = new Size(66, 20);
            informesToolStrip.Text = "Informes";
            // 
            // facturasPorFechaToolStripMenuItem
            // 
            facturasPorFechaToolStripMenuItem.Name = "facturasPorFechaToolStripMenuItem";
            facturasPorFechaToolStripMenuItem.Size = new Size(194, 22);
            facturasPorFechaToolStripMenuItem.Text = "Facturas Por Fecha";
            facturasPorFechaToolStripMenuItem.Click += facturasPorFechaToolStripMenuItem_Click;
            // 
            // facturasPorClienteToolStripMenuItem
            // 
            facturasPorClienteToolStripMenuItem.Name = "facturasPorClienteToolStripMenuItem";
            facturasPorClienteToolStripMenuItem.Size = new Size(194, 22);
            facturasPorClienteToolStripMenuItem.Text = "Facturas Por Cliente";
            facturasPorClienteToolStripMenuItem.Click += facturasPorClienteToolStripMenuItem_Click;
            // 
            // productoMasVendidoToolStripMenuItem
            // 
            productoMasVendidoToolStripMenuItem.Name = "productoMasVendidoToolStripMenuItem";
            productoMasVendidoToolStripMenuItem.Size = new Size(194, 22);
            productoMasVendidoToolStripMenuItem.Text = "Producto Mas Vendido";
            productoMasVendidoToolStripMenuItem.Click += productoMasVendidoToolStripMenuItem_Click;
            // 
            // configToolStripMenuItem
            // 
            configToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { informesToolStripMenuItem });
            configToolStripMenuItem.Name = "configToolStripMenuItem";
            configToolStripMenuItem.Size = new Size(55, 20);
            configToolStripMenuItem.Text = "Config";
            // 
            // informesToolStripMenuItem
            // 
            informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            informesToolStripMenuItem.Size = new Size(121, 22);
            informesToolStripMenuItem.Text = "Informes";
            informesToolStripMenuItem.Click += informesToolStripMenuItem_Click;
            // 
            // PantallaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "PantallaPrincipal";
            Text = "Sistema Control de Stock";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gestionarToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem remitosToolStripMenuItem;
        private ToolStripMenuItem ordenDeCompraToolStripMenuItem;
        private ToolStripMenuItem pedidosPresupuestoToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem configToolStripMenuItem;
        private ToolStripMenuItem informesToolStripMenuItem;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem informesToolStrip;
        private ToolStripMenuItem facturasPorFechaToolStripMenuItem;
        private ToolStripMenuItem facturasPorClienteToolStripMenuItem;
        private ToolStripMenuItem productoMasVendidoToolStripMenuItem;
    }
}