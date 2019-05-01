﻿namespace PresentacionWinForm
{
    partial class frmPedidoGenerar
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
            this.lblMesa = new System.Windows.Forms.Label();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.cbxMesa = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.ttCantidad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.ltwDetalle = new System.Windows.Forms.ListView();
            this.gbxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(118, 49);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(315, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Creacion de Pedido";
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Location = new System.Drawing.Point(26, 38);
            this.lblMesa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(48, 20);
            this.lblMesa.TabIndex = 1;
            this.lblMesa.Text = "Mesa";
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.cbxMesa);
            this.gbxDatos.Controls.Add(this.lblMesa);
            this.gbxDatos.Location = new System.Drawing.Point(40, 123);
            this.gbxDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxDatos.Size = new System.Drawing.Size(452, 154);
            this.gbxDatos.TabIndex = 2;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos";
            // 
            // cbxMesa
            // 
            this.cbxMesa.FormattingEnabled = true;
            this.cbxMesa.Location = new System.Drawing.Point(159, 35);
            this.cbxMesa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxMesa.Name = "cbxMesa";
            this.cbxMesa.Size = new System.Drawing.Size(180, 28);
            this.cbxMesa.TabIndex = 3;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(36, 314);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(39, 20);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo";
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(159, 302);
            this.cbxTipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(180, 28);
            this.cbxTipo.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(366, 302);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 35);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(40, 357);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(92, 20);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(159, 357);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(148, 26);
            this.txtDescripcion.TabIndex = 8;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(40, 412);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 20);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "Cantidad";
            // 
            // ttCantidad
            // 
            this.ttCantidad.Location = new System.Drawing.Point(159, 412);
            this.ttCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ttCantidad.Name = "ttCantidad";
            this.ttCantidad.Size = new System.Drawing.Size(148, 26);
            this.ttCantidad.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(78, 497);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 35);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(276, 497);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 35);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.Location = new System.Drawing.Point(552, 55);
            this.lblDetalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(96, 29);
            this.lblDetalle.TabIndex = 13;
            this.lblDetalle.Text = "Detalle";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(812, 525);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(112, 35);
            this.btnGenerar.TabIndex = 14;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            // 
            // ltwDetalle
            // 
            this.ltwDetalle.Location = new System.Drawing.Point(532, 108);
            this.ltwDetalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ltwDetalle.Name = "ltwDetalle";
            this.ltwDetalle.Size = new System.Drawing.Size(655, 390);
            this.ltwDetalle.TabIndex = 15;
            this.ltwDetalle.UseCompatibleStateImageBehavior = false;
            this.ltwDetalle.View = System.Windows.Forms.View.Details;
            // 
            // frmGenerarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 658);
            this.Controls.Add(this.ltwDetalle);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.ttCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGenerarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GenerarPedido";
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.ComboBox cbxMesa;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox ttCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ListView ltwDetalle;
    }
}