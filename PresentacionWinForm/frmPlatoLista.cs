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
            if (dgvPlato.Rows.GetRowCount(DataGridViewElementStates.Selected) < 1)
            {
                MessageBox.Show("Seleccione una fila");
            }
            else
            {
                frmPlatoModificar modificar = new frmPlatoModificar((Comida)dgvPlato.CurrentRow.DataBoundItem);
                modificar.ShowDialog();
                Grilla();   
            }
            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPlato.Rows.GetRowCount(DataGridViewElementStates.Selected) < 1)
            {
                MessageBox.Show("Seleccione una fila");
            }
            else
            {
                if (MessageBox.Show("Estas Seguro de eliminar ester Producto", "ELIMINACION", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (ComidaNegocio.eliminar((Comida)dgvPlato.CurrentRow.DataBoundItem))
                    {
                        MessageBox.Show("Producto eliminado");
                        Grilla();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el Producto");
                    }
                }
            }

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
                dgvPlato.Columns["id"].DisplayIndex = 0;
                dgvPlato.Columns["nombre"].DisplayIndex = 1;
                dgvPlato.Columns["tipo"].Visible = false;
                for (int i = 0; i < dgvPlato.Columns.Count; i++)
                {
                    dgvPlato.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
            
        }

        private void TxtBucar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.TextLength < 3)
            {
                dgvPlato.DataSource = listado;
            }
            else
            {
                List<Comida> lista = new List<Comida>();

                lista = listado.FindAll(x => x.nombre.ToUpper().Contains(txtBuscar.Text.ToUpper()));
                dgvPlato.DataSource = lista;
            }
        }
    }
}
