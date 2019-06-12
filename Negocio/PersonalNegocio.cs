using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class PersonalNegocio
    {

        public static List<Personal> listar(string cargo="'1' or 1=1")
        {

            List<Personal> listado = new List<Personal>();
            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            Personal personal;
            try
            {

                accesoDatos.setearConsulta("select legajo,nombre,apellido,dni,sexo,cargo,fechaNacimiento from personal where estado=1 and (cargo=" + cargo +")");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    personal = new Personal();
                    personal.legajo = (int)accesoDatos.Lector["legajo"];
                    personal.nombre = (string)accesoDatos.Lector["nombre"].ToString();
                    personal.apellido = (string)accesoDatos.Lector["apellido"].ToString();
                    personal.dni = (string)accesoDatos.Lector["dni"].ToString();
                    personal.sexo = (string)accesoDatos.Lector["sexo"].ToString();
                    personal.cargo = (string)accesoDatos.Lector["cargo"].ToString();
                    personal.fechaNacimiento = (DateTime)accesoDatos.Lector["fechaNacimiento"];
                    personal.edad=DateTime.Today.AddTicks(-personal.fechaNacimiento.Ticks).Year - 1;
                    listado.Add(personal);
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
        public static Personal traer(string legajo)
        {


            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            Personal personal = null;
            try
            {
                personal = new Personal();
                accesoDatos.setearConsulta("select legajo,nombre,apellido,dni,sexo,cargo,fechaNacimiento from personal where estado=1 and legajo="+legajo);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                if (accesoDatos.Lector.Read())
                {

                    personal.legajo = (int)accesoDatos.Lector["legajo"];
                    personal.nombre = (string)accesoDatos.Lector["nombre"].ToString();
                    personal.apellido = (string)accesoDatos.Lector["apellido"].ToString();
                    personal.dni = (string)accesoDatos.Lector["dni"].ToString();
                    personal.sexo = (string)accesoDatos.Lector["sexo"].ToString();
                    personal.cargo = (string)accesoDatos.Lector["cargo"].ToString();
                    personal.fechaNacimiento = (DateTime)accesoDatos.Lector["fechaNacimiento"];
                    personal.edad = DateTime.Today.AddTicks(-personal.fechaNacimiento.Ticks).Year - 1;

                }
                return personal;
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

        public bool agregar(Personal dato)
        {
            bool inserto = false;
            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            try
            {
                accesoDatos.setearConsulta("insert into Personal(nombre,apellido,dni,sexo,cargo,fechaNacimiento) values(@nombre,@apellido,@dni,@sexo,@cargo,@fechaNacimiento)");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@nombre", dato.nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@apellido", dato.apellido);
                accesoDatos.Comando.Parameters.AddWithValue("@sexo", dato.sexo);
                accesoDatos.Comando.Parameters.AddWithValue("@dni", dato.dni);
                accesoDatos.Comando.Parameters.AddWithValue("@cargo", dato.cargo);
                accesoDatos.Comando.Parameters.AddWithValue("@fechaNacimiento", dato.fechaNacimiento);
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
        }

        

        public static bool modificar(Personal dato)
        {
            bool modifico = false;
            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            try
            {
                accesoDatos.setearConsulta("update Personal Set nombre=@nombre, apellido=@apellido, sexo=@sexo, dni=@dni, cargo=@cargo, fechaNacimiento=@fechaNacimiento  where legajo=" + dato.legajo);
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@nombre", dato.nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@apellido", dato.apellido);
                accesoDatos.Comando.Parameters.AddWithValue("@sexo", dato.sexo);
                accesoDatos.Comando.Parameters.AddWithValue("@dni", dato.dni);
                accesoDatos.Comando.Parameters.AddWithValue("@cargo", dato.cargo);
                accesoDatos.Comando.Parameters.AddWithValue("@fechaNacimiento", dato.fechaNacimiento);
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
        public static bool eliminar(Personal dato)
        {
            bool modifico = false;
            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            try
            {
                accesoDatos.setearConsulta("update Personal set estado=0 where legajo=" + dato.legajo);
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
