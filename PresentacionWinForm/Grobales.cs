using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace PresentacionWinForm
{
    public static class Grobales
    {
        public static Dominio.Usuario usuario { get; set; }
        public static int jornada { get; set; }

        public static void iniciazion()
        {
            usuario = null;
            jornada = -1;
        }
    }
}
