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
        public  static List<Categoria> listadoCategoriaBebidas()
        {
            List<Categoria> listado = new List<Categoria>();
            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            Categoria categoria;
            try
            {
                accesoDatos.setearConsulta("select id,descripcion from categoriasBebidas  where estado=1");
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

        public static Categoria traer(int id)
        {
            Categoria tipo = new Categoria();
            ManagerAcessoDato acessoDato = new ManagerAcessoDato();
            try
            {
                acessoDato.setearConsulta("select descripcion from categoriasBebidas where id=" + id);
                acessoDato.abrirConexion();
                acessoDato.ejecutarConsulta();
                acessoDato.Lector.Read();
                tipo.id = id;
                tipo.descripcion = (string)acessoDato.Lector["descripcion"];
                return tipo;

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

        public static bool agregar(string nombre)
        {
            ManagerAcessoDato acessoDato = new ManagerAcessoDato();
            try
            {
                acessoDato.setearConsulta("insert into categoriasBebidas(descripcion) values('" + nombre+"')");
                acessoDato.abrirConexion();
                if (acessoDato.ejecutarAccion() == 1)
                {
                    return true;
                }
             
                return false;

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
