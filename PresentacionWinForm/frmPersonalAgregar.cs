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
    public partial class frmPersonalAgregar : Form
    {
        public frmPersonalAgregar()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPersonalAgregar_Load(object sender, EventArgs e)
        {
            cbxPuesto.Items.Add("mesero");
            cbxPuesto.Items.Add("Gerente");
        }

        public bool validacion()
        {
            if (txtNombre.Text!="" && txtApellido.Text != "" && txtDni.Text != "" 
                && cbxPuesto.SelectedIndex!=-1 && 
                (rdbFemenino.Checked || rdbMasculino.Checked) && dtpFechaNacimiento.Value.Date!=DateTime.Now.Date)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Personal personal = new Personal();
            if (validacion())
            {
                personal.nombre = txtNombre.Text;
                personal.apellido = txtApellido.Text;
                personal.dni = txtDni.Text;
                personal.cargo = cbxPuesto.SelectedItem.ToString();
                personal.fechaNacimiento = dtpFechaNacimiento.Value.Date;
                if (rdbFemenino.Checked)
                {
                    personal.sexo = "F";
                }
                else
                {
                    personal.sexo = "M";
                }
                PersonalNegocio agregar = new PersonalNegocio();
                if (agregar.agregar(personal))
                {
                    MessageBox.Show("El personal se agrego correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el personal");
                }
            }
            else
            {
                MessageBox.Show("REllene todos los datos");
            }
        }

        private void TxtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDni.BackColor = Color.White;
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                txtDni.BackColor = Color.Red;

            }
            else if (txtDni.TextLength > 7 && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                txtDni.BackColor = Color.Red;

            }
            
        }

        
    }
}
