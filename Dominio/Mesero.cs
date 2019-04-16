using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Mesero:Personal
    {
        public List<Pedido> pedidos { get; set; }
    }
}
