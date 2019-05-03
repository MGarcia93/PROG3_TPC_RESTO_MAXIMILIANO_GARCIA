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
        
        public List<TipoInsumo> listadoTiposInsumos()
        {
            List<TipoInsumo> listado = new List<TipoInsumo>();
            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            TipoInsumo tipo;
            try
            {
                accesoDatos.setearConsulta("select id, descripcion from tiposinsumos");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    tipo = new TipoInsumo();
                    tipo.id = (int)accesoDatos.Lector["id"];
                    tipo.descripcion = (string)accesoDatos.Lector["descripcion"].ToString();
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
                accesoDatos.cerrarConexion();
            }

        }
    }
}
