using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class ControlMesa : System.Windows.Forms.PictureBox
    {
        private ReadOnlyCollection<string> url = new ReadOnlyCollection<string>(
            new List<String>{
                "..//..//imagenes//mesaInactiva.png","..//..//imagenes//mesa.png","..//..//imagenes//mesaOcupada.png"});
        public ContextMenuStrip menu { get; set; }
        public Mesa mesa { get; set; }
        public void mostrarTexto(string texto)
        {
            Label etiqueta = new Label();
            etiqueta.ForeColor = Color.Black;
            etiqueta.Location = new System.Drawing.Point(10, 10);
            etiqueta.Font = new Font(etiqueta.Font.Name, 25);
            etiqueta.Text = texto;
            etiqueta.Visible = true;

            this.Controls.Add(etiqueta);
            etiqueta.BringToFront();
        }
        public ControlMesa(string texto, int estado, int x, int y, int width, int height, int tipo)
        {
            this.Location = new System.Drawing.Point(x, y);
            this.Size = new System.Drawing.Size(width, height);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Image = new System.Drawing.Bitmap(url[estado]);
            this.texto(texto);
            cargarMenu(tipo);
            this.Click += new EventHandler(this.MenuMesa);
        }

        public override string ToString()
        {
            return this.mesa.numero.ToString();
        }

        public void texto(string texto)
        {
            Graphics g = Graphics.FromImage(this.Image);
            g.DrawString(texto, new Font("Arial", 200), Brushes.Black, new Rectangle(150, 150, 400, 400));
            g.Dispose();

        }
        public void MenuMesa(object sender, EventArgs e)
        {
            itemHabilitado();
            menu.Show(this, new Point(this.Size.Width / 2, this.Size.Height / 2));

        }

        private void itemHabilitado()
        {
            if (this.mesa.mesero == null)
            {
                menu.Items["Asignar"].Enabled = true;
                menu.Items["Desasignar"].Enabled = false;
            }
            else
            {
                menu.Items["Asignar"].Enabled = false;
                menu.Items["Desasignar"].Enabled = true;
            }
        }

        ///////////////////////////////////////
        ///Metodos de del contextmenu
        public void cargarMenu(int ventana)
        {
            menu = new ContextMenuStrip();
            
            ToolStripMenuItem item;
            if (ventana == 0)// valor de ventana Lista de mesa
            {
                item = new ToolStripMenuItem("Asignar");
                item.Click += new EventHandler(asignar);
                item.Name = "asignar";
                menu.Items.Add(item);
                item = new ToolStripMenuItem("Desasignar");
                item.Click += new EventHandler(desasignar);
                item.Name = "desasignar";
                menu.Items.Add(item);
                item = new ToolStripMenuItem("Modificar");
                item.Click += new EventHandler(modificar);
                item.Name = "modificar";
                menu.Items.Add(item);
                item = new ToolStripMenuItem("Eliminar");
                item.Click += new EventHandler(eliminar);
                item.Name = "eliminar";
                menu.Items.Add(item);

            }
            else
            {
                item = new ToolStripMenuItem("Cambiar Estado");
                item.Click += new EventHandler(cambiarEstado);
                item.Name = "cambiarEstado";
                menu.Items.Add(item);
            }


        }

     
        private void asignar(object sender, EventArgs e)
        {
            frmMesaAsignar ventana = new frmMesaAsignar();
            ventana.ShowDialog();
            mesa = MesaNegocio.traer(this.mesa.id);
        }
        private void modificar(object sender, EventArgs e)
        {
            frmMesaModificar ventana = new frmMesaModificar(this.mesa);
            ventana.ShowDialog();
        }
        private void eliminar(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas Seguro de eliminar esta mesa?"+ url[0],"ELIMINACION", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (MesaNegocio.eliminar(this.mesa.numero.ToString()))
                {
                    MessageBox.Show("Se elimino correctamente");
                    this.Parent.Controls.Remove(this);
                    Application.OpenForms.OfType<frmMesaLista>().SingleOrDefault().mostrarMesas();
                }
                else
                {
                    MessageBox.Show("No se Pudo Elimina la mesa");

                }
            }
        }
        private void desasignar(object sender, EventArgs e)
        {
            frmMesaDesasignar ventana = new frmMesaDesasignar(this.mesa.numero,this.mesa.mesero);
            ventana.ShowDialog();
            mesa = MesaNegocio.traer(this.mesa.id);


        }
        private void cambiarEstado(object sender, EventArgs e)
        {
            
        }
    }
}
