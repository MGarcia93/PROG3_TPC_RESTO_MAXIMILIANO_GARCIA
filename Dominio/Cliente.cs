using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Cliente:Persona
    {
        public List<Pedido> pedidos { get; set; }
        public Mesa mesa { get; set; }

    }
}
