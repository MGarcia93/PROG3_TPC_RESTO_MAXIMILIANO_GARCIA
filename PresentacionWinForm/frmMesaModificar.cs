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
    public partial class frmMesaModificar : Form
    {
        Mesa mesaLocal = new Mesa();
        public frmMesaModificar( Mesa mesa)
        {
            InitializeComponent();
            mesaLocal = mesa;
        }

        private void FrmMesaModificar_Load(object sender, EventArgs e)
        {
            txtNumero.Text = mesaLocal.numero.ToString();
            txtCapacidad.Text = mesaLocal.cantComensales.ToString();

        }

        private void BtnModifcar_Click(object sender, EventArgs e)
        {
            Mesa mesa = new Mesa();
            if (txtCapacidad.Text.Trim().Length > 0)
            {
                mesa.numero = Convert.ToInt32(txtNumero.Text.Trim());
                mesa.cantComensales = Convert.ToInt32(txtCapacidad.Text.Trim());
                if (MesaNegocio.agregar(mesa))
                {
                    MessageBox.Show("Se Agrego correctamente la mesa");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar la mesa");
                }
            }
            else
            {
                MessageBox.Show("rellene el campo cantidad de comensales");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
