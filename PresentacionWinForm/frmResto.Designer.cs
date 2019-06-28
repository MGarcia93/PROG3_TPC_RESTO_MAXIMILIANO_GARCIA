namespace PresentacionWinForm
{
    partial class frmResto
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.verPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.generarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAlPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMesas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInsumos = new System.Windows.Forms.ToolStripMenuItem();
            this.platosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bebidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInformes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPersonal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDefiniciones = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeBebidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmJornada = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDePlatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPedido,
            this.tsmMesas,
            this.tsmInsumos,
            this.tsmInformes,
            this.tsmPersonal,
            this.tsmDefiniciones,
            this.tsmJornada,
            this.tsmSalir,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1216, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmPedido
            // 
            this.tsmPedido.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPedidosToolStripMenuItem,
            this.toolStripSeparator6,
            this.generarToolStripMenuItem,
            this.agregarAlPedidoToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.tsmPedido.Name = "tsmPedido";
            this.tsmPedido.Size = new System.Drawing.Size(87, 29);
            this.tsmPedido.Text = "&Pedidos";
            // 
            // verPedidosToolStripMenuItem
            // 
            this.verPedidosToolStripMenuItem.Name = "verPedidosToolStripMenuItem";
            this.verPedidosToolStripMenuItem.Size = new System.Drawing.Size(243, 30);
            this.verPedidosToolStripMenuItem.Text = "Ver Pedidos";
            this.verPedidosToolStripMenuItem.Click += new System.EventHandler(this.verPedidosToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(240, 6);
            // 
            // generarToolStripMenuItem
            // 
            this.generarToolStripMenuItem.Name = "generarToolStripMenuItem";
            this.generarToolStripMenuItem.Size = new System.Drawing.Size(243, 30);
            this.generarToolStripMenuItem.Text = "Generar";
            this.generarToolStripMenuItem.Click += new System.EventHandler(this.generarToolStripMenuItem_Click);
            // 
            // agregarAlPedidoToolStripMenuItem
            // 
            this.agregarAlPedidoToolStripMenuItem.Name = "agregarAlPedidoToolStripMenuItem";
            this.agregarAlPedidoToolStripMenuItem.Size = new System.Drawing.Size(243, 30);
            this.agregarAlPedidoToolStripMenuItem.Text = "Agregar Al pedido";
            this.agregarAlPedidoToolStripMenuItem.Click += new System.EventHandler(this.AgregarAlPedidoToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(243, 30);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // tsmMesas
            // 
            this.tsmMesas.Name = "tsmMesas";
            this.tsmMesas.Size = new System.Drawing.Size(74, 29);
            this.tsmMesas.Text = "&Mesas";
            this.tsmMesas.Click += new System.EventHandler(this.MesasToolStripMenuItem_Click);
            // 
            // tsmInsumos
            // 
            this.tsmInsumos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.platosToolStripMenuItem,
            this.bebidasToolStripMenuItem,
            this.toolStripSeparator2,
            this.tsmInventario});
            this.tsmInsumos.Name = "tsmInsumos";
            this.tsmInsumos.Size = new System.Drawing.Size(153, 29);
            this.tsmInsumos.Text = "&Platos y Bebidas";
            // 
            // platosToolStripMenuItem
            // 
            this.platosToolStripMenuItem.Name = "platosToolStripMenuItem";
            this.platosToolStripMenuItem.Size = new System.Drawing.Size(175, 30);
            this.platosToolStripMenuItem.Text = "Platos";
            this.platosToolStripMenuItem.Click += new System.EventHandler(this.PlatosToolStripMenuItem_Click);
            // 
            // bebidasToolStripMenuItem
            // 
            this.bebidasToolStripMenuItem.Name = "bebidasToolStripMenuItem";
            this.bebidasToolStripMenuItem.Size = new System.Drawing.Size(175, 30);
            this.bebidasToolStripMenuItem.Text = "Bebidas";
            this.bebidasToolStripMenuItem.Click += new System.EventHandler(this.BebidasToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(172, 6);
            // 
            // tsmInventario
            // 
            this.tsmInventario.Name = "tsmInventario";
            this.tsmInventario.Size = new System.Drawing.Size(175, 30);
            this.tsmInventario.Text = "Inventario";
            this.tsmInventario.Click += new System.EventHandler(this.TsmInventario_Click);
            // 
            // tsmInformes
            // 
            this.tsmInformes.Name = "tsmInformes";
            this.tsmInformes.Size = new System.Drawing.Size(96, 29);
            this.tsmInformes.Text = "&Resumen";
            this.tsmInformes.Click += new System.EventHandler(this.TsmInformes_Click);
            // 
            // tsmPersonal
            // 
            this.tsmPersonal.Name = "tsmPersonal";
            this.tsmPersonal.Size = new System.Drawing.Size(90, 29);
            this.tsmPersonal.Text = "&Personal";
            this.tsmPersonal.Click += new System.EventHandler(this.UsuarioToolStripMenuItem_Click);
            // 
            // tsmDefiniciones
            // 
            this.tsmDefiniciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcaToolStripMenuItem,
            this.tipoDeBebidasToolStripMenuItem,
            this.tipoDePlatoToolStripMenuItem});
            this.tsmDefiniciones.Name = "tsmDefiniciones";
            this.tsmDefiniciones.Size = new System.Drawing.Size(120, 29);
            this.tsmDefiniciones.Text = "Definiciones";
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.marcaToolStripMenuItem.Text = "Marca";
            this.marcaToolStripMenuItem.Click += new System.EventHandler(this.MarcaToolStripMenuItem_Click);
            // 
            // tipoDeBebidasToolStripMenuItem
            // 
            this.tipoDeBebidasToolStripMenuItem.Name = "tipoDeBebidasToolStripMenuItem";
            this.tipoDeBebidasToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.tipoDeBebidasToolStripMenuItem.Text = "Tipo de bebidas";
            this.tipoDeBebidasToolStripMenuItem.Click += new System.EventHandler(this.TipoDeBebidasToolStripMenuItem_Click);
            // 
            // tsmJornada
            // 
            this.tsmJornada.Name = "tsmJornada";
            this.tsmJornada.Size = new System.Drawing.Size(86, 29);
            this.tsmJornada.Text = "&Jornada";
            this.tsmJornada.Click += new System.EventHandler(this.TsmJornada_Click);
            // 
            // tsmSalir
            // 
            this.tsmSalir.Name = "tsmSalir";
            this.tsmSalir.Size = new System.Drawing.Size(57, 29);
            this.tsmSalir.Text = "&Salir";
            this.tsmSalir.Click += new System.EventHandler(this.TsmSalir_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 29);
            // 
            // tipoDePlatoToolStripMenuItem
            // 
            this.tipoDePlatoToolStripMenuItem.Name = "tipoDePlatoToolStripMenuItem";
            this.tipoDePlatoToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.tipoDePlatoToolStripMenuItem.Text = "Tipo de Plato";
            this.tipoDePlatoToolStripMenuItem.Click += new System.EventHandler(this.TipoDePlatoToolStripMenuItem_Click);
            // 
            // frmResto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1216, 705);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmResto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REsto";
            this.Load += new System.EventHandler(this.FrmResto_Load);
            this.MdiChildActivate += new System.EventHandler(this.FrmResto_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmPedido;
        private System.Windows.Forms.ToolStripMenuItem generarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmPersonal;
        private System.Windows.Forms.ToolStripMenuItem tsmMesas;
        private System.Windows.Forms.ToolStripMenuItem tsmInformes;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmInsumos;
        private System.Windows.Forms.ToolStripMenuItem platosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bebidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmInventario;
        private System.Windows.Forms.ToolStripMenuItem tsmSalir;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmDefiniciones;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeBebidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem agregarAlPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmJornada;
        private System.Windows.Forms.ToolStripMenuItem tipoDePlatoToolStripMenuItem;
    }
}

