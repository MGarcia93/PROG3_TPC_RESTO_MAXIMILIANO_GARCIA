using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;


namespace Negocio
{
    public class PedidoNegocio
    {
        public static Pedido crear(int idMesero,int idMesa)
        {
            ManagerAcessoDato db = new ManagerAcessoDato();
            Pedido pedido = new Pedido();
            try
            {
                db.setearConsulta("insert into(idMesa,idMesero) values (@idMesa,@idMesero)");
                db.Comando.Parameters.Clear();
                db.Comando.Parameters.AddWithValue("@idMesa", idMesa);
                db.Comando.Parameters.AddWithValue("@idMesero", idMesero);
                db.abrirConexion();
                if (db.ejecutarAccion() == 1)
                {
                    db.setearConsulta("select max(id),idMesero,idMesa,idEstado from pedidos group by idMesero,idMesa,idEstado where idMesero=" + idMesero);
                    db.ejecutarConsulta();
                    if (db.Lector.Read())
                    {
                        pedido.id = (int)db.Lector["id"];
                        pedido.mesa.id = (int)db.Lector["idMesa"];
                        pedido.mesero.legajo = (int)db.Lector["idMesero"];
                        pedido.estado.id = (int)db.Lector["idEstado"];
                    }
                }
                else
                {
                    pedido = null;
                }
                return pedido;

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

        public static bool agregar(Insumo datos,int id,int cantidad)
        {
            ManagerAcessoDato db = new ManagerAcessoDato();
            try
            {
                db.setearConsulta("insert into detallesPedidos(idInsumo,cantidad,precioUnit,idPedido) values(@idInsumo,@cantidad,@precio,@idPedido)");
                db.Comando.Parameters.Clear();
                db.Comando.Parameters.AddWithValue("@idInsumo",datos.id);
                db.Comando.Parameters.AddWithValue("@cantidad",cantidad);
                db.Comando.Parameters.AddWithValue("@precio",datos.precio);
                db.Comando.Parameters.AddWithValue("@idPedido",id);
                db.abrirConexion();
                if (db.ejecutarAccion()==1)
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
                db.cerrarConexion();
            }

        }

        public static bool modificarDetalle(Insumo datos, int idPedido, int cantidad)
        {
            ManagerAcessoDato db = new ManagerAcessoDato();
            try
            {
                db.setearConsulta("update detallesPedidos cantidad=@idCantidad,precioUnit=@precio where idPedido=@idPedido and idInsumo=@idInsumo");
                db.Comando.Parameters.Clear();
                db.Comando.Parameters.AddWithValue("@idInsumo", datos.id);
                db.Comando.Parameters.AddWithValue("@cantidad", cantidad);
                db.Comando.Parameters.AddWithValue("@precio", datos.precio);
                db.Comando.Parameters.AddWithValue("@idPedido", idPedido);
                db.abrirConexion();
                if (db.ejecutarAccion() == 1)
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
                db.cerrarConexion();
            }
        }

        public static Pedido detalle(Pedido pedido)
        {
            ManagerAcessoDato db = new ManagerAcessoDato();
            DetallePedido detalle;
            var sql = "";
            pedido.insumos = null;
            try
            {
                sql = "select d.id, d.idInsumo,d.cantidad,d.precioUnit,isnull(b.descripcion,c.descripcion), tp.id as idTipo,tp.descripcion as tipoDescripcion";
                sql +="from detallesPedidos d";
                sql += "left join bebidas b on b.id=d.idInsumo";
                sql += "left join comidas c on c.id=d.idInsumo";
                sql += "inner join insumos i on i.id=d.idInsumo";
                sql += "inner join tiposPlatos tp on tp.id=i.idTipo";
                sql += " where idPedido=" + pedido.id;
                db.abrirConexion();
                db.ejecutarConsulta();
                while (db.Lector.Read())
                {
                    detalle = new DetallePedido();
                    detalle.producto.id = (int)db.Lector["idInsumos"];
                    detalle.precioUnitario = (decimal)db.Lector["precioUnit"];
                    detalle.producto.nombre = (string)db.Lector["descripcion"];
                    detalle.producto.tipo.id = (int)db.Lector["idTipo"];
                    detalle.producto.tipo.descripcion = (string)db.Lector["tipoDescripcion"];
                    pedido.insumos.Add(detalle);
                }
                return pedido;
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

        public static bool cambiarEstado(int estado,int id)
        {
            ManagerAcessoDato db = new ManagerAcessoDato();
            try
            {
                db.setearConsulta("update pedidos set idEstado=" + estado + " where id=" + estado);
                db.abrirConexion();
                if (db.ejecutarAccion() == 1)
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
                db.cerrarConexion();
            }
        }

    }
}
