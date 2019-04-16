using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Pedido
    {
        public Estado estado { get; set; }
        public List<Insumo> insumos { get; set; }
    }
}
