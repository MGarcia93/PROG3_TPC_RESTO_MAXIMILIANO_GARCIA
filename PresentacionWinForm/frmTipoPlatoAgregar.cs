using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace PresentacionWinForm
{
    public partial class frmTipoPlatoAgregar : Form
    {
        public frmTipoPlatoAgregar()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() != "")
            {
                if (TipoPlatoNegocio.agregar(txtNombre.Text.Trim())){
                    MessageBox.Show("Se agrego correctamente");
                    txtNombre.Text = "";
                }
                else
                {
                    MessageBox.Show("No se pudo agregar, intentelo de nuevo");
                }
            }
            else
            {
                MessageBox.Show("Rellene el nombre");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
