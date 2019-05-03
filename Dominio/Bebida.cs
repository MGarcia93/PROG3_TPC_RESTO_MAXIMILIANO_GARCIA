using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Bebida:Insumo
    {
        public Marca marca { get; set; }
        public Categoria categoria { get; set; }
        public bool contieneAlcohol { get; set; }
    }
}
