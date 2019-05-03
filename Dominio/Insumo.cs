using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Insumo
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public TipoInsumo tipo { get; set; }
        public decimal precio { get; set; }

    }
}
