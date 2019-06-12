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
    public partial class Sistema : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        [WebMethod]
        public static List<Mesa> ListaMesas()
        {

            List<Mesa> lista = new List<Mesa>();
            try
            {
                lista = MesaNegocio.listar();
                foreach (Mesa mesa in lista)
                {
                    
                    if (mesa.mesero==null || mesa.mesero.legajo.ToString()!= HttpContext.Current.Session["idUser"].ToString())
                    {
                        mesa.estado.id = 0;
                        mesa.estado.id = Constantes.MESA_INACTIVA;
                        mesa.estado.descripcion = "inactiva";
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        [WebMethod]
        public static Mesa mesaSeleccionada(int id)
        {
            Mesa mesa = new Mesa();
            try
            {
                mesa = MesaNegocio.traer(id);
                return mesa;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        [WebMethod]
        public static List<Almacenamiento> Buscar(int tipo)
        {
            List<Almacenamiento> insumos = JornadaNegocio.inventario((int)HttpContext.Current.Session["jornada"]);
            List<Almacenamiento> insumosTipo = new List<Almacenamiento>();
            foreach (Almacenamiento item in insumos)
            {
                if(item.tipo)
            }
        }
    }
}