using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class TipoInsumoNegocio
    {

        public static List<TipoInsumo> listar()
        {
            List<TipoInsumo> listado = new List<TipoInsumo>();
            ManagerAcessoDato acessoDatos = new ManagerAcessoDato();
            TipoInsumo tipo = new TipoInsumo();
            try
            {
                acessoDatos.setearConsulta("select id,descripcion from tiposInsumos where estado=1");
                acessoDatos.abrirConexion();
                acessoDatos.ejecutarConsulta();
                while (acessoDatos.Lector.Read())
                {
                    tipo = new TipoInsumo();
                    tipo.id = (int)acessoDatos.Lector["id"];
                    tipo.descripcion = (string)acessoDatos.Lector["descripcion"].ToString();
                    listado.Add(tipo);
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
    }
}
