using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Mesa
    {
        public int id { get; set; }
        public int numero { get; set; }
        public Pedido pedido { get; set; }
        public Mesero mesero { get; set; }
        public int cantComensales { get; set; }
        public EstadoMesa  estado { get; set; }

    }
}
