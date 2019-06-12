using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using Dominio;
using Negocio;


namespace PresentacionWebForm
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public static Carta listarMenu()
        {
            Carta lista = new Carta();
            ComidaNegocio negocio = new ComidaNegocio();
            lista.comidas = negocio.listar();
            lista.bebidas = BebidaNegocio.listar();
            return lista;

        }
    }
}