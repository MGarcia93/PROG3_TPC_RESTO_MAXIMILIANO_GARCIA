using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class UsuarioNegocio
    {
        public static List<Usuario> listar()
        {

            List<Usuario> listado = new List<Usuario>();
            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            Usuario usuario;
            try
            {

                accesoDatos.setearConsulta("select userName,pass,idPermiso from Usuarios where deleted=0");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    usuario = new Usuario();
                    usuario.userName = (string)accesoDatos.Lector["userName"].ToString();
                    usuario.password = (string)accesoDatos.Lector["pass"].ToString();
                    usuario.datos.permiso.id = (int)accesoDatos.Lector["idPermiso"];
                    if (usuario.datos.permiso.id == Constantes.CLIENTE)
                    {

                    }
                    else
                    {
                        Personal dato = new Personal();
                        dato = PersonalNegocio.traer(usuario.userName.ToString());
                        if (dato != null)
                        {
                            usuario.datos.apellido = dato.apellido;
                            usuario.datos.nombre = dato.nombre;
                        }
                    }
                    listado.Add(usuario);
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

        public static Usuario traer(string user, string pass)
        {

            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            Usuario usuario=null;
            try
            {
                accesoDatos.setearConsulta("select userName,pass,idPermiso from Usuarios where deleted=0 and pass=@pass and userName=@userName");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@userName", user);
                accesoDatos.Comando.Parameters.AddWithValue("@pass", pass);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                if (accesoDatos.Lector.Read())
                {
                    usuario = new Usuario();
                    usuario.userName = (string)accesoDatos.Lector["userName"].ToString();
                    usuario.password = (string)accesoDatos.Lector["pass"].ToString();

                    usuario.datos.permiso.id = (int)accesoDatos.Lector["idPermiso"];
                    if (usuario.datos.permiso.id == Constantes.CLIENTE)
                    {

                    }
                    else
                    {
                        Personal dato = new Personal();
                        dato = PersonalNegocio.traer(usuario.userName.ToString());
                        if (dato != null)
                        {
                            usuario.datos.apellido = dato.apellido;
                            usuario.datos.nombre = dato.nombre;
                        }
                    }

                }
                return usuario;
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

        //Falta hacer store procedure
        /*
        public bool agregar(Usuario dato)
        {

            bool inserto = false;
            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            try
            {
                accesoDatos.setearConsulta("insert into Usuarios(nombre,apellido,dni,sexo,cargo,fechaNacimiento) values(@nombre,@apellido,@dni,@sexo,@cargo,@fechaNacimiento)");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@nombre", dato.datos.nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@apellido", dato.datos.apellido);
                accesoDatos.Comando.Parameters.AddWithValue("@sexo", dato.datos.sexo);
                accesoDatos.Comando.Parameters.AddWithValue("@dni", dato.datos.dni);
                accesoDatos.Comando.Parameters.AddWithValue("@UserName", dato.userName);
                accesoDatos.Comando.Parameters.AddWithValue("@fechaNacimiento", dato.password);
                accesoDatos.Comando.Parameters.AddWithValue("@idPermiso", Constantes.CLIENTE);
                accesoDatos.abrirConexion();
                if (accesoDatos.ejecutarAccion() == 1)
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
        }*/

        public static bool modificar(Usuario dato)
        {
            bool modifico = false;
            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            try
            {
                accesoDatos.setearConsulta("update Usuarios Set pass=@pass, idPermiso=@idPermiso where userName=@userName ");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@pass", dato.password);
                accesoDatos.Comando.Parameters.AddWithValue("@idPermiso", dato.datos.permiso);
                accesoDatos.Comando.Parameters.AddWithValue("@userName", dato.userName);
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
        public static bool eliminar(Usuario dato)
        {
            bool modifico = false;
            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            try
            {
                accesoDatos.setearConsulta("update Usuarios set deleted=1 where userName=" + dato.userName);
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
    }
}
