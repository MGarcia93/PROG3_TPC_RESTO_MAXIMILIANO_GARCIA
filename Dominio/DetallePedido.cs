using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class DetallePedido
    {
        public int id { get; set; }
        public Insumo producto { get; set; }
        public string tipo { get; set; }
        public int cantidad { get; set; }
        public decimal precioUnitario { get; set; }
        public decimal precioTotal { get; set; }
    }
}
