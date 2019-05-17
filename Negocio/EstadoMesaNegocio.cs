using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class EstadoMesaNegocio
    {
        public static List<EstadoMesa> listaEstadoMesa()
        {
            List<EstadoMesa> listado = new List<EstadoMesa>();
            ManagerAcessoDato acessoDatos = new ManagerAcessoDato();
            EstadoMesa estado = new EstadoMesa();
            try
            {
                acessoDatos.setearConsulta("select id,descripcion from estadosMesas");
                acessoDatos.abrirConexion();
                acessoDatos.ejecutarConsulta();
                while (acessoDatos.Lector.Read())
                {
                    estado = new EstadoMesa();
                    estado.id = (int)acessoDatos.Lector["id"];
                    estado.descripcion = (string)acessoDatos.Lector["descripcion"].ToString();
                    listado.Add(estado);
                }
                return listado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                acessoDatos.cerrarConexion();
            }
        }

        public static EstadoMesa traer(int id)
        {
            EstadoMesa estado = new EstadoMesa();
            ManagerAcessoDato acessoDato = new ManagerAcessoDato();
            try
            {
                acessoDato.setearConsulta("select descripcion from estadosMesas where id=" + id);
                acessoDato.abrirConexion();
                acessoDato.ejecutarConsulta();
                acessoDato.Lector.Read();
                estado.id = id;
                estado.descripcion = (string)acessoDato.Lector["descripcion"];
                return estado;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                acessoDato.cerrarConexion();
            }
        }
    }
}
