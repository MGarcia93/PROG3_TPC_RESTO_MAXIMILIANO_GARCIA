using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Comida :Insumo
    {
        public string descripcion { get; set; }
        public TipoPlato tipoPlato { get; set; }
        public Comida()
        {
            tipo = new TipoInsumo();
            tipo.id = 2;
            tipo.descripcion = "Comida";
        }
    }
}
