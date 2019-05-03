using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Dominio;

namespace Negocio
{
    public class CategoriaBebidaNegocio
    {
        public List<Categoria> listadoCategoriaBebidas()
        {
            List<Categoria> listado = new List<Categoria>();
            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            Categoria categoria;
            try
            {
                accesoDatos.setearConsulta("select id,descripcion from categoriasBebidas");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    categoria = new Categoria();
                    categoria.id = (int)accesoDatos.Lector["id"];
                    categoria.descripcion = (string)accesoDatos.Lector["descripcion"].ToString();
                    listado.Add(categoria);
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
