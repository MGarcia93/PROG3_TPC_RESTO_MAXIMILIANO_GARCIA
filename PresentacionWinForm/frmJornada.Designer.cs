namespace PresentacionWinForm
{
    partial class frmJornada
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
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btnGenera = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardarDefault = new System.Windows.Forms.Button();
            this.tbcPanel = new System.Windows.Forms.TabControl();
            this.tbpInsumos = new System.Windows.Forms.TabPage();
            this.tbpMesas = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.tbcPanel.SuspendLayout();
            this.tbpInsumos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitulo.Location = new System.Drawing.Point(506, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(164, 46);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Jornada";
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(30, 25);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowTemplate.Height = 28;
            this.dgvLista.Size = new System.Drawing.Size(1109, 442);
            this.dgvLista.TabIndex = 12;
            // 
            // btnGenera
            // 
            this.btnGenera.Location = new System.Drawing.Point(259, 489);
            this.btnGenera.Name = "btnGenera";
            this.btnGenera.Size = new System.Drawing.Size(100, 40);
            this.btnGenera.TabIndex = 13;
            this.btnGenera.Text = "Generar";
            this.btnGenera.UseVisualStyleBackColor = true;
            this.btnGenera.Click += new System.EventHandler(this.BtnGenera_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(427, 489);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(100, 40);
            this.btnModifica.TabIndex = 14;
            this.btnModifica.Text = "Modificar";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.BtnModifica_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(789, 489);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 40);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnGuardarDefault
            // 
            this.btnGuardarDefault.Location = new System.Drawing.Point(588, 489);
            this.btnGuardarDefault.Name = "btnGuardarDefault";
            this.btnGuardarDefault.Size = new System.Drawing.Size(157, 40);
            this.btnGuardarDefault.TabIndex = 16;
            this.btnGuardarDefault.Text = "Guardar Default";
            this.btnGuardarDefault.UseVisualStyleBackColor = true;
            this.btnGuardarDefault.Click += new System.EventHandler(this.BtnGuardarDefault_Click);
            // 
            // tbcPanel
            // 
            this.tbcPanel.Controls.Add(this.tbpInsumos);
            this.tbcPanel.Controls.Add(this.tbpMesas);
            this.tbcPanel.Location = new System.Drawing.Point(26, 51);
            this.tbcPanel.Name = "tbcPanel";
            this.tbcPanel.SelectedIndex = 0;
            this.tbcPanel.Size = new System.Drawing.Size(1172, 595);
            this.tbcPanel.TabIndex = 20;
            // 
            // tbpInsumos
            // 
            this.tbpInsumos.Controls.Add(this.dgvLista);
            this.tbpInsumos.Controls.Add(this.btnGuardarDefault);
            this.tbpInsumos.Controls.Add(this.btnGenera);
            this.tbpInsumos.Controls.Add(this.btnSalir);
            this.tbpInsumos.Controls.Add(this.btnModifica);
            this.tbpInsumos.Location = new System.Drawing.Point(4, 29);
            this.tbpInsumos.Name = "tbpInsumos";
            this.tbpInsumos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInsumos.Size = new System.Drawing.Size(1164, 562);
            this.tbpInsumos.TabIndex = 0;
            this.tbpInsumos.Text = "Insumos";
            this.tbpInsumos.UseVisualStyleBackColor = true;
            // 
            // tbpMesas
            // 
            this.tbpMesas.Location = new System.Drawing.Point(4, 29);
            this.tbpMesas.Name = "tbpMesas";
            this.tbpMesas.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMesas.Size = new System.Drawing.Size(1164, 562);
            this.tbpMesas.TabIndex = 1;
            this.tbpMesas.Text = "Mesas";
            this.tbpMesas.UseVisualStyleBackColor = true;
            // 
            // frmJornada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 658);
            this.Controls.Add(this.tbcPanel);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmJornada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmJornada";
            this.Load += new System.EventHandler(this.FrmJornada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.tbcPanel.ResumeLayout(false);
            this.tbpInsumos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnGenera;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardarDefault;
        private System.Windows.Forms.TabControl tbcPanel;
        private System.Windows.Forms.TabPage tbpInsumos;
        private System.Windows.Forms.TabPage tbpMesas;
    }
}