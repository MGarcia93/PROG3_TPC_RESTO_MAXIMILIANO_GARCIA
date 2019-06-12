using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class MeseroNegocio:PersonalNegocio
    {

        public static Mesero traer(int legajo)
        {
            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            Mesero mesero = new Mesero();
            try
            {
                accesoDatos.setearConsulta("select legajo,nombre,apellido,dni,sexo from personal where  legajo="+legajo);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                accesoDatos.Lector.Read();
                mesero.legajo = (int)accesoDatos.Lector["legajo"];
                mesero.nombre = (string)accesoDatos.Lector["nombre"].ToString();
                mesero.apellido = (string)accesoDatos.Lector["apellido"].ToString();
                mesero.dni = (string)accesoDatos.Lector["dni"].ToString();
                mesero.sexo = (string)accesoDatos.Lector["sexo"].ToString();
                return mesero;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

            }
        }

    }
}
