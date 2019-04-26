using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Insumo
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public int precio { get; set; }
        public int cantidad { get; set; }
        public TipoInsumo tipo { get; set; }

    }
}
