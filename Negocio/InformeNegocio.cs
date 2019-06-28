using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class InformeNegocio
    {
        
        public static List<informeMesero> listarRecauddoeMesero(DateTime desde, DateTime hasta, int legajo)
        {
            ManagerAcessoDato db = new ManagerAcessoDato();
            List<informeMesero> listado = new List<informeMesero>();
            informeMesero dato;
            try
            {
                db.setearConsulta("select j.dia,m.nombre,m.apellido,SUM(dp.precioUnit) as recaudado,COUNT(p.id)  as cantidadPedidos from jornadas as j " +
                    "inner join pedidos as p on p.idJornada = j.id " +
                    "inner join detallesPedidos as dp on p.id = dp.idPedido " +
                    "inner   join personal as m on m.legajo = p.idMesero " +
                    "where dia between @desde and @hasta and m.legajo = @legajo" +
                    " group by j.dia, m.nombre, m.apellido");
                db.Comando.Parameters.Clear();
                db.Comando.Parameters.AddWithValue("@desde", desde);
                db.Comando.Parameters.AddWithValue("@hasta", hasta);
                db.Comando.Parameters.AddWithValue("@legajo", legajo);
                db.abrirConexion();
                db.ejecutarConsulta();
                while (db.Lector.Read())
                {
                    dato=new informeMesero();
                    dato.dia = (DateTime)db.Lector["dia"];
                    dato.nombre = (string)db.Lector["nombre"].ToString();
                    dato.apellido = (string)db.Lector["apellido"].ToString();
                    dato.recaudado = (decimal)db.Lector["recaudado"];
                    dato.cantidadPedidos = (int)db.Lector["cantidadPedidos"];
                    listado.Add(dato);
                }
                return listado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                db.cerrarConexion();
            }
        }


        public static List<DatoInforme> listarRecauddoeDia(DateTime desde, DateTime hasta)
        {
            ManagerAcessoDato db = new ManagerAcessoDato();
            List<DatoInforme> listado = new List<DatoInforme>();
            DatoInforme dato;
            try
            {
                db.setearConsulta("select j.dia,SUM(dp.precioUnit) as recaudado,COUNT(p.id)  as cantidadPedidos from jornadas as j " +
                    "inner join pedidos as p on p.idJornada = j.id " +
                    "inner join detallesPedidos as dp on p.id = dp.idPedido " +
                    "where dia between @desde and @hasta "+
                    " group by j.dia");
                db.Comando.Parameters.Clear();
                db.Comando.Parameters.AddWithValue("@desde", desde);
                db.Comando.Parameters.AddWithValue("@hasta", hasta);
                db.abrirConexion();
                db.ejecutarConsulta();
                while (db.Lector.Read())
                {
                    dato = new DatoInforme();
                    dato.dia = (DateTime)db.Lector["dia"];
                    dato.recaudado = (decimal)db.Lector["recaudado"];
                    dato.cantidadPedidos = (int)db.Lector["cantidadPedidos"];
                    listado.Add(dato);
                }
                return listado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                db.cerrarConexion();
            }
        }

        public static List<informeMesa> listarRecauddoeMesa(DateTime desde, DateTime hasta, int mesa)
        {
            ManagerAcessoDato db = new ManagerAcessoDato();
            List<informeMesa> listado = new List<informeMesa>();
            informeMesa dato;
            try
            {
                db.setearConsulta("select j.dia,m.numero,SUM(dp.precioUnit) as recaudado,COUNT(p.id)  as cantidadPedidos from jornadas as j " +
                    "inner join pedidos as p on p.idJornada = j.id " +
                    "inner join detallesPedidos as dp on p.id = dp.idPedido " +
                    "inner   join mesas as m on m.numero = p.idMesa " +
                    "where dia between Convert(date,'" + desde.ToShortDateString()+ "') and Convert(date,'" + hasta.ToShortDateString()+"') and m.numero = "+mesa +
                    " group by j.dia, m.numero");

                db.abrirConexion();
                db.ejecutarConsulta();
                while (db.Lector.Read())
                {
                    dato = new informeMesa();
                    dato.dia = (DateTime)db.Lector["dia"];
                    dato.numero = (int)db.Lector["numero"];
                    dato.recaudado = (decimal)db.Lector["recaudado"];
                    dato.cantidadPedidos = (int)db.Lector["cantidadPedidos"];
                    listado.Add(dato);
                }
                return listado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                db.cerrarConexion();
            }
        }
    }
}
