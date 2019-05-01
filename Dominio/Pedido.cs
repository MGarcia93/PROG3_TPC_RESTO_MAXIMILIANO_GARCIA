using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Pedido
    {
        public int id { get; set; }
        public EstadoPedido estado { get; set; }
        public List<DetallePedido> insumos { get; set; }
        public DateTime fecha { get; set; }
        public Mesa mesa { get; set; }
        public Mesero mesero { get; set; }
    }
}
