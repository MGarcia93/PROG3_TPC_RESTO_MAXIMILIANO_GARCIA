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
    public partial class frmMarcaAgregar : Form
    {
       
        public frmMarcaAgregar()
        {
            InitializeComponent();
        }

        private void FrmMarcaAgregar_Load(object sender, EventArgs e)
        {
            cbxTipo.DataSource = CategoriaBebidaNegocio.listadoCategoriaBebidas();
            cbxTipo.ValueMember = "id";
            cbxTipo.DisplayMember = "descripcion";

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.TextLength != 0)
            {
                if (MarcaNegocio.agregar(txtNombre.Text.Trim(), cbxTipo.SelectedValue.ToString())){

                }
            }
        }
    }
}
