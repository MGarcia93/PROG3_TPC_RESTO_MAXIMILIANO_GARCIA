using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Mesa
    {
        public int numero { get; set; }
        public List<Pedido> pedidos { get; set; }
        public Mesero mesero { get; set; }
        public int cantComensales { get; set; }
        public bool ocuapado { get; set; }

    }
}
