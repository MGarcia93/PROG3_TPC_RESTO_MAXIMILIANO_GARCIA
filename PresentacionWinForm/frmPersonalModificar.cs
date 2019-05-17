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
using Dominio;

namespace PresentacionWinForm
{
    public partial class frmPersonalModificar : Form
    {
        Personal personalLocal=null;
        public frmPersonalModificar()
        {
            InitializeComponent();
        }
        public frmPersonalModificar(Personal personal)
        {
            InitializeComponent();
            personalLocal = personal;
        }

        

        private void FrmPersonalModificar_Load(object sender, EventArgs e)
        {
            cbxSexo.Items.Add("Masculino");
            cbxSexo.Items.Add("Femenino");
            cbxPuesto.Items.Add("mesero");
            cbxPuesto.Items.Add("encargado");
            if (personalLocal != null)
            {
                txtLegajo.Text = personalLocal.legajo.ToString();
                txtApellido.Text = personalLocal.apellido.ToString();
                txtNombre.Text = personalLocal.nombre.ToString();
                txtDni.Text = personalLocal.dni.ToString();
                dtpFechaNacimiento.Value = personalLocal.fechaNacimiento;
                cbxPuesto.SelectedIndex = cbxPuesto.FindString(personalLocal.cargo);
                if (personalLocal.sexo == "F")
                {
                    cbxSexo.SelectedIndex = cbxSexo.FindString("Femenino");
                }
                else
                {
                    cbxSexo.SelectedIndex = cbxSexo.FindString("Masculino");
                }
                
            }
           
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (validacion())
            {
                Personal personal = new Personal();
                personal.legajo=personalLocal.legajo;
                personal.nombre = txtNombre.Text.Trim();
                personal.apellido = txtApellido.Text.Trim();
                personal.dni = txtDni.Text.Trim();
                personal.fechaNacimiento = dtpFechaNacimiento.Value.Date;
                personal.cargo = cbxPuesto.SelectedItem.ToString();
                if (cbxSexo.SelectedItem.ToString() == "Femenino")
                {
                    personal.cargo = "F";
                }
                else
                {
                    personal.sexo = "M";
                }
                if (PersonalNegocio.modificar(personal))
                {
                    MessageBox.Show("La modificacion se realizo correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("A ocurrido un error al intentar modificar intentelo de nuevo");
                }
            }
            else
            {
                MessageBox.Show("rellene todos los Datos");
            }
        }

        public bool validacion()
        {
            if (txtNombre.Text != "" && txtApellido.Text != "" && txtDni.Text != ""
                && cbxPuesto.SelectedIndex != -1 && cbxSexo.SelectedIndex !=-1 && dtpFechaNacimiento.Value.Date != DateTime.Now.Date)
            {
                return true;
            }
            else
            {
                return false;
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
            else if (txtDni.TextLength > 8 && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                txtDni.BackColor = Color.Red;

            }
        }
    }
}
