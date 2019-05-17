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
    public partial class frmPlatoModificar : Form
    {
        Comida platoLocal=null;
        int id;
        public frmPlatoModificar()
        {
            InitializeComponent();
        }

        public frmPlatoModificar(Comida plato)
        {
            InitializeComponent();
            platoLocal = plato;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPlatoModificar_Load(object sender, EventArgs e)
        {
            TipoPlatoNegocio tiposPlatos = new TipoPlatoNegocio();
            try
            {
                cbxTipo.DataSource = tiposPlatos.listaTipoPlato();
                cbxTipo.DisplayMember = "descripcion";
                cbxTipo.ValueMember = "id";
                if (platoLocal != null)
                {
                    txtNombre.Text = platoLocal.nombre.ToString();
                    txtDescripcion.Text = platoLocal.descripcion.ToString();
                    txtPrecio.Text = platoLocal.precio.ToString();
                    cbxTipo.SelectedValue = platoLocal.tipoPlato.id;
                    id = platoLocal.id;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (verificarDatos())
            {
                try
                {
                    Comida comida = new Comida();
                    comida.descripcion = txtDescripcion.Text.ToString();
                    comida.nombre = txtNombre.Text.ToString();

                    comida.precio = Convert.ToDecimal(txtPrecio.Text.ToString());
                    comida.tipoPlato = (TipoPlato)cbxTipo.SelectedItem;
                    comida.id = id;
                    if (ComidaNegocio.modificar(comida))
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
            if (txtDescripcion.Text.ToString() != "" && txtNombre.Text.ToString() != "" && txtPrecio.Text.ToString() != "")
            {
                ok = true;
            }
            return ok;
        }

    }
}
