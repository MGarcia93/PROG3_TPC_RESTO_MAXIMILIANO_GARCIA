namespace PresentacionWinForm
{
    partial class frmPedidoCerrar
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPedido = new System.Windows.Forms.Label();
            this.cbxMesa = new System.Windows.Forms.ComboBox();
            this.gbxDetalle = new System.Windows.Forms.GroupBox();
            this.lvwDetalle = new System.Windows.Forms.ListView();
            this.lblMesa = new System.Windows.Forms.Label();
            this.cbxPedido = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbxDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(214, 45);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(106, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cerrar Pedido";
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(66, 149);
            this.lblPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(58, 20);
            this.lblPedido.TabIndex = 1;
            this.lblPedido.Text = "Pedido";
            // 
            // cbxMesa
            // 
            this.cbxMesa.FormattingEnabled = true;
            this.cbxMesa.Location = new System.Drawing.Point(170, 103);
            this.cbxMesa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxMesa.Name = "cbxMesa";
            this.cbxMesa.Size = new System.Drawing.Size(180, 28);
            this.cbxMesa.TabIndex = 2;
            // 
            // gbxDetalle
            // 
            this.gbxDetalle.Controls.Add(this.lvwDetalle);
            this.gbxDetalle.Location = new System.Drawing.Point(44, 205);
            this.gbxDetalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxDetalle.Name = "gbxDetalle";
            this.gbxDetalle.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxDetalle.Size = new System.Drawing.Size(477, 378);
            this.gbxDetalle.TabIndex = 3;
            this.gbxDetalle.TabStop = false;
            this.gbxDetalle.Text = "Detalle";
            // 
            // lvwDetalle
            // 
            this.lvwDetalle.Location = new System.Drawing.Point(14, 48);
            this.lvwDetalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvwDetalle.Name = "lvwDetalle";
            this.lvwDetalle.Size = new System.Drawing.Size(428, 319);
            this.lvwDetalle.TabIndex = 2;
            this.lvwDetalle.UseCompatibleStateImageBehavior = false;
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Location = new System.Drawing.Point(66, 103);
            this.lblMesa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(48, 20);
            this.lblMesa.TabIndex = 4;
            this.lblMesa.Text = "Mesa";
            // 
            // cbxPedido
            // 
            this.cbxPedido.FormattingEnabled = true;
            this.cbxPedido.Location = new System.Drawing.Point(170, 149);
            this.cbxPedido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxPedido.Name = "cbxPedido";
            this.cbxPedido.Size = new System.Drawing.Size(180, 28);
            this.cbxPedido.TabIndex = 5;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(105, 607);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 35);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Cerrar";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(274, 607);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 35);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmPedidoCerrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(576, 682);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cbxPedido);
            this.Controls.Add(this.lblMesa);
            this.Controls.Add(this.gbxDetalle);
            this.Controls.Add(this.cbxMesa);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPedidoCerrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCerrarPedido";
            this.gbxDetalle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.ComboBox cbxMesa;
        private System.Windows.Forms.GroupBox gbxDetalle;
        private System.Windows.Forms.ListView lvwDetalle;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.ComboBox cbxPedido;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
    }
}