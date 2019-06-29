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
    
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            inicializar();
        }

        private void inicializar()
        {
            
            txtLegajo.Text = "";
            txtPassword.Text = "";
        }
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            ingresar();
            
        }
        private bool validacion()
        {
            if(txtLegajo.Text.Trim().ToString() !="" && txtPassword.Text.Trim().ToString() != "")
            {
                return true;
            }
            return false;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ingresar();
            }
        }

        private void ingresar()
        {
            if (!validacion())
            {
                MessageBox.Show("Por favor rellene todos los datos");
                return;
            }
            Grobales.usuario = UsuarioNegocio.traer(txtLegajo.Text.Trim(), txtPassword.Text.Trim());
            if (Grobales.usuario != null)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o Password incorrecto");
            }
        }

        private void main_closing(object sender, EventArgs e)
        {
            inicializar();
            this.Show();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
