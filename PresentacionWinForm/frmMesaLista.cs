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
    public partial class frmMesaLista : Form
    {
        List<Mesa> listado = new List<Mesa>();
        public frmMesaLista()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmBebidaModificar mesa = new frmBebidaModificar();
            mesa.ShowDialog();
        }

        private void FrmMesaLista_Load(object sender, EventArgs e)
        {
            
        }
    }
}
