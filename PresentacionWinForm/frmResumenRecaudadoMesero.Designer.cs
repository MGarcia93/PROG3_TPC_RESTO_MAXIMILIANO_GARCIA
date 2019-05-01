namespace PresentacionWinForm
{
    partial class frmResumenRecaudadoMesero
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
            this.dgvResumen = new System.Windows.Forms.DataGridView();
            this.cbxFiltro = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblHasta = new System.Windows.Forms.Label();
            this.esde = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.cbxLegajo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).BeginInit();
            this.cbxFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvResumen
            // 
            this.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumen.Location = new System.Drawing.Point(29, 143);
            this.dgvResumen.Name = "dgvResumen";
            this.dgvResumen.RowTemplate.Height = 28;
            this.dgvResumen.Size = new System.Drawing.Size(1165, 503);
            this.dgvResumen.TabIndex = 5;
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.Controls.Add(this.cbxLegajo);
            this.cbxFiltro.Controls.Add(this.lblLegajo);
            this.cbxFiltro.Controls.Add(this.btnBuscar);
            this.cbxFiltro.Controls.Add(this.lblHasta);
            this.cbxFiltro.Controls.Add(this.esde);
            this.cbxFiltro.Controls.Add(this.dtpHasta);
            this.cbxFiltro.Controls.Add(this.dtpDesde);
            this.cbxFiltro.Location = new System.Drawing.Point(41, 58);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(1110, 77);
            this.cbxFiltro.TabIndex = 4;
            this.cbxFiltro.TabStop = false;
            this.cbxFiltro.Text = "Filtro";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(979, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 40);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(654, 34);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(52, 20);
            this.lblHasta.TabIndex = 3;
            this.lblHasta.Text = "Hasta";
            // 
            // esde
            // 
            this.esde.AutoSize = true;
            this.esde.Location = new System.Drawing.Point(327, 34);
            this.esde.Name = "esde";
            this.esde.Size = new System.Drawing.Size(56, 20);
            this.esde.TabIndex = 2;
            this.esde.Text = "Desde";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(712, 29);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 26);
            this.dtpHasta.TabIndex = 1;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(395, 29);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 26);
            this.dtpDesde.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitulo.Location = new System.Drawing.Point(416, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(443, 46);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Recaudado Por Mesero";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(25, 33);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(57, 20);
            this.lblLegajo.TabIndex = 5;
            this.lblLegajo.Text = "Legajo";
            // 
            // cbxLegajo
            // 
            this.cbxLegajo.FormattingEnabled = true;
            this.cbxLegajo.Location = new System.Drawing.Point(104, 29);
            this.cbxLegajo.Name = "cbxLegajo";
            this.cbxLegajo.Size = new System.Drawing.Size(184, 28);
            this.cbxLegajo.TabIndex = 6;
            // 
            // frmResumenRecaudadoMesero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 658);
            this.Controls.Add(this.dgvResumen);
            this.Controls.Add(this.cbxFiltro);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmResumenRecaudadoMesero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmResumenRecaudadoMesero";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).EndInit();
            this.cbxFiltro.ResumeLayout(false);
            this.cbxFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResumen;
        private System.Windows.Forms.GroupBox cbxFiltro;
        private System.Windows.Forms.ComboBox cbxLegajo;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label esde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblTitulo;
    }
}