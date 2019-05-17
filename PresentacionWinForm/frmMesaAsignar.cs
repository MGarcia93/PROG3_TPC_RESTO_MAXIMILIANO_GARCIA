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
    public partial class frmMesaAsignar : Form
    {
        public frmMesaAsignar()
        {
            InitializeComponent();
        }

        private void FrmMesaAsignar_Load(object sender, EventArgs e)
        {
            cbxMesa.DataSource = MesaNegocio.listar();
            cbxMesa.DisplayMember = "numero";
            cbxMesa.ValueMember = "id";
            cbxMesero.DataSource = MeseroNegocio.listar("'mesero'");
            cbxMesero.DisplayMember = "legajo";
            cbxMesero.ValueMember = "legajo";
        }

        private void CbxMesero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMesero.SelectedIndex!=-1)
            {
                txtApellido.Text = ((Personal)cbxMesero.SelectedItem).apellido;
                txtNombre.Text = ((Personal)cbxMesero.SelectedItem).nombre;
            }
            
        }
         public bool verificar()
        {
            if (cbxMesero.SelectedIndex != -1 && cbxMesa.SelectedIndex != -1)
            {
                return true;
            }
            return false;
        }

        private void Asignar_Click(object sender, EventArgs e)
        {
            if (verificar())
            {
                if (MesaNegocio.ActualizarAsignacion(cbxMesa.SelectedValue.ToString(),cbxMesero.SelectedValue.ToString())==1)
                {
                    MessageBox.Show("Se asigno correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo asignar la mesa");
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
