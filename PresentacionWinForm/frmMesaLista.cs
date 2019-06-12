using System;
using System.IO;
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
    public partial class frmMesaLista : Form
    {


        List<ControlMesa> listado = new List<ControlMesa>();
        public frmMesaLista()
        {
            InitializeComponent();
        }

        private void BtnAsirnar_Click(object sender, EventArgs e)
        {
            frmMesaAsignar mesa = new frmMesaAsignar();
            mesa.ShowDialog();
            mostrarMesas();
        }

        private void FrmMesaLista_Load(object sender, EventArgs e)
        {
            

           mostrarMesas();
            
           
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            frmMesaAgregar agregar = new frmMesaAgregar();
            agregar.ShowDialog();
            mostrarMesas();
            
        }

 

        public void mostrarMesas()
        {
            List<Mesa> mesas = new List<Mesa>();
            mesas = MesaNegocio.listar();
            int dezplazarX = 40;
            int dezplazarY = 20;
            foreach (Control item in contenedor.Controls)
            {
                contenedor.Controls.Remove(item);
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
                    if (i / 5 > 0 && i%5==0)
                    {
                        lista.Add(crearMesa(mesas[i], dezplazarX, lista[i - 1].Width + lista[i - 1].Location.Y+ dezplazarY));
                    }
                    else
                    {
                        lista.Add(crearMesa(mesas[i], lista[i - 1].Height + lista[i - 1].Location.X+dezplazarX, lista[i - 1].Location.Y));
                    }
                }
            }
        }
        public ControlMesa crearMesa(Mesa dato, int x, int y)
        {
            ControlMesa mesa = new ControlMesa(dato.numero.ToString(), dato.estado.id,x,y,100,100,0);//ventana lista de mes  es la 0
            mesa.mesa = dato;
            contenedor.Controls.Add(mesa);
            mesa.Visible = true;
            mesa.ContextMenuStrip = cmsMenu;
            return mesa;
       
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
