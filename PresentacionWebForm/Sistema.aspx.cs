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
            if (Session["Jornada"] == null || Session["Jornada"].ToString() == "0")
            {
                Session["Jornada"] = JornadaNegocio.numeroJornada();
                if (Session["Jornada"].ToString() == "0")
                {
                    MesaNegocio.inactivar();
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "show", "document.querySelector('#inactivo').style.display='block';", true);
                }

            }

        }


        [WebMethod]
        public static List<Almacenamiento> Buscar(string tipo)
        {
            return JornadaNegocio.inventarioPorTipo((int)HttpContext.Current.Session["jornada"], Convert.ToInt32(tipo));

        }


        [WebMethod]
        public static string InsumosTipo(int tipo)
        {
            return "retorno";
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
                if (mesa.pedido != null)
                {
                    HttpContext.Current.Session.Add("pedido", mesa.pedido.id);
                }
                else
                {
                    if(HttpContext.Current.Session["pedido"]!=null)
                        HttpContext.Current.Session.Remove("pedido");
                }
                
                return mesa;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [WebMethod]
        public static List<TipoInsumo> TiposInsumos()
        {
            return TipoInsumoNegocio.listar();
        }

        [WebMethod]
        public static int Generar(int mesa,int mesero)
        {
           Pedido pedido= PedidoNegocio.crear(mesero, mesa);
            HttpContext.Current.Session.Add("pedido", pedido.id);
            MesaNegocio.cambiarEstado(mesa, Constantes.MESA_OCUPADA);
            return pedido.id;
        }

        [WebMethod]
        public static bool Agregar(int idInsumo, int cantidad)
        {
            Insumo dato = InsumoNegocio.traer(idInsumo);
            return PedidoNegocio.agregar(dato, (int)HttpContext.Current.Session["pedido"],cantidad);
        }

        [WebMethod]
        public static List<DetallePedido> detallePedido()
        {
            int pedido;
            if (HttpContext.Current.Session["pedido"] != null)
            {
                pedido = (int)HttpContext.Current.Session["pedido"];
            }
            else
            {
                pedido = -1;
            }
            return PedidoNegocio.detalle(pedido);
        }

        [WebMethod]
        public static string CerrarPedido(int mesa)
        {
            string resultado;
            if (HttpContext.Current.Session["pedido"] != null)
            {
                if(PedidoNegocio.cambiarEstado(Constantes.PEDIDO_CERRADO, (int)HttpContext.Current.Session["pedido"]))
                {
                    MesaNegocio.cambiarEstado(mesa, Constantes.MESA_ACTIVA);
                    resultado= "ok";
                }
                else
                {
                    resultado= "NoCerrie";

                }

            }
            else
            {
                resultado= "noPedido";
            }
            return resultado;
        }
    }
}