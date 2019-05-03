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
    public partial class frmPersonalLista : Form
    {
        List<Personal> listado = new List<Personal>();

        public frmPersonalLista()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            frmPersonalAgregar agregar = new frmPersonalAgregar();
            agregar.ShowDialog();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            frmPersonalModificar modificar = new frmPersonalModificar();
            modificar.ShowDialog();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            frmPersonalEliminar eliminar = new frmPersonalEliminar();
            eliminar.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPersonalLista_Load(object sender, EventArgs e)
        {
            dgvPersonal.DataSource = listado;

        }
    }
}
