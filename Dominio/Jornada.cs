using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Jornada
    {
        public int id { get; set; }
        public List<Mesa> mesas { get; set; }
        public DateTime dia { get; set; }
    }
}
