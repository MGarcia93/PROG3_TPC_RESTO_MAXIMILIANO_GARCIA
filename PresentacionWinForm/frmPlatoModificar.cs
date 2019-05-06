using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace PresentacionWinForm
{
    public partial class frmPlatoModificar : Form
    {
        public frmPlatoModificar()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPlatoModificar_Load(object sender, EventArgs e)
        {
            TipoPlatoNegocio tiposPlatos = new TipoPlatoNegocio();
            try
            {
                cbxTipo.DataSource = tiposPlatos.listaTipoPlato();
                cbxTipo.DisplayMember = "descripcion";
                cbxTipo.ValueMember = "id";

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPrecio.BackColor = TextBox.DefaultBackColor;
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                txtPrecio.BackColor = Color.Red;

            }
            if (e.KeyChar == 44 && txtPrecio.Text.IndexOf(",") == -1)
            {
                txtPrecio.BackColor = TextBox.DefaultBackColor;
                e.Handled = false;
            }
        }
    }
}
