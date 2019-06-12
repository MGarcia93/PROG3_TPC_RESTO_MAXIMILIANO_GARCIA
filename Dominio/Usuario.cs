using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public string userName { get; set; }
        public string password { get; set; }
        public Persona datos { get; set; }
        public Usuario()
        {
            this.datos = new Persona();
        }
    }
}
