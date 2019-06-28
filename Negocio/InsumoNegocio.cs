using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class InsumoNegocio
    {
        public static Insumo traer(int id)
        {
            ManagerAcessoDato accesoDatos = new ManagerAcessoDato();
            Insumo insumo;
            try
            {
                accesoDatos.setearConsulta("select i.id,isnull(c.nombre,b.descripcion) as nombre,isnull(c.precio,b.precio) as precio " +
                    "from Insumos as i left join bebidas as b on b.id=i.id left join comidas as c on c.id=i.id  " +
                    "where (c.estado=1  or b.estado=1) and i.id=" + id);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                if(accesoDatos.Lector.Read())
                {
                    insumo = new Insumo();
                    insumo.id = (int)accesoDatos.Lector["id"];
                    insumo.nombre = (string)accesoDatos.Lector["nombre"].ToString();
                    insumo.precio = (decimal)accesoDatos.Lector["precio"];
                }
                else
                {
                    insumo = null;
                }
                return insumo;
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

        public static List<DetalleMenu> Menu()
        {
            List<DetalleMenu> menu = new List<DetalleMenu>();
            ManagerAcessoDato db = new ManagerAcessoDato();
            DetalleMenu insumo;
            try
            {

                string sql = "select i.id,isnull(c.nombre,b.descripcion) as nombre,c.descripcion,isnull(tp.descripcion,cb.descripcion) as tipo, isnull(c.precio,b.precio) as precio ";
                sql += "from insumos i ";
                sql += "left join bebidas b on i.id = b.id ";
                sql += "left join comidas c on i.id = c.id ";
                sql += "left join tiposPlatos tp on c.idTipo = tp.id ";
                sql += "left join categoriasBebidas cb on b.idCategoriaBebida = cb.id ";
                sql += "where (b.estado=1 or c.estado=1) ";
                sql += "order by i.idTipo desc, tipo";
                db.setearConsulta(sql);
                db.abrirConexion();
                db.ejecutarConsulta();
                while (db.Lector.Read())
                {
                    insumo = new DetalleMenu();
                    insumo.id = (int)db.Lector["id"];
                    insumo.nombre = (string)db.Lector["nombre"];
                    if(!Convert.IsDBNull(db.Lector["descripcion"].ToString()))
                        insumo.descripcion = (string)db.Lector["descripcion"].ToString();
                    insumo.tipo = (string)db.Lector["tipo"].ToString();
                    insumo.precio = (decimal)db.Lector["precio"];
                    menu.Add(insumo);
                }
                return menu;
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
