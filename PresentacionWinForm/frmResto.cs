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

        private void AgregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBebidaLista bebida = new frmBebidaLista();
            bebida.MdiParent = this;
            bebida.Show();
            frmBebidaAgregar agregar = new frmBebidaAgregar();
            agregar.ShowDialog();
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
        private void ListaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBebidaLista bebida = new frmBebidaLista();
            bebida.MdiParent = this;
            bebida.Show();
        }

        private void ModificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBebidaLista bebida = new frmBebidaLista();
            bebida.MdiParent = this;
            bebida.Show();
            frmBebidaModificar modificar = new frmBebidaModificar();
            modificar.ShowDialog();
        }

        private void EliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBebidaLista bebida = new frmBebidaLista();
            bebida.MdiParent = this;
            bebida.Show();
            frmBebidaEliminar eliminar = new frmBebidaEliminar();
            eliminar.ShowDialog();
        }


        //ACCESO A VENTANAS DE PLATOS 
        private void ListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlatoLista plato = new frmPlatoLista();
            plato.MdiParent = this;
            plato.Show();
        }

        private void AgregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlatoLista plato = new frmPlatoLista();
            plato.MdiParent = this;
            plato.Show();

            frmPlatoAgregar agregar = new frmPlatoAgregar();
            agregar.Show();
        }

        private void ModificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlatoLista plato = new frmPlatoLista();
            plato.MdiParent = this;
            plato.Show();

            frmPlatoModificar modificar = new frmPlatoModificar();
            modificar.ShowDialog();
        }

        private void MesasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        // ACCESOS A VENTANAS  DE MESA

        private void VerAsignadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMesaLista mesa = new frmMesaLista();
            mesa.MdiParent = this;
            mesa.Show();
        }
        private void AsignarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMesaLista mesas = new frmMesaLista();
            mesas.MdiParent = this;
            mesas.Show();
            frmBebidaModificar asignar = new frmBebidaModificar();
            asignar.ShowDialog();
        }

        private void DesasignarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMesaLista mesas = new frmMesaLista();
            mesas.MdiParent = this;
            mesas.Show();
            frmMesaDesasignar desasignar = new frmMesaDesasignar();
            desasignar.ShowDialog();

        }


        // ACCESOS A CENTANAS DE PERSONAL


        private void ListarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonalLista personal = new frmPersonalLista();
            personal.MdiParent = this;
            personal.Show();
        }

        private void IngresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonalLista personal = new frmPersonalLista();
            personal.MdiParent = this;
            personal.Show();
            frmPersonalAgregar agregar = new frmPersonalAgregar();
            agregar.ShowDialog();
        }

        private void CerrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPersonalLista personal = new frmPersonalLista();
            personal.MdiParent = this;
            personal.Show();
            frmPersonalModificar modificar = new frmPersonalModificar();
            modificar.ShowDialog();
        }

        private void EliminarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmPersonalLista personal = new frmPersonalLista();
            personal.MdiParent = this;
            personal.Show();
            frmPersonalEliminar eliminar = new frmPersonalEliminar();
            eliminar.ShowDialog();
        }

        private void AgregarAlPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPedidoAgregar modificar = new frmPedidoAgregar();
            modificar.MdiParent = this;
            modificar.Show();
        }

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
    }
}
