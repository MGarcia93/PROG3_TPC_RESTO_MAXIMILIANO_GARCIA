using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tpc_Resto_Maximiliano_Garcia
{
    public partial class frmResto : Form
    {
        public frmResto()
        {
            InitializeComponent();
            Login login = new Login();
            login.MdiParent = this;
            login.Show();
        }

       
    }
}
