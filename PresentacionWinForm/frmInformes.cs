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
    public partial class frmInformes : Form
    {


        public frmInformes()
        {
            InitializeComponent();
        }

        private void visible()
        {
            if (tpbInforme.SelectedTab == tpgRecaudoMesero)
            {
                cbxLegajo.DataSource = PersonalNegocio.listar();
                cbxLegajo.ValueMember = "legajo";
                cbxLegajo.SelectedIndex = 0;
                grillaMesero();
            }
            else if (tpbInforme.SelectedTab == tpgRecaudoMesa)
            {
                cbxMesa.DataSource = MesaNegocio.listar();
                cbxMesa.ValueMember = "numero";
                cbxMesa.SelectedIndex = 0;
                grillaMesa();
            }
            else if(tpbInforme.SelectedTab == tpgDia)
            {
                grillaDia();
            }

        }
        private void TpbInforme_SelectedIndexChanged(object sender, EventArgs e)
        {
            visible();
        }
        public void grillaMesero()
        {
            try
            {
                List<informeMesero> lista= InformeNegocio.listarRecauddoeMesero(dtpDesdeMesero.Value.Date, dtpHastaMesero.Value.Date, ((Personal)cbxLegajo.SelectedItem).legajo);
                dgvListaMesero.DataSource = lista;
                dgvListaMesero.Columns["legajo"].Visible = false;
                dgvListaMesero.Columns["dia"].DisplayIndex = 0;
                dgvListaMesero.Columns["nombre"].DisplayIndex = 1;
                dgvListaMesero.Columns["cantidadPedidos"].DisplayIndex = 2;
                for (int i = 0; i < dgvListaMesero.Columns.Count; i++)
                {
                    dgvListaMesero.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                decimal total = 0;
                foreach (informeMesero item in lista)
                {
                    total += item.recaudado;
                }
                lblRecaudado.Text = total.ToString();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        public void grillaMesa()
        {
            try
            {
                List<informeMesa> lista= InformeNegocio.listarRecauddoeMesa(dtpDesdeMesa.Value.Date, dtpHastaMesa.Value.Date, ((Mesa)cbxMesa.SelectedItem).numero);
                dgvListaMesa.DataSource =lista;
                dgvListaMesa.Columns["dia"].DisplayIndex = 0;
                dgvListaMesa.Columns["numero"].DisplayIndex = 1;
                dgvListaMesa.Columns["cantidadPedidos"].DisplayIndex = 2;

                for (int i = 0; i < dgvListaMesa.Columns.Count; i++)
                {
                    dgvListaMesa.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                decimal total = 0;
                foreach (informeMesa item in lista)
                {
                    total += item.recaudado;
                }
                lblRecaudado.Text = total.ToString();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public void grillaDia()
        {
            try
            {
                List<DatoInforme> lista = InformeNegocio.listarRecauddoeDia(dtpDesdeDia.Value.Date, dtpHastaDia.Value.Date);
                dgvListaDia.DataSource = lista;
                dgvListaDia.Columns["dia"].DisplayIndex=0;
                dgvListaDia.Columns["cantidadPedidos"].DisplayIndex = 1;
                for (int i = 0; i < dgvListaDia.Columns.Count; i++)
                {
                    dgvListaDia.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                decimal total = 0;
                foreach (DatoInforme item in lista)
                {
                    total += item.recaudado;
                }
                lblRecaudado.Text = total.ToString();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void TpgRecaudoMesa_Click(object sender, EventArgs e)
        {

        }

        private void FrmInformes_Load(object sender, EventArgs e)
        {
            visible();
        }

        private void BtnFiltrarMesas_Click(object sender, EventArgs e)
        {
            grillaMesa();
        }

        private void BtnBuscarMesero_Click(object sender, EventArgs e)
        {
            grillaMesero();
        }

        private void BtnBuscarDia_Click(object sender, EventArgs e)
        {
            grillaDia();
        }
    }
}
