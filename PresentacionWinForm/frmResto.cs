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
            frmGenerarPedido generarPedido = new frmGenerarPedido();
            generarPedido.MdiParent = this;
            generarPedido.Show();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCerrarPedido ventana = new frmCerrarPedido();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void verPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPedidosAbiertos listaPedido = new frmPedidosAbiertos();
            listaPedido.MdiParent = this;
            listaPedido.Show();
        }
    }
}
