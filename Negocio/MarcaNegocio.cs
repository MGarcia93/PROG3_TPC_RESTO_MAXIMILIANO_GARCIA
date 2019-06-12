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

        public static List<Marca> listadoMarca( int idCategoria)
        {
            List<Marca> listado = new List<Marca>();
            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            Marca marca;
            try
            {
                accesoDatos.setearConsulta("select m.id, m.descripcion from marcas as m inner join marcasXcategorias as mc on m.id=mc.idMarca" +
                    "  inner join categoriasBebidas as c on c.id = mc.idCategoria where c.estado=1 and m.estado=1 and c.id=" + idCategoria);
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
        public static Marca traer(int id)
        {
            Marca tipo = new Marca();
            ManagerAcessoDato acessoDato = new ManagerAcessoDato();
            try
            {
                acessoDato.setearConsulta("select descripcion from marcas where id=" + id);
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

        public static bool agregar(string descripcion, string idCategoria)
        {
            ManagerAcessoDato acessoDato = new ManagerAcessoDato();
            bool agrego=false;
            try
            {
                acessoDato.setearConsulta("insert into marcas(descripcion) values('" + descripcion + "')");
                acessoDato.abrirConexion();
                if (acessoDato.ejecutarAccion() == 1)
                {
                    // acessoDato.setearConsulta("insert into marcasXcategorias(idCategoria,idMarca) values ('"+idCategoria+"','"+")
                    agrego = true;
                }
                return agrego;
            
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
