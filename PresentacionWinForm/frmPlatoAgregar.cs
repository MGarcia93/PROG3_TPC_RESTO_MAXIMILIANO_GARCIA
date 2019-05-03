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
    public partial class frmPlatoAgregar : Form
    {
        public frmPlatoAgregar()
        {
            InitializeComponent();
        }

        private void FrmAgregarPlato_Load(object sender, EventArgs e)
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
