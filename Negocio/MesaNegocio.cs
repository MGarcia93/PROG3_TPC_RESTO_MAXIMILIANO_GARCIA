using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class MesaNegocio
    {
        public static List<Mesa> listar()
        {

            List<Mesa> listado = new List<Mesa>();
            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            Mesa mesa;
            try
            {
                accesoDatos.setearConsulta("select id,numero,idEstadoMesa,cantidadComensales,idMesero from Mesas");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    mesa = new Mesa();
                    mesa.id = (int)accesoDatos.Lector["id"];
                    mesa.numero = (int)accesoDatos.Lector["numero"];
                    mesa.cantComensales = (int)accesoDatos.Lector["cantidadComensales"];
                    mesa.estado = (EstadoMesa)EstadoMesaNegocio.traer((int)accesoDatos.Lector["idEstadoMesa"]);
                    if (!Convert.IsDBNull(accesoDatos.Lector["idMesero"]))
                        mesa.mesero=(Mesero)MeseroNegocio.traer((int)accesoDatos.Lector["idMesero"]);

                    listado.Add(mesa);
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

        public static bool agregar(Mesa dato)
        {
            bool inserto = false;
            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            try
            {
                accesoDatos.setearConsulta("insert into Mesas( Numero,idEstadoMesa,cantidadComensales) values(@Numero,@IdEstado,@cantComensales)");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Numero", dato.numero);
                accesoDatos.Comando.Parameters.AddWithValue("@IdEstado", 0); // Numero de estado inactivo con el que se seteara por default
                accesoDatos.Comando.Parameters.AddWithValue("@cantComensales", dato.cantComensales);
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

        public static bool modificar(Mesa dato)
        {
            bool modifico = false;
            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            try
            {
                accesoDatos.setearConsulta("update Mesas Set Numero=@Numero, idEstadoMesa=@idEstado, cantidadComensales=@cantComensales, idMesero=@idMesero where id=" + dato.id);
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Numero", dato.numero);
                accesoDatos.Comando.Parameters.AddWithValue("@IdEstado", dato.estado.id);
                accesoDatos.Comando.Parameters.AddWithValue("@cantComensales", dato.cantComensales);
                if (dato.mesero != null)
                    accesoDatos.Comando.Parameters.AddWithValue("@idMesero", dato.mesero.legajo);
                else
                    accesoDatos.Comando.Parameters.AddWithValue("@idMesero", null);
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
        public static bool eliminar(string numero)
        {
            bool modifico = false;
            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            try
            {
                accesoDatos.setearConsulta("delete from Mesas where numero=" + numero);
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

        public static int ActualizarAsignacion(string mesa,string mesero="-1")
        {
            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            try
            {
                if(mesero!="-1")
                {
                    accesoDatos.setearConsulta("update mesas set idmesero=" + mesero + " where id=" + mesa);
                }
                else
                {
                    accesoDatos.setearConsulta("update mesas set idmesero=null where numero=" + mesa);

                }
                
                accesoDatos.abrirConexion();
                return accesoDatos.ejecutarAccion();

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

        public static Mesa traer(int id)
        {
            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            Mesa mesa=new Mesa();
            try
            {
                accesoDatos.setearConsulta("select id,numero,idEstadoMesa,cantidadComensales,idMesero from Mesas where id="+id);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                accesoDatos.Lector.Read();
                mesa = new Mesa();
                mesa.id = (int)accesoDatos.Lector["id"];
                mesa.numero = (int)accesoDatos.Lector["numero"];
                mesa.cantComensales = (int)accesoDatos.Lector["cantidadComensales"];
                mesa.estado = (EstadoMesa)EstadoMesaNegocio.traer((int)accesoDatos.Lector["idEstadoMesa"]);
                if (!Convert.IsDBNull(accesoDatos.Lector["idMesero"]))
                    mesa.mesero = (Mesero)MeseroNegocio.traer((int)accesoDatos.Lector["idMesero"]);
                return mesa;
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
        public static int Numero()
        {
            int numero;
            ManagerAcessoDato acessoDato = new ManagerAcessoDato();
            try
            {
                acessoDato.setearConsulta("select isNUll(max(numero)+1,1) as numero from mesas");
                acessoDato.abrirConexion();
                acessoDato.ejecutarConsulta();
                acessoDato.Lector.Read();
                numero = (int)acessoDato.Lector["numero"];
                return numero;
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
