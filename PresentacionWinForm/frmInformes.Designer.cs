namespace PresentacionWinForm
{
    partial class frmInformes
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
            this.tpbInforme = new System.Windows.Forms.TabControl();
            this.tpgRecaudoMesa = new System.Windows.Forms.TabPage();
            this.dgvListaMesa = new System.Windows.Forms.DataGridView();
            this.cbxFiltro = new System.Windows.Forms.GroupBox();
            this.cbxMesa = new System.Windows.Forms.ComboBox();
            this.lblMesa = new System.Windows.Forms.Label();
            this.btnFiltrarMesas = new System.Windows.Forms.Button();
            this.lblHasta = new System.Windows.Forms.Label();
            this.esde = new System.Windows.Forms.Label();
            this.dtpHastaMesa = new System.Windows.Forms.DateTimePicker();
            this.dtpDesdeMesa = new System.Windows.Forms.DateTimePicker();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tpgRecaudoMesero = new System.Windows.Forms.TabPage();
            this.dgvListaMesero = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxLegajo = new System.Windows.Forms.ComboBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.btnBuscarMesero = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHastaMesero = new System.Windows.Forms.DateTimePicker();
            this.dtpDesdeMesero = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tpgDia = new System.Windows.Forms.TabPage();
            this.lblRecaudado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvListaDia = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarDia = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpHastaDia = new System.Windows.Forms.DateTimePicker();
            this.dtpDesdeDia = new System.Windows.Forms.DateTimePicker();
            this.lblTituoDia = new System.Windows.Forms.Label();
            this.tpbInforme.SuspendLayout();
            this.tpgRecaudoMesa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMesa)).BeginInit();
            this.cbxFiltro.SuspendLayout();
            this.tpgRecaudoMesero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMesero)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tpgDia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDia)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpbInforme
            // 
            this.tpbInforme.Controls.Add(this.tpgRecaudoMesa);
            this.tpbInforme.Controls.Add(this.tpgRecaudoMesero);
            this.tpbInforme.Controls.Add(this.tpgDia);
            this.tpbInforme.Location = new System.Drawing.Point(35, 33);
            this.tpbInforme.Name = "tpbInforme";
            this.tpbInforme.SelectedIndex = 0;
            this.tpbInforme.Size = new System.Drawing.Size(1137, 561);
            this.tpbInforme.TabIndex = 0;
            this.tpbInforme.SelectedIndexChanged += new System.EventHandler(this.TpbInforme_SelectedIndexChanged);
            // 
            // tpgRecaudoMesa
            // 
            this.tpgRecaudoMesa.Controls.Add(this.dgvListaMesa);
            this.tpgRecaudoMesa.Controls.Add(this.cbxFiltro);
            this.tpgRecaudoMesa.Controls.Add(this.lblTitulo);
            this.tpgRecaudoMesa.Location = new System.Drawing.Point(4, 29);
            this.tpgRecaudoMesa.Name = "tpgRecaudoMesa";
            this.tpgRecaudoMesa.Padding = new System.Windows.Forms.Padding(3);
            this.tpgRecaudoMesa.Size = new System.Drawing.Size(1129, 528);
            this.tpgRecaudoMesa.TabIndex = 0;
            this.tpgRecaudoMesa.Text = "Recaudacion por Mesa";
            this.tpgRecaudoMesa.UseVisualStyleBackColor = true;
            this.tpgRecaudoMesa.Click += new System.EventHandler(this.TpgRecaudoMesa_Click);
            // 
            // dgvListaMesa
            // 
            this.dgvListaMesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaMesa.Location = new System.Drawing.Point(33, 207);
            this.dgvListaMesa.Name = "dgvListaMesa";
            this.dgvListaMesa.RowTemplate.Height = 28;
            this.dgvListaMesa.Size = new System.Drawing.Size(1063, 316);
            this.dgvListaMesa.TabIndex = 4;
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.Controls.Add(this.cbxMesa);
            this.cbxFiltro.Controls.Add(this.lblMesa);
            this.cbxFiltro.Controls.Add(this.btnFiltrarMesas);
            this.cbxFiltro.Controls.Add(this.lblHasta);
            this.cbxFiltro.Controls.Add(this.esde);
            this.cbxFiltro.Controls.Add(this.dtpHastaMesa);
            this.cbxFiltro.Controls.Add(this.dtpDesdeMesa);
            this.cbxFiltro.Location = new System.Drawing.Point(23, 73);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(1073, 106);
            this.cbxFiltro.TabIndex = 3;
            this.cbxFiltro.TabStop = false;
            this.cbxFiltro.Text = "Filtro";
            // 
            // cbxMesa
            // 
            this.cbxMesa.FormattingEnabled = true;
            this.cbxMesa.Location = new System.Drawing.Point(85, 46);
            this.cbxMesa.Name = "cbxMesa";
            this.cbxMesa.Size = new System.Drawing.Size(77, 28);
            this.cbxMesa.TabIndex = 8;
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Location = new System.Drawing.Point(21, 50);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(48, 20);
            this.lblMesa.TabIndex = 7;
            this.lblMesa.Text = "Mesa";
            // 
            // btnFiltrarMesas
            // 
            this.btnFiltrarMesas.Location = new System.Drawing.Point(967, 40);
            this.btnFiltrarMesas.Name = "btnFiltrarMesas";
            this.btnFiltrarMesas.Size = new System.Drawing.Size(100, 40);
            this.btnFiltrarMesas.TabIndex = 4;
            this.btnFiltrarMesas.Text = "&Filtrar";
            this.btnFiltrarMesas.UseVisualStyleBackColor = true;
            this.btnFiltrarMesas.Click += new System.EventHandler(this.BtnFiltrarMesas_Click);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(577, 51);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(52, 20);
            this.lblHasta.TabIndex = 3;
            this.lblHasta.Text = "Hasta";
            // 
            // esde
            // 
            this.esde.AutoSize = true;
            this.esde.Location = new System.Drawing.Point(188, 50);
            this.esde.Name = "esde";
            this.esde.Size = new System.Drawing.Size(56, 20);
            this.esde.TabIndex = 2;
            this.esde.Text = "Desde";
            // 
            // dtpHastaMesa
            // 
            this.dtpHastaMesa.Location = new System.Drawing.Point(635, 46);
            this.dtpHastaMesa.Name = "dtpHastaMesa";
            this.dtpHastaMesa.Size = new System.Drawing.Size(312, 26);
            this.dtpHastaMesa.TabIndex = 1;
            // 
            // dtpDesdeMesa
            // 
            this.dtpDesdeMesa.Location = new System.Drawing.Point(256, 45);
            this.dtpDesdeMesa.Name = "dtpDesdeMesa";
            this.dtpDesdeMesa.Size = new System.Drawing.Size(290, 26);
            this.dtpDesdeMesa.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitulo.Location = new System.Drawing.Point(345, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(427, 46);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Recaudado Por Mesas";
            // 
            // tpgRecaudoMesero
            // 
            this.tpgRecaudoMesero.Controls.Add(this.dgvListaMesero);
            this.tpgRecaudoMesero.Controls.Add(this.groupBox1);
            this.tpgRecaudoMesero.Controls.Add(this.label3);
            this.tpgRecaudoMesero.Location = new System.Drawing.Point(4, 29);
            this.tpgRecaudoMesero.Name = "tpgRecaudoMesero";
            this.tpgRecaudoMesero.Padding = new System.Windows.Forms.Padding(3);
            this.tpgRecaudoMesero.Size = new System.Drawing.Size(1129, 528);
            this.tpgRecaudoMesero.TabIndex = 1;
            this.tpgRecaudoMesero.Text = "Recaudacion por Mesero";
            this.tpgRecaudoMesero.UseVisualStyleBackColor = true;
            // 
            // dgvListaMesero
            // 
            this.dgvListaMesero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaMesero.Location = new System.Drawing.Point(38, 182);
            this.dgvListaMesero.Name = "dgvListaMesero";
            this.dgvListaMesero.RowTemplate.Height = 28;
            this.dgvListaMesero.Size = new System.Drawing.Size(1035, 328);
            this.dgvListaMesero.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxLegajo);
            this.groupBox1.Controls.Add(this.lblLegajo);
            this.groupBox1.Controls.Add(this.btnBuscarMesero);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpHastaMesero);
            this.groupBox1.Controls.Add(this.dtpDesdeMesero);
            this.groupBox1.Location = new System.Drawing.Point(9, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1110, 77);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // cbxLegajo
            // 
            this.cbxLegajo.FormattingEnabled = true;
            this.cbxLegajo.Location = new System.Drawing.Point(104, 29);
            this.cbxLegajo.Name = "cbxLegajo";
            this.cbxLegajo.Size = new System.Drawing.Size(184, 28);
            this.cbxLegajo.TabIndex = 6;
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
            // btnBuscarMesero
            // 
            this.btnBuscarMesero.Location = new System.Drawing.Point(979, 22);
            this.btnBuscarMesero.Name = "btnBuscarMesero";
            this.btnBuscarMesero.Size = new System.Drawing.Size(100, 40);
            this.btnBuscarMesero.TabIndex = 4;
            this.btnBuscarMesero.Text = "&Buscar";
            this.btnBuscarMesero.UseVisualStyleBackColor = true;
            this.btnBuscarMesero.Click += new System.EventHandler(this.BtnBuscarMesero_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(654, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desde";
            // 
            // dtpHastaMesero
            // 
            this.dtpHastaMesero.Location = new System.Drawing.Point(712, 29);
            this.dtpHastaMesero.Name = "dtpHastaMesero";
            this.dtpHastaMesero.Size = new System.Drawing.Size(200, 26);
            this.dtpHastaMesero.TabIndex = 1;
            // 
            // dtpDesdeMesero
            // 
            this.dtpDesdeMesero.Location = new System.Drawing.Point(395, 29);
            this.dtpDesdeMesero.Name = "dtpDesdeMesero";
            this.dtpDesdeMesero.Size = new System.Drawing.Size(200, 26);
            this.dtpDesdeMesero.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(384, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(443, 46);
            this.label3.TabIndex = 5;
            this.label3.Text = "Recaudado Por Mesero";
            // 
            // tpgDia
            // 
            this.tpgDia.Controls.Add(this.dgvListaDia);
            this.tpgDia.Controls.Add(this.groupBox2);
            this.tpgDia.Controls.Add(this.lblTituoDia);
            this.tpgDia.Location = new System.Drawing.Point(4, 29);
            this.tpgDia.Name = "tpgDia";
            this.tpgDia.Size = new System.Drawing.Size(1129, 528);
            this.tpgDia.TabIndex = 2;
            this.tpgDia.Text = "Venta de Dia";
            this.tpgDia.UseVisualStyleBackColor = true;
            // 
            // lblRecaudado
            // 
            this.lblRecaudado.AutoSize = true;
            this.lblRecaudado.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecaudado.Location = new System.Drawing.Point(933, 598);
            this.lblRecaudado.Name = "lblRecaudado";
            this.lblRecaudado.Size = new System.Drawing.Size(0, 51);
            this.lblRecaudado.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(769, 598);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 51);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total:";
            // 
            // dgvListaDia
            // 
            this.dgvListaDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDia.Location = new System.Drawing.Point(38, 180);
            this.dgvListaDia.Name = "dgvListaDia";
            this.dgvListaDia.RowTemplate.Height = 28;
            this.dgvListaDia.Size = new System.Drawing.Size(1072, 328);
            this.dgvListaDia.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarDia);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtpHastaDia);
            this.groupBox2.Controls.Add(this.dtpDesdeDia);
            this.groupBox2.Location = new System.Drawing.Point(104, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(868, 77);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtro";
            // 
            // btnBuscarDia
            // 
            this.btnBuscarDia.Location = new System.Drawing.Point(719, 25);
            this.btnBuscarDia.Name = "btnBuscarDia";
            this.btnBuscarDia.Size = new System.Drawing.Size(100, 40);
            this.btnBuscarDia.TabIndex = 4;
            this.btnBuscarDia.Text = "&Buscar";
            this.btnBuscarDia.UseVisualStyleBackColor = true;
            this.btnBuscarDia.Click += new System.EventHandler(this.BtnBuscarDia_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Hasta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Desde";
            // 
            // dtpHastaDia
            // 
            this.dtpHastaDia.Location = new System.Drawing.Point(434, 33);
            this.dtpHastaDia.Name = "dtpHastaDia";
            this.dtpHastaDia.Size = new System.Drawing.Size(200, 26);
            this.dtpHastaDia.TabIndex = 1;
            // 
            // dtpDesdeDia
            // 
            this.dtpDesdeDia.Location = new System.Drawing.Point(117, 33);
            this.dtpDesdeDia.Name = "dtpDesdeDia";
            this.dtpDesdeDia.Size = new System.Drawing.Size(200, 26);
            this.dtpDesdeDia.TabIndex = 0;
            // 
            // lblTituoDia
            // 
            this.lblTituoDia.AutoSize = true;
            this.lblTituoDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTituoDia.Location = new System.Drawing.Point(384, 20);
            this.lblTituoDia.Name = "lblTituoDia";
            this.lblTituoDia.Size = new System.Drawing.Size(370, 46);
            this.lblTituoDia.TabIndex = 8;
            this.lblTituoDia.Text = "Recaudado Por Dia";
            // 
            // frmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 658);
            this.Controls.Add(this.lblRecaudado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tpbInforme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInformes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmInformes";
            this.Load += new System.EventHandler(this.FrmInformes_Load);
            this.tpbInforme.ResumeLayout(false);
            this.tpgRecaudoMesa.ResumeLayout(false);
            this.tpgRecaudoMesa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMesa)).EndInit();
            this.cbxFiltro.ResumeLayout(false);
            this.cbxFiltro.PerformLayout();
            this.tpgRecaudoMesero.ResumeLayout(false);
            this.tpgRecaudoMesero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMesero)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpgDia.ResumeLayout(false);
            this.tpgDia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDia)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tpbInforme;
        private System.Windows.Forms.TabPage tpgRecaudoMesa;
        private System.Windows.Forms.TabPage tpgRecaudoMesero;
        private System.Windows.Forms.GroupBox cbxFiltro;
        private System.Windows.Forms.Button btnFiltrarMesas;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label esde;
        private System.Windows.Forms.DateTimePicker dtpHastaMesa;
        private System.Windows.Forms.DateTimePicker dtpDesdeMesa;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxLegajo;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Button btnBuscarMesero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpHastaMesero;
        private System.Windows.Forms.DateTimePicker dtpDesdeMesero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvListaMesero;
        private System.Windows.Forms.DataGridView dgvListaMesa;
        private System.Windows.Forms.ComboBox cbxMesa;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.TabPage tpgDia;
        private System.Windows.Forms.Label lblRecaudado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvListaDia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarDia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpHastaDia;
        private System.Windows.Forms.DateTimePicker dtpDesdeDia;
        private System.Windows.Forms.Label lblTituoDia;
    }
}