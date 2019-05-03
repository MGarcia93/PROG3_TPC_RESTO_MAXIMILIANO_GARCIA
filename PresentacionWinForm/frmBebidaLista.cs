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
    public partial class frmBebidaLista : Form
    {

        List<Bebida> listado = new List<Bebida>();
        public frmBebidaLista()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            frmBebidaAgregar agregar = new frmBebidaAgregar();
            agregar.ShowDialog();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            frmBebidaModificar modificar = new frmBebidaModificar();
            modificar.ShowDialog();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            frmBebidaEliminar eliminar = new frmBebidaEliminar();
            eliminar.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBebidaLista_Load(object sender, EventArgs e)
        {
            dgvBebida.DataSource = listado;
        }
    }
}
