using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class MarcaNegocio
    {

        public List<Marca> listadoMarca( string id)
        {
            List<Marca> listado = new List<Marca>();
            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            Marca marca;
            try
            {
                accesoDatos.setearConsulta("select m.id, m.descripcion from marcas as m inner join marcasXcategorias as mc on m.id=mc.idMarca where mc.idcategoria=" + id);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    marca = new Marca();
                    marca.id = (int)accesoDatos.Lector["id"];
                    marca.descripcion = (string)accesoDatos.Lector["descripcion"].ToString();
                    listado.Add(marca);
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
