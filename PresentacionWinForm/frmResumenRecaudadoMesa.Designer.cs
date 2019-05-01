namespace PresentacionWinForm
{
    partial class frmResumenRecaudadoMesa
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
            this.cbxFiltro = new System.Windows.Forms.GroupBox();
            this.dgvResumen = new System.Windows.Forms.DataGridView();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.esde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cbxFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitulo.Location = new System.Drawing.Point(420, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(427, 46);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Recaudado Por Mesas";
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.Controls.Add(this.btnFiltrar);
            this.cbxFiltro.Controls.Add(this.lblHasta);
            this.cbxFiltro.Controls.Add(this.esde);
            this.cbxFiltro.Controls.Add(this.dtpHasta);
            this.cbxFiltro.Controls.Add(this.dtpDesde);
            this.cbxFiltro.Location = new System.Drawing.Point(149, 60);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(893, 183);
            this.cbxFiltro.TabIndex = 1;
            this.cbxFiltro.TabStop = false;
            this.cbxFiltro.Text = "Filtro";
            
            // 
            // dgvResumen
            // 
            this.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumen.Location = new System.Drawing.Point(33, 143);
            this.dgvResumen.Name = "dgvResumen";
            this.dgvResumen.RowTemplate.Height = 28;
            this.dgvResumen.Size = new System.Drawing.Size(1165, 503);
            this.dgvResumen.TabIndex = 2;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(89, 35);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 26);
            this.dtpDesde.TabIndex = 0;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(406, 35);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 26);
            this.dtpHasta.TabIndex = 1;
            // 
            // esde
            // 
            this.esde.AutoSize = true;
            this.esde.Location = new System.Drawing.Point(21, 40);
            this.esde.Name = "esde";
            this.esde.Size = new System.Drawing.Size(56, 20);
            this.esde.TabIndex = 2;
            this.esde.Text = "Desde";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(348, 40);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(52, 20);
            this.lblHasta.TabIndex = 3;
            this.lblHasta.Text = "Hasta";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(713, 30);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(100, 40);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "&Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // frmResumenRecaudadoMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 658);
            this.Controls.Add(this.dgvResumen);
            this.Controls.Add(this.cbxFiltro);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmResumenRecaudadoMesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmResumenRecaudadoMesa";
            this.cbxFiltro.ResumeLayout(false);
            this.cbxFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox cbxFiltro;
        private System.Windows.Forms.DataGridView dgvResumen;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label esde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
    }
}