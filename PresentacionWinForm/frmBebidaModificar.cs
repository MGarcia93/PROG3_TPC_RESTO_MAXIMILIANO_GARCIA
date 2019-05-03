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
    public partial class frmBebidaModificar : Form
    {
        Bebida bebida;
        public frmBebidaModificar()
        {
            InitializeComponent();
        }
        public frmBebidaModificar( Bebida datos)
        {
            InitializeComponent();
            bebida = new Bebida();
            bebida = datos;
        }

        private void FrmBebidaModificar_Load(object sender, EventArgs e)
        {
            CategoriaBebidaNegocio categorias = new CategoriaBebidaNegocio();
            cbxCategoria.DataSource = categorias.listadoCategoriaBebidas();
            cbxCategoria.DisplayMember = "descripcion";
            cbxCategoria.ValueMember = "id";
            if (bebida != null)
            {
                txtDescripcion.Text = bebida.nombre.ToString();
                txtPrecio.Text = bebida.precio.ToString();
                cbxCategoria.SelectedIndex = cbxCategoria.FindString(bebida.categoria.descripcion);
                cbxMarca.SelectedIndex = cbxMarca.FindString(bebida.marca.descripcion);

            }
            else
            {
                cbxCategoria.SelectedIndex = 0;
            }

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
