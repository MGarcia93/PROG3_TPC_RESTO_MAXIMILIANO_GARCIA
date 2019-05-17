using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Mesero :Personal
    {
        public List<Pedido> pedidos { get; set; }
        public List<Mesa> mesas { get; set; }

        public Mesero()
        {
            cargo = "mesero";
        }
    }
}
