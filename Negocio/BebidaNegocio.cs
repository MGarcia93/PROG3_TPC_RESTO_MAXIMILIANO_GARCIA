using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class BebidaNegocio
    {

        public static List<Bebida> listar()
        {
            List<Bebida> listado = new List<Bebida>();
            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            Bebida bebida;
            try
            {
                accesoDatos.setearConsulta("select id,descripcion,contieneAlcohol,precio,idMarca,idCategoriaBebida from bebidas  where estado=1");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    bebida = new Bebida();
                    bebida.id = (int)accesoDatos.Lector["id"];
                    bebida.nombre = (string)accesoDatos.Lector["descripcion"].ToString();
                    bebida.contieneAlcohol = (bool)accesoDatos.Lector["contieneAlcohol"];
                    bebida.precio = (decimal)accesoDatos.Lector["precio"];
                    bebida.marca = MarcaNegocio.traer((int)accesoDatos.Lector["idMarca"]);
                    bebida.categoria = CategoriaBebidaNegocio.traer((int)accesoDatos.Lector["idCategoriaBebida"]);
                    listado.Add(bebida);
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

        public bool agregar(Bebida dato)
        {
            bool inserto = false;
            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            try
            {
                accesoDatos.setearConsulta("insert into bebidas( descripcion,contieneAlcohol,precio,idMarca,idCategoriaBebida) values(@descripcion,@contieneAlcohol,@precio,@idMarca,@idCategoriaBebida)");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@descripcion", dato.nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@contieneAlcohol", dato.contieneAlcohol);
                accesoDatos.Comando.Parameters.AddWithValue("@precio", dato.precio);
                accesoDatos.Comando.Parameters.AddWithValue("@idMarca", dato.marca.id);
                accesoDatos.Comando.Parameters.AddWithValue("@idCategoriaBebida", dato.categoria.id);
                accesoDatos.abrirConexion();
                if (accesoDatos.ejecutarAccion() > 0)
                {
                    inserto = true;
                }
                return inserto;

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

        public static bool modificar(Bebida dato)
        {
            bool modifico = false;
            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            try
            {
                accesoDatos.setearConsulta("update bebidas Set descripcion=@descripcion, ContieneAlcohol=@contieneAlcohol, precio=@precio, idMarca=@idMarca, idCategoriaBebida=@idCategoria where id=" + dato.id);
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@descripcion", dato.nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@contieneAlcohol", dato.contieneAlcohol);
                accesoDatos.Comando.Parameters.AddWithValue("@precio", dato.precio);
                accesoDatos.Comando.Parameters.AddWithValue("@idMarca", dato.marca.id);
                accesoDatos.Comando.Parameters.AddWithValue("@idCategoria", dato.categoria.id);
                accesoDatos.abrirConexion();
                if (accesoDatos.ejecutarAccion() == 1)
                {
                    modifico = true;
                }
                return modifico;

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
        public static bool eliminar(Bebida dato)
        {
            bool modifico = false;
            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            try
            {
                accesoDatos.setearConsulta("delete from comidas where id=" + dato.id);
                accesoDatos.abrirConexion();
                if (accesoDatos.ejecutarAccion()> 0)
                {
                    modifico = true;
                }
                return modifico;

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
