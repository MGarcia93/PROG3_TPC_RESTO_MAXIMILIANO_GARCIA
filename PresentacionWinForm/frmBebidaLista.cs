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
            Grilla();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (dgvBebida.Rows.GetRowCount(DataGridViewElementStates.Selected) < 1)
            {
                MessageBox.Show("Seleccione una fila");
            }
            else
            {
                frmBebidaModificar modificar = new frmBebidaModificar((Bebida)dgvBebida.CurrentRow.DataBoundItem);
                modificar.ShowDialog();
                Grilla();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            /*frmBebidaEliminar eliminar = new frmBebidaEliminar();
            eliminar.ShowDialog();*/
            if (dgvBebida.Rows.GetRowCount(DataGridViewElementStates.Selected) < 1)
            {
                MessageBox.Show("Seleccione una fila");
            }
            else
            {
                if(MessageBox.Show("Esta seguro de eliminar este producto.", "ELIMINAR", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    BebidaNegocio.eliminar((Bebida)dgvBebida.CurrentRow.DataBoundItem);
                    Grilla();
                }
                
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBebidaLista_Load(object sender, EventArgs e)
        {
            Grilla();
        }

        private void Grilla()
        {
 
            try
            {
                listado = BebidaNegocio.listar();
                dgvBebida.DataSource = listado;
                dgvBebida.Columns["id"].DisplayIndex = 0;
                dgvBebida.Columns["nombre"].DisplayIndex = 1;

                for (int i = 0; i < dgvBebida.Columns.Count; i++)
                {
                    dgvBebida.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
                dgvBebida.DataSource = listado;
            }
            else
            {
                List<Bebida> lista = new List<Bebida>();

                lista = listado.FindAll(x => x.nombre.ToUpper().Contains(txtBuscar.Text.ToUpper()));
                dgvBebida.DataSource = lista;
            }
        }
    }
}
