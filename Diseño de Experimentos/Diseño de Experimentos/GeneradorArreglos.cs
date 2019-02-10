using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Diseño_de_Experimentos
{
    class GeneradorArreglos
    {

        private Random Rand;
        public int[] sinOrden { get; set; }
        public int[] OrdenAscendente { get; set; }
        public int[] OrdenDescendente { get; set; }

        public GeneradorArreglos(int exponente)
        {
            int tamaño = (int)Math.Pow(10, exponente);
            Rand = new Random();
            sinOrden = new int[tamaño];
            OrdenAscendente= new int[tamaño];
            OrdenDescendente= new int[tamaño];

            for(int i = 0; i < tamaño; i++)
            {
                int numero = Rand.Next(0,10000000);
                sinOrden[i] = numero;
            }
            OrdenAscendente = sinOrden.OrderBy(x => x).ToArray();
            OrdenDescendente = sinOrden.OrderByDescending(x => x).ToArray();
        }


    }
}
