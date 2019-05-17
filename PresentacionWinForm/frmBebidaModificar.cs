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
        Bebida bebidaLocal=null;
        public frmBebidaModificar()
        {
            InitializeComponent();
        }
        public frmBebidaModificar( Bebida datos)
        {
            InitializeComponent();
            bebidaLocal = datos;
        }

        private void FrmBebidaModificar_Load(object sender, EventArgs e)
        {
           
            cbxCategoria.DataSource = CategoriaBebidaNegocio.listadoCategoriaBebidas();
            cbxCategoria.DisplayMember = "descripcion";
            cbxCategoria.ValueMember = "id";
            if (bebidaLocal != null)
            {
                txtDescripcion.Text = bebidaLocal.nombre.ToString();
                txtPrecio.Text = bebidaLocal.precio.ToString();
                cbxCategoria.SelectedIndex = cbxCategoria.FindString(bebidaLocal.categoria.descripcion);
                cbxMarca.SelectedIndex = cbxMarca.FindString(bebidaLocal.marca.descripcion);

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
               
                cbxMarca.DataSource = MarcaNegocio.listadoMarca(cbxCategoria.SelectedValue.ToString());
                cbxMarca.DisplayMember = "descripcion";
                cbxMarca.ValueMember = "id";
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (verificarDatos())
            {
                try
                {
                    Bebida bebida = new Bebida();
                    bebida.nombre = txtDescripcion.Text.ToString();
                    bebida.contieneAlcohol = ckbContieneAlcohol.Checked;
                    bebida.precio = Convert.ToDecimal(txtPrecio.Text.ToString());
                    bebida.marca = (Marca)cbxMarca.SelectedItem;
                    bebida.categoria = (Categoria)cbxCategoria.SelectedItem;
                    bebida.id = bebidaLocal.id;
                    if (BebidaNegocio.modificar(bebida))
                    {
                        MessageBox.Show("Plato modificado");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar los datos");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public bool verificarDatos()
        {
            bool ok = false;
            if (txtDescripcion.Text.ToString() != "" && txtPrecio.Text.ToString() != "")
            {
                ok = true;
            }
            return ok;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPrecio.BackColor = Color.White;
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                txtPrecio.BackColor = Color.Red;

            }
            if (e.KeyChar == 44 && txtPrecio.Text.IndexOf(",") == -1)
            {
                txtPrecio.BackColor = Color.White;
                e.Handled = false;
            }

        }
    }


}
