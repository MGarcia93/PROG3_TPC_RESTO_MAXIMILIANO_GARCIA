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
    public partial class frmMesaDesasignar : Form
    {
        int numeroMesa;
        Mesero meseroLocal = new Mesero();
        public frmMesaDesasignar()
        {
            InitializeComponent();
        }
        public frmMesaDesasignar(int mesa,Mesero mesero)
        {
            InitializeComponent();
            numeroMesa = mesa;
            meseroLocal =mesero;
        }

        private void FrmMesaDesasignar_Load(object sender, EventArgs e)
        {
            txtNumeroMesa.Text = numeroMesa.ToString();
            txtNombre.Text = meseroLocal.nombre;
            txtLegajo.Text = meseroLocal.legajo.ToString();
            txtApellido.Text = meseroLocal.apellido;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (MesaNegocio.ActualizarAsignacion(numeroMesa.ToString())==1)
            {
                MessageBox.Show("La operacion se realizo correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo realizar la operacion");
            }
        }

        private void LblCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
