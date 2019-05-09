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
    public partial class frmPlatoLista : Form
    {
        List<Comida> listado = new List<Comida>();

        public frmPlatoLista()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            frmPlatoAgregar agregar = new frmPlatoAgregar();
            agregar.ShowDialog();
            Grilla();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            frmPlatoModificar modificar = new frmPlatoModificar();
            modificar.ShowDialog();
            Grilla();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            
        }


        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPlatoLista_Load(object sender, EventArgs e)
        {
            Grilla();
        }

        private void Grilla()
        {
            ComidaNegocio comida = new ComidaNegocio();
            try
            {
                listado = comida.listar();
                dgvPlato.DataSource = listado;
            }
            catch (Exception)
            {

                throw;
            }
            
            
        }
    }
}
