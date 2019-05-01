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
            this.SuspendLayout();
            // 
            // cbxMesa
            // 
            this.cbxMesa.FormattingEnabled = true;
            this.cbxMesa.Location = new System.Drawing.Point(156, 96);
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
            this.Mesa.Location = new System.Drawing.Point(55, 96);
            this.Mesa.Name = "Mesa";
            this.Mesa.Size = new System.Drawing.Size(48, 20);
            this.Mesa.TabIndex = 2;
            this.Mesa.Text = "Mesa";
            // 
            // lblMesero
            // 
            this.lblMesero.AutoSize = true;
            this.lblMesero.Location = new System.Drawing.Point(55, 141);
            this.lblMesero.Name = "lblMesero";
            this.lblMesero.Size = new System.Drawing.Size(62, 20);
            this.lblMesero.TabIndex = 3;
            this.lblMesero.Text = "Mesero";
            // 
            // cbxMesero
            // 
            this.cbxMesero.FormattingEnabled = true;
            this.cbxMesero.Location = new System.Drawing.Point(156, 141);
            this.cbxMesero.Name = "cbxMesero";
            this.cbxMesero.Size = new System.Drawing.Size(121, 28);
            this.cbxMesero.TabIndex = 4;
            // 
            // Asignar
            // 
            this.Asignar.Location = new System.Drawing.Point(167, 231);
            this.Asignar.Name = "Asignar";
            this.Asignar.Size = new System.Drawing.Size(110, 55);
            this.Asignar.TabIndex = 5;
            this.Asignar.Text = "Asignar";
            this.Asignar.UseVisualStyleBackColor = true;
            // 
            // frmMesaAsignar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(485, 371);
            this.Controls.Add(this.Asignar);
            this.Controls.Add(this.cbxMesero);
            this.Controls.Add(this.lblMesero);
            this.Controls.Add(this.Mesa);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cbxMesa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMesaAsignar";
            this.Text = "frmAsignarMesa";
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
    }
}