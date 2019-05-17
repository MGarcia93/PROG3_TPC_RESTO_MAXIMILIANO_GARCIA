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
    public partial class frmPersonalLista : Form
    {
        List<Personal> listado = new List<Personal>();

        public frmPersonalLista()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            
            frmPersonalAgregar agregar = new frmPersonalAgregar();
            agregar.ShowDialog();
            Grilla();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPersonal.Rows.GetRowCount(DataGridViewElementStates.Selected) < 1)
            {
                MessageBox.Show("Seleccione una fila");
            }
            else
            {
                frmPersonalModificar modificar = new frmPersonalModificar((Personal)dgvPersonal.CurrentRow.DataBoundItem);
                modificar.ShowDialog();
                Grilla();
            }
            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //frmPersonalEliminar eliminar = new frmPersonalEliminar();
            //eliminar.ShowDialog();
            if (dgvPersonal.Rows.GetRowCount(DataGridViewElementStates.Selected) < 1)
            {
                MessageBox.Show("Seleccione una fila");
            }
            else
            {
                if (MessageBox.Show("Estas seguro de eliminar esta persona", "Eliminacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (PersonalNegocio.eliminar((Personal)dgvPersonal.CurrentRow.DataBoundItem)){
                        MessageBox.Show("Se elimino correctamente");
                        Grilla();

                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error en la eliminacion intentelo de nuevo");
                    }
                    
                }
                
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPersonalLista_Load(object sender, EventArgs e)
        {
            Grilla();

        }

        private void Grilla()
        {

            try
            {
                listado = PersonalNegocio.listar();
                dgvPersonal.DataSource = listado;
                dgvPersonal.Columns["permiso"].Visible = false;

                for (int i = 0; i < dgvPersonal.Columns.Count; i++)
                {
                    dgvPersonal.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }
    }
}
