﻿using System;
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
    public partial class frmMesaLista : Form
    {
        public frmMesaLista()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmMesaAsignar mesa = new frmMesaAsignar();
            mesa.ShowDialog();
        }
    }
}
