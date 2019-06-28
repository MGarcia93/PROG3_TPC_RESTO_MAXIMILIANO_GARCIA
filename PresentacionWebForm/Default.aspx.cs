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

        [WebMethod]
        public static List<DetalleMenu> listarMenu()
        {
            return InsumoNegocio.Menu();

        }

        [WebMethod]
        public static bool Acceso(string user, string pass)
        {
            bool valido = false;
            try
            {
                Usuario dato = new Usuario();
                dato = UsuarioNegocio.traer(user, pass);
                if (dato != null)
                {
                    HttpContext.Current.Session.Add("user", dato.datos);
                    HttpContext.Current.Session.Add("idUser", dato.userName);
                    HttpContext.Current.Session.Add("permiso", dato.datos.permiso.id);
                    valido = true;
                }

                return valido;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}