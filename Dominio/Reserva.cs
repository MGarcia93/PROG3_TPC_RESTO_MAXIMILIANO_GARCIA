using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Reserva
    {
        public int id { get; set; }
        public Cliente cliente { get; set; }
        public Mesa mesa { get; set; }
    }
}
