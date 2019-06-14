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
                db.setearConsulta("insert into pedidos(idMesa,idMesero,idEstado) values (@idMesa,@idMesero,1)");
                db.Comando.Parameters.Clear();
                db.Comando.Parameters.AddWithValue("@idMesa", idMesa);
                db.Comando.Parameters.AddWithValue("@idMesero", idMesero);
                db.abrirConexion();
                if (db.ejecutarAccion() == 1)
                {
                    db.setearConsulta("select max(id) as id,idMesero,idMesa,idEstado from pedidos where idMesero=" + idMesero +" group by idMesero,idMesa,idEstado" );
                    db.ejecutarConsulta();
                    if (db.Lector.Read())
                    {
                        pedido.mesa = new Mesa();
                        pedido.mesero = new Mesero();
                        pedido.id = (int)db.Lector["id"];
                        pedido.mesa.id = (int)db.Lector["idMesa"];
                        pedido.mesero.legajo = (int)db.Lector["idMesero"];
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

        public static List<DetallePedido> detalle(int Pedido)
        {
            List<DetallePedido> lista = new List<DetallePedido>();
            ManagerAcessoDato db = new ManagerAcessoDato();
            DetallePedido detalle;
            var sql = "";
            try
            {
                sql = "select d.id, d.idInsumo,d.cantidad,d.precioUnit,isnull(b.descripcion,c.descripcion) as descripcion, isnull(cb.descripcion,tp.descripcion) as tipo ";
                sql +="from detallesPedidos d ";
                sql += "left join bebidas b on b.id=d.idInsumo ";
                sql += "left join comidas c on c.id=d.idInsumo ";
                sql += "left join tiposPlatos tp on c.idTipo = tp.id ";
                sql += "left join categoriasBebidas cb on b.idCategoriaBebida = cb.id ";
                sql += " where idPedido=" + Pedido;
                db.setearConsulta(sql);
                db.abrirConexion();
                db.ejecutarConsulta();
                while (db.Lector.Read())
                {
                    
                    detalle = new DetallePedido();
                    detalle.producto = new Insumo();
                    detalle.producto.id = (int)db.Lector["idInsumo"];
                    detalle.precioUnitario = (decimal)db.Lector["precioUnit"];
                    detalle.producto.nombre = (string)db.Lector["descripcion"];
                    detalle.tipo = (string)db.Lector["tipo"];
                    detalle.cantidad = (int)db.Lector["cantidad"];
                    detalle.precioTotal = detalle.cantidad * detalle.precioUnitario;
                    lista.Add(detalle);
                }
                return lista;
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
