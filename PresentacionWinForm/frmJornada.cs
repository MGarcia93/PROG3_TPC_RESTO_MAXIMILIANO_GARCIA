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
    public partial class frmJornada : Form
    {
        List<Almacenamiento> inventario = new List<Almacenamiento>();
        public frmJornada()
        {
            InitializeComponent();
        }

        private void FrmJornada_Load(object sender, EventArgs e)
        {
            Grilla();
            mostrarMesas();
        }

        private void Grilla()
        {

            try
            {
                
                inventario = JornadaNegocio.inventario(Grobales.jornada);
                dgvLista.DataSource = inventario;
                dgvLista.EditMode = DataGridViewEditMode.EditOnEnter;
                dgvLista.Columns["descripcion"].ReadOnly=true;
                dgvLista.Columns["id"].ReadOnly = true;
                dgvLista.Columns["tipo"].ReadOnly = true;
                dgvLista.Columns["marca"].Visible = false;

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

        private void BtnGenera_Click(object sender, EventArgs e)
        {
            List<Almacenamiento> jornada = new List<Almacenamiento>();
            jornada = (List<Almacenamiento>)dgvLista.DataSource;
            Grobales.jornada = JornadaNegocio.altaDia();
            if(JornadaNegocio.AltaDiaInventario(jornada, Grobales.jornada))
            {
                MessageBox.Show("Se genero correctamente");
                btnModifica.Enabled = true;
                btnGenera.Visible = false;
            }
            else
            {
                MessageBox.Show("No se pudo generar");
                Grobales.jornada = 0;
            }
        }

        private void BtnModifica_Click(object sender, EventArgs e)
        {
            List<Almacenamiento> jornada = new List<Almacenamiento>();
            jornada = (List<Almacenamiento>)dgvLista.DataSource;
            foreach (Almacenamiento item in jornada)
            {
                if (JornadaNegocio.modificarCantidad(item.id,Grobales.jornada,item.cantidad))
                {
                    MessageBox.Show("Se modifico correctamente");
                }
                else
                {
                    MessageBox.Show("No se pudo modificar");
                }
            }
            
        }

        private void BtnGuardarDefault_Click(object sender, EventArgs e)
        {
            List<Almacenamiento> jornada = new List<Almacenamiento>();
            jornada = (List<Almacenamiento>)dgvLista.DataSource;
            foreach (Almacenamiento item in jornada)
            {
                if (JornadaNegocio.modificarCantidad(item.id, 0, item.cantidad))
                {
                    MessageBox.Show("Se modifico correctamente");
                }
                else
                {
                    MessageBox.Show("No se pudo modificar");
                }
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void mostrarMesas()
        {
            List<Mesa> mesas = new List<Mesa>();
            mesas = MesaNegocio.listar();
            int dezplazarX = 40;
            int dezplazarY = 20;
            foreach (Control item in tbpMesas.Controls)
            {
                tbpMesas.Controls.Remove(item);
            }
            List<ControlMesa> lista = new List<ControlMesa>();
            for (int i = 0; i < mesas.Count; i++)
            {
                if (i == 0)
                {
                    lista.Add(crearMesa(mesas[i], dezplazarX, dezplazarY));
                }
                else
                {
                    if (i / 5 > 0 && i % 5 == 0)
                    {
                        lista.Add(crearMesa(mesas[i], dezplazarX, lista[i - 1].Width + lista[i - 1].Location.Y + dezplazarY));
                    }
                    else
                    {
                        lista.Add(crearMesa(mesas[i], lista[i - 1].Height + lista[i - 1].Location.X + dezplazarX, lista[i - 1].Location.Y));
                    }
                }
            }
        }
        public ControlMesa crearMesa(Mesa dato, int x, int y)
        {
            ControlMesa mesa = new ControlMesa(dato.numero.ToString(), dato.estado.id, x, y, 100, 100, Constantes.MESA_JORNADA);//ventana lista de mes  es la 0
            mesa.mesa = dato;
            tbpMesas.Controls.Add(mesa);
            mesa.Visible = true;
            return mesa;

        }
    }
}
