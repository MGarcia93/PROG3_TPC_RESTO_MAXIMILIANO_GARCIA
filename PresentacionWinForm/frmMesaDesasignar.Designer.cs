namespace PresentacionWinForm
{
    partial class frmMesaDesasignar
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
            this.Legajo = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblCancelar = new System.Windows.Forms.Button();
            this.bxMesero = new System.Windows.Forms.GroupBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNumeroMesa = new System.Windows.Forms.TextBox();
            this.bxMesero.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitulo.Location = new System.Drawing.Point(112, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(221, 46);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Desasignar";
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Location = new System.Drawing.Point(55, 100);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(48, 20);
            this.lblMesa.TabIndex = 1;
            this.lblMesa.Text = "Mesa";
            // 
            // Legajo
            // 
            this.Legajo.AutoSize = true;
            this.Legajo.Location = new System.Drawing.Point(20, 47);
            this.Legajo.Name = "Legajo";
            this.Legajo.Size = new System.Drawing.Size(57, 20);
            this.Legajo.TabIndex = 3;
            this.Legajo.Text = "Legajo";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(119, 41);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.ReadOnly = true;
            this.txtLegajo.Size = new System.Drawing.Size(179, 26);
            this.txtLegajo.TabIndex = 4;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(69, 323);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 40);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // lblCancelar
            // 
            this.lblCancelar.Location = new System.Drawing.Point(237, 323);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(100, 40);
            this.lblCancelar.TabIndex = 6;
            this.lblCancelar.Text = "Cancelar";
            this.lblCancelar.UseVisualStyleBackColor = true;
            this.lblCancelar.Click += new System.EventHandler(this.LblCancelar_Click);
            // 
            // bxMesero
            // 
            this.bxMesero.Controls.Add(this.txtApellido);
            this.bxMesero.Controls.Add(this.txtNombre);
            this.bxMesero.Controls.Add(this.lblNombre);
            this.bxMesero.Controls.Add(this.lblApellido);
            this.bxMesero.Controls.Add(this.Legajo);
            this.bxMesero.Controls.Add(this.txtLegajo);
            this.bxMesero.Location = new System.Drawing.Point(25, 124);
            this.bxMesero.Name = "bxMesero";
            this.bxMesero.Size = new System.Drawing.Size(364, 181);
            this.bxMesero.TabIndex = 7;
            this.bxMesero.TabStop = false;
            this.bxMesero.Text = "Mesero";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(119, 133);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ReadOnly = true;
            this.txtApellido.Size = new System.Drawing.Size(179, 26);
            this.txtApellido.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(119, 86);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(179, 26);
            this.txtNombre.TabIndex = 8;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 92);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(20, 133);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(65, 20);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido";
            // 
            // txtNumeroMesa
            // 
            this.txtNumeroMesa.Location = new System.Drawing.Point(144, 90);
            this.txtNumeroMesa.Name = "txtNumeroMesa";
            this.txtNumeroMesa.ReadOnly = true;
            this.txtNumeroMesa.Size = new System.Drawing.Size(179, 26);
            this.txtNumeroMesa.TabIndex = 8;
            // 
            // frmMesaDesasignar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(401, 405);
            this.Controls.Add(this.txtNumeroMesa);
            this.Controls.Add(this.bxMesero);
            this.Controls.Add(this.lblCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblMesa);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMesaDesasignar";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMesaDesasignar";
            this.Load += new System.EventHandler(this.FrmMesaDesasignar_Load);
            this.bxMesero.ResumeLayout(false);
            this.bxMesero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.Label Legajo;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button lblCancelar;
        private System.Windows.Forms.GroupBox bxMesero;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNumeroMesa;
    }
}