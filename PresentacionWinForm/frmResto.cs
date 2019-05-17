using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionWinForm
{
    public partial class frmResto : Form
    {
        public frmResto()
        {
            InitializeComponent();

            frmLogin login = new frmLogin();
            login.MdiParent = this;
            login.Show();
        }

       

        private void MarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarcaAgregar marca = new frmMarcaAgregar();
            marca.ShowDialog();
        }


        private void cerrarVentana()
        {

            this.MdiChildren[0].Close();

        }

        private void FrmResto_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 1)
            {
                cerrarVentana();
            }

        }

        // acceso a las ventanas de bebidas 
        private void BebidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBebidaLista bebida = new frmBebidaLista();
            bebida.MdiParent = this;
            bebida.Show();
        }


        //ACCESO A VENTANAS DE PLATOS 

        private void PlatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlatoLista plato = new frmPlatoLista();
            plato.MdiParent = this;
            plato.Show();

        }


        

          /*ACCESSO A LAS VENTANAS DE PEDIDO
           */
        private void AgregarAlPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPedidoAgregar modificar = new frmPedidoAgregar();
            modificar.MdiParent = this;
            modificar.Show();
        }


        private void generarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPedidoGenerar generarPedido = new frmPedidoGenerar();
            generarPedido.MdiParent = this;
            generarPedido.Show();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPedidoCerrar ventana = new frmPedidoCerrar();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void verPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPedidosLista listaPedido = new frmPedidosLista();
            listaPedido.MdiParent = this;
            listaPedido.Show();
        }



        /*ACCESO A LAS VENTANAS DE RESUMENES*/
        private void PedidosPorMesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmResumenRecaudadoMesa resumen = new frmResumenRecaudadoMesa();
            resumen.MdiParent = this;
            resumen.Show();
        }

        private void PedidosPorMeserosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmResumenRecaudadoMesero resumen = new frmResumenRecaudadoMesero();
            resumen.MdiParent = this;
            resumen.Show();
        }
        


        /*Ventana de personal*/
        private void UsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonalLista personal = new frmPersonalLista();
            personal.MdiParent = this;
            personal.Show();
        }

        private void MesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMesaLista mesa = new frmMesaLista();
            mesa.MdiParent = this;
            mesa.Show();
        }
    }
}
