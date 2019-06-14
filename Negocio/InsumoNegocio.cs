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
        
    }
}
