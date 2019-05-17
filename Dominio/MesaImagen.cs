using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dominio
{
    public partial class MesaImagen : System.Windows.Forms.PictureBox
    {
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
        public MesaImagen(string texto,string urlImagen, int x,int y, int width,int height,int tipo)
        {
            this.Location = new System.Drawing.Point(x, y);
            this.Size = new System.Drawing.Size(width, height);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Image = new System.Drawing.Bitmap(urlImagen);
            this.texto(texto);
            //cargarMenu(tipo);
            this.Click += new EventHandler(this.menuMesa);
            
        }

      

        public void texto(string texto)
        {
            Graphics g = Graphics.FromImage(this.Image);
            g.DrawString(texto, new Font("Arial", 200), Brushes.Black, new Rectangle(150, 150, 400, 400));
            g.Dispose();
        
        }
        public void menuMesa(object sender, EventArgs e)
        {
            menu.Show(this,new Point(this.Size.Width/2,this.Size.Height/2));
           
        }

        /*
        public void cargarMenu(int ventana)
        {
            menu = new ContextMenuStrip();
            ToolStripMenuItem item;
            if (ventana == 0)// valor de ventana Lista de mesa
            {
                item=new ToolStripMenuItem("Asignar");
                item.Click += new EventHandler(asignar);
                item.Name = "asignar";
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
            MessageBox.Show(this.mesa.numero.ToString());
        }
        private void modificar(object sender, EventArgs e)
        {
            MessageBox.Show(this.mesa.numero.ToString());
        }
        private void eliminar(object sender, EventArgs e)
        {
            MessageBox.Show(this.mesa.numero.ToString());
        }
        private void desasignar(object sender, EventArgs e)
        {
            MessageBox.Show(this.mesa.numero.ToString());
        }
        private void cambiarEstado(object sender, EventArgs e)
        {
            MessageBox.Show(this.mesa.numero.ToString());
        }

    */
    }
}
