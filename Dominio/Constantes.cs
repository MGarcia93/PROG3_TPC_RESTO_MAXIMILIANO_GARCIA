using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
     public class Constantes
    {
       // CONSTANTES GROBLAES PARA TODA LA SOLUCION

        // CONSTANTES DE LOS ESTADO DE MESAS
        public const int MESA_INACTIVA = 0;
        public const int MESA_ACTIVA = 1;
        public const int MESA_OCUPADA = 2;
        public const int MESA_RESERVADA = 3;

        // CONSTANTES DE PARA EL CONSTRUCTOR DE LAS MESAS
        public const int MESA_LISTA = 0;
        public const int MESA_JORNADA = 1;

        // TIPOS DE COMIDAS
        public const int TIPO_COMIDA = 2;
        public const int TIPO_BEBIDA = 1;

        //TIPOS DE USUARIOS 
        public const int CLIENTE = 3;
        public const int MESERO = 2;
        public const int GERENTE = 1;

        //ESTADOS DE LOS PEDIDOS
        public const int PEDIDO_ABIERTO = 1;
        public const int PEDIDO_CERRADO = 2;


        //TIPOS DE PLATOS DE COMIDA
        public const int TIPO_PLATO_ENTRADA = 2;
        public const int TIPO_PLATO_ENSALADA = 4;
        public const int TIPO_PLATO_PRINCIPAL = 1;
        public const int TIPO_PLATO_POSTRE = 2;




    }
}
