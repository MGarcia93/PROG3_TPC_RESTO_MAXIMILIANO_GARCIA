using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class TipoPlatoNegocio
    {
        public List<TipoPlato> listaTipoPlato()
        {
            List<TipoPlato> listado = new List<TipoPlato>();
            ManagerAcessoDato acessoDatos = new ManagerAcessoDato();
            TipoPlato plato=new TipoPlato();
            try
            {
                acessoDatos.setearConsulta( "select id,descripcion from tiposplatos");
                acessoDatos.abrirConexion();
                acessoDatos.ejecutarConsulta();
                while (acessoDatos.Lector.Read())
                {
                    plato = new TipoPlato();
                    plato.id = (int)acessoDatos.Lector["id"];
                    plato.descripcion = (string)acessoDatos.Lector["descripcion"].ToString();
                    listado.Add(plato);
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
