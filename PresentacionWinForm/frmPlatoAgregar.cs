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
    public partial class frmPlatoAgregar : Form
    {
        public frmPlatoAgregar()
        {
            InitializeComponent();
        }

        private void FrmAgregarPlato_Load(object sender, EventArgs e)
        {
            TipoPlatoNegocio tiposPlatos = new TipoPlatoNegocio();
            try
            {
                cbxTipo.DataSource = tiposPlatos.listaTipoPlato();
                cbxTipo.DisplayMember = "descripcion";
                cbxTipo.ValueMember = "id";

            }
            catch (Exception ex)
            {

                 throw ex;
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (!verificarDatos())
            {
                MessageBox.Show("Rellene todos los datos");
                return;
            }
            Comida comida = new Comida();
            comida.descripcion = txtDescripcion.Text.ToString();
            comida.nombre = txtNombre.Text.ToString();
            
            comida.precio =Convert.ToDecimal(txtPrecio.Text.ToString());
            comida.tipoPlato = (TipoPlato)cbxTipo.SelectedItem;
            ComidaNegocio negocio = new ComidaNegocio();
            if (negocio.agregar(comida))
            {
                MessageBox.Show("se agrego correctamente");
            }
            else
            {
                MessageBox.Show("No se pudo ingresar el elemento");
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


        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {

            txtPrecio.BackColor = TextBox.DefaultBackColor;
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                txtPrecio.BackColor = Color.Red;

            }
            if (e.KeyChar == 44 && txtPrecio.Text.IndexOf(",") == -1)
            {
                txtPrecio.BackColor = TextBox.DefaultBackColor ;
                e.Handled = false;
            }


        }
    }
}
