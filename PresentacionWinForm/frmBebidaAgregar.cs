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

    public partial class frmBebidaAgregar : Form
    {
        public frmBebidaAgregar()
        {
            InitializeComponent();
        }

        private void FrmBebidaAgregar_Load(object sender, EventArgs e)
        {
            CategoriaBebidaNegocio categorias = new CategoriaBebidaNegocio();
            cbxCategoria.DataSource = categorias.listadoCategoriaBebidas();
            cbxCategoria.DisplayMember = "descripcion";
            cbxCategoria.ValueMember = "id";
            cbxCategoria.SelectedIndex=0;

        }

        private void CbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCategoria.SelectedValue.ToString() != "Dominio.Categoria")
            {
                MarcaNegocio marcas = new MarcaNegocio();
                cbxMarca.DataSource = marcas.listadoMarca(cbxCategoria.SelectedValue.ToString());
                cbxMarca.DisplayMember = "descripcion";
                cbxMarca.ValueMember = "id";
            }
        }
    }
}

