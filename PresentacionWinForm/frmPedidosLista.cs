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

namespace PresentacionWinForm
{
    public partial class frmPedidosLista : Form
    {
        List<Pedido> listado = new List<Pedido>();
        public frmPedidosLista()
        {
            InitializeComponent();
        }

        private void FrmPedidosLista_Load(object sender, EventArgs e)
        {
            dgvPedidos.DataSource = listado;

        }
    }
}
