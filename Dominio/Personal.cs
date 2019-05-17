using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Personal :Persona
    {
        
        public int legajo { get; set; }
        public string cargo { get; set; }
        public DateTime fechaNacimiento { get; set; }
        
    }
}
