namespace PresentacionWinForm
{
    partial class frmMesaAsignar
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
            this.cbxMesa = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.Mesa = new System.Windows.Forms.Label();
            this.lblMesero = new System.Windows.Forms.Label();
            this.cbxMesero = new System.Windows.Forms.ComboBox();
            this.Asignar = new System.Windows.Forms.Button();
            this.bxMesero = new System.Windows.Forms.GroupBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.bxMesero.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxMesa
            // 
            this.cbxMesa.FormattingEnabled = true;
            this.cbxMesa.Location = new System.Drawing.Point(156, 84);
            this.cbxMesa.Name = "cbxMesa";
            this.cbxMesa.Size = new System.Drawing.Size(204, 28);
            this.cbxMesa.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTitulo.Location = new System.Drawing.Point(131, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(213, 37);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Asignar Mesa";
            // 
            // Mesa
            // 
            this.Mesa.AutoSize = true;
            this.Mesa.Location = new System.Drawing.Point(55, 84);
            this.Mesa.Name = "Mesa";
            this.Mesa.Size = new System.Drawing.Size(48, 20);
            this.Mesa.TabIndex = 2;
            this.Mesa.Text = "Mesa";
            // 
            // lblMesero
            // 
            this.lblMesero.AutoSize = true;
            this.lblMesero.Location = new System.Drawing.Point(55, 129);
            this.lblMesero.Name = "lblMesero";
            this.lblMesero.Size = new System.Drawing.Size(62, 20);
            this.lblMesero.TabIndex = 3;
            this.lblMesero.Text = "Mesero";
            // 
            // cbxMesero
            // 
            this.cbxMesero.FormattingEnabled = true;
            this.cbxMesero.Location = new System.Drawing.Point(156, 129);
            this.cbxMesero.Name = "cbxMesero";
            this.cbxMesero.Size = new System.Drawing.Size(204, 28);
            this.cbxMesero.TabIndex = 4;
            this.cbxMesero.SelectedIndexChanged += new System.EventHandler(this.CbxMesero_SelectedIndexChanged);
            // 
            // Asignar
            // 
            this.Asignar.Location = new System.Drawing.Point(92, 348);
            this.Asignar.Name = "Asignar";
            this.Asignar.Size = new System.Drawing.Size(112, 35);
            this.Asignar.TabIndex = 5;
            this.Asignar.Text = "Asignar";
            this.Asignar.UseVisualStyleBackColor = true;
            this.Asignar.Click += new System.EventHandler(this.Asignar_Click);
            // 
            // bxMesero
            // 
            this.bxMesero.Controls.Add(this.txtApellido);
            this.bxMesero.Controls.Add(this.txtNombre);
            this.bxMesero.Controls.Add(this.lblNombre);
            this.bxMesero.Controls.Add(this.lblApellido);
            this.bxMesero.Location = new System.Drawing.Point(46, 178);
            this.bxMesero.Name = "bxMesero";
            this.bxMesero.Size = new System.Drawing.Size(364, 140);
            this.bxMesero.TabIndex = 8;
            this.bxMesero.TabStop = false;
            this.bxMesero.Text = "Datos";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(123, 83);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ReadOnly = true;
            this.txtApellido.Size = new System.Drawing.Size(179, 26);
            this.txtApellido.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(123, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(179, 26);
            this.txtNombre.TabIndex = 8;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(24, 42);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(24, 83);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(65, 20);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(257, 349);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 35);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // frmMesaAsignar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(485, 439);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.bxMesero);
            this.Controls.Add(this.Asignar);
            this.Controls.Add(this.cbxMesero);
            this.Controls.Add(this.lblMesero);
            this.Controls.Add(this.Mesa);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cbxMesa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMesaAsignar";
            this.Text = "frmAsignarMesa";
            this.Load += new System.EventHandler(this.FrmMesaAsignar_Load);
            this.bxMesero.ResumeLayout(false);
            this.bxMesero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxMesa;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label Mesa;
        private System.Windows.Forms.Label lblMesero;
        private System.Windows.Forms.ComboBox cbxMesero;
        private System.Windows.Forms.Button Asignar;
        private System.Windows.Forms.GroupBox bxMesero;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Button btnCancelar;
    }
}