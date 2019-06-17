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
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            Grilla();
        }

        private void Grilla()
        {

            try
            {

                dgvLista.DataSource = JornadaNegocio.inventario(Grobales.jornada);

                for (int i = 0; i < dgvLista.Columns.Count; i++)
                {
                    dgvLista.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }
    }
}
