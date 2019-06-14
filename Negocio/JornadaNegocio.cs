using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class JornadaNegocio
    {
        public static List<Almacenamiento> inventario(int dia=0)
        {
            List<Almacenamiento> inventario = new List<Almacenamiento>();   
            ManagerAcessoDato db = new ManagerAcessoDato();
            Almacenamiento insumo;
            try
            {

                string sql = "select i.idInsumo,isnull(c.nombre,b.descripcion) as descripcion,isnull(tp.descripcion,cb.descripcion) as tipo,i.cantidad ";
                sql += "from inventarios i ";
                sql += "inner join jornadas j on i.idJornada=j.id ";
                sql += "left join bebidas b on i.idInsumo = b.id ";
                sql += "left join comidas c on i.idInsumo = c.id ";
                sql += "left join tiposPlatos tp on c.idTipo = tp.id ";
                sql += "left join categoriasBebidas cb on b.idCategoriaBebida = cb.id ";
                sql += "where j.id=" + dia;
                db.setearConsulta(sql);
                db.abrirConexion();
                db.ejecutarConsulta();
                while (db.Lector.Read())
                {
                    insumo = new Almacenamiento();
                    insumo.cantidad = (int)db.Lector["cantidad"];
                    insumo.id = (int)db.Lector["idInsumo"];
                    insumo.descripcion = (string)db.Lector["descripcion"].ToString();
                    insumo.tipo = (string)db.Lector["tipo"].ToString();
                    inventario.Add(insumo);
                }
                return inventario;
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

        public static List<Almacenamiento> inventarioPorTipo(int dia, int tipo)
        {
            List<Almacenamiento> inventario = new List<Almacenamiento>();
            ManagerAcessoDato db = new ManagerAcessoDato();
            Almacenamiento insumo;
            try
            {

                string sql = "select i.idInsumo,isnull(c.nombre,b.descripcion) as descripcion,isnull(tp.descripcion,cb.descripcion) as tipo,m.descripcion as marca,i.cantidad ";
                sql += "from inventarios i ";
                sql += "inner join jornadas j on i.idJornada=j.id ";
                sql += "left join bebidas b on i.idInsumo = b.id ";
                sql += "left join comidas c on i.idInsumo = c.id ";
                sql += "left join tiposPlatos tp on c.idTipo = tp.id ";
                sql += "left join categoriasBebidas cb on b.idCategoriaBebida = cb.id ";
                sql += "left join marcas m on m.id=b.idMarca ";
                sql += "inner join insumos  on insumos.id=i.idInsumo ";
                sql += "inner join tiposInsumos ti on ti.id=insumos.idTipo ";
                sql += "where j.id=" + dia + " and ti.id="+ tipo;
                db.setearConsulta(sql);
                db.abrirConexion();
                db.ejecutarConsulta();
                while (db.Lector.Read())
                {
                    insumo = new Almacenamiento();
                    insumo.cantidad = (int)db.Lector["cantidad"];
                    insumo.id = (int)db.Lector["idInsumo"];
                    insumo.descripcion = (string)db.Lector["descripcion"].ToString();
                    insumo.tipo = (string)db.Lector["tipo"].ToString();
                    if (!Convert.IsDBNull((string)db.Lector["marca"].ToString()))
                        insumo.marca = (string)db.Lector["marca"].ToString();
                    inventario.Add(insumo);
                }
                return inventario;
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

        /* No sirve se imprementa en le inventario
        public static List<Almacenamiento> defeault()
        {
            List<Almacenamiento> inventario = new List<Almacenamiento>();
            ManagerAcessoDato db = new ManagerAcessoDato();
            Almacenamiento insumo;
            try
            {
                inventario = null;
                string sql = "select j.id,isnull(c.descripcion,b.descripcion) as descripcion,i.cantidad";
                sql += "from inventarios i";
                sql += "inner join jornadas j";
                sql += "left join bebidas b";
                sql += "left join comidas c";
                sql += "where j.id=0";
                db.setearConsulta(sql);
                db.abrirConexion();
                db.ejecutarConsulta();
                while (db.Lector.Read())
                {
                    insumo = new Almacenamiento();
                    insumo.cantidad = (int)db.Lector["cantidad"];
                    insumo.producto.id = (int)db.Lector["id"];
                    insumo.producto.nombre = (string)db.Lector["descripcion"].ToString();
                    inventario.Add(insumo);
                }
                return inventario;
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
        */

        public static int altaDia()
        {
            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            try
            {
                accesoDatos.setearConsulta("insert into jornadas(dia) values(getdate())");
                accesoDatos.abrirConexion();
                if (accesoDatos.ejecutarAccion() == 1)
                {
                    accesoDatos.setearConsulta("select max(id) as maximo from jornadas");
                    accesoDatos.ejecutarConsulta();
                    accesoDatos.Lector.Read();
                    return (int)accesoDatos.Lector["maximo"];
                }
                return -1;

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
        public static bool AltaDiaInventario( List<Almacenamiento> inventario,int id)
        {
            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            bool correcto = true;
            try
            {
                accesoDatos.abrirConexion();
                foreach (Almacenamiento dato in inventario)
                {
                    accesoDatos.setearConsulta("insert into inventarios( idJornada,idInsumo,cantidad) values(@idJornada,@idInsumo,@cantidad)");
                    accesoDatos.Comando.Parameters.Clear();
                    accesoDatos.Comando.Parameters.AddWithValue("@idInsumo", dato.id);
                    accesoDatos.Comando.Parameters.AddWithValue("@idJornada", id);
                    accesoDatos.Comando.Parameters.AddWithValue("@cantidad", dato.cantidad);
                    if (accesoDatos.ejecutarAccion() == 0)
                    {
                        correcto = false;
                    }

                }
                return correcto;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally{
                accesoDatos.cerrarConexion();
            }
            

        }

        public static bool modificarDefault(List<Almacenamiento> inventario)
        {
            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            bool error = false;
            try
            {
                accesoDatos.abrirConexion();
                foreach (Almacenamiento dato in inventario)
                {
                    accesoDatos.setearConsulta("update inventarios set @cantidad=@cantidad where idInsumo=@idInsumo and idJornada=@idJornada)");
                    accesoDatos.Comando.Parameters.Clear();
                    accesoDatos.Comando.Parameters.AddWithValue("@idInsumo", dato.id);
                    accesoDatos.Comando.Parameters.AddWithValue("@idJornada", 0);
                    accesoDatos.Comando.Parameters.AddWithValue("@cantidad", dato.cantidad);
                    if (accesoDatos.ejecutarAccion() == 0)
                    {
                        error = false;
                    }

                }
                return error;
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

        public static int numeroJornada()
        {
            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            try
            {
                accesoDatos.setearConsulta("select id from jornadas where cast(dia as date)=cast(getdate() as date) or (datediff(day,dia,getdate())<2 and datepart(hour,getdate())<5)");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                if (accesoDatos.Lector.Read())
                {
                    return (int)accesoDatos.Lector["id"];
                }
                return 0;
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
        
        public static int cantidadDisponible(int idInsumo,int idJornada)
        {
            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            try
            {
                accesoDatos.setearConsulta("select cantidad from inventarios idInsumo=@idInsumo and idjornada=@idJornada");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@idInsumo", idInsumo);
                accesoDatos.Comando.Parameters.AddWithValue("@idJornada", idJornada);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                if (accesoDatos.Lector.Read())
                {
                    return (int)accesoDatos.Lector["cantidad"];
                }
                return -1;
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

        public static bool modificarCantidad(int idInsumo,int idJornada, int cantidad)
        {
            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            try
            {
                accesoDatos.setearConsulta("update inventarios set cantidad=cantidad-@cantidad where idInsumo=@idInsumo and idjornada=@idJornada");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@idInsumo", idInsumo);
                accesoDatos.Comando.Parameters.AddWithValue("@idJornada", idJornada);
                accesoDatos.Comando.Parameters.AddWithValue("@cantidad", cantidad);
                accesoDatos.abrirConexion();
                if (accesoDatos.ejecutarAccion() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
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
