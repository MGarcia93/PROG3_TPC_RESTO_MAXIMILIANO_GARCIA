using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class ComidaNegocio
    {
        public List<Comida> listar()
        {
            
            List<Comida> listado = new List<Comida>();
            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            Comida plato;
            try
            {
                accesoDatos.setearConsulta("select id,nombre,descripcion,precio,idTipo from comidas  where estado=1");
                 accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    plato = new Comida();
                    plato.descripcion = (string) accesoDatos.Lector["descripcion"].ToString();
                    plato.id = (int)accesoDatos.Lector["id"];
                    plato.nombre = (string)accesoDatos.Lector["nombre"].ToString();
                    plato.precio = (decimal)accesoDatos.Lector["precio"];
                    plato.tipoPlato = TipoPlatoNegocio.traer((int)accesoDatos.Lector["idTipo"]);
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
                accesoDatos.cerrarConexion();
            }
        }

        public bool agregar(Comida dato)
        {
            bool inserto = false;
            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            try
            {
                accesoDatos.setearConsulta("insert into comidas( Nombre,descripcion,precio,idTipo) values(@Nombre,@descripcion,@precio,@idTipo)");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Nombre", dato.nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@descripcion", dato.descripcion);
                accesoDatos.Comando.Parameters.AddWithValue("@precio", dato.precio);
                accesoDatos.Comando.Parameters.AddWithValue("@idTipo", dato.tipoPlato.id);
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

        public  static bool modificar(Comida dato)
        {
            bool modifico = false;
            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            try
            {
                accesoDatos.setearConsulta("update comidas Set Nombre=@Nombre, descripcion=@descripcion, precio=@precio, idTipo=@idTipo where id=" + dato.id);
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Nombre", dato.nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@descripcion", dato.descripcion);
                accesoDatos.Comando.Parameters.AddWithValue("@precio", dato.precio);
                accesoDatos.Comando.Parameters.AddWithValue("@idTipo", dato.tipoPlato.id);
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
        public static bool eliminar(Comida dato)
        {
            bool modifico = false;
            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            try
            {
                accesoDatos.setearConsulta("delete from comidas id=" + dato.id);
                accesoDatos.abrirConexion();
                if (accesoDatos.ejecutarAccion() > 0)
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
