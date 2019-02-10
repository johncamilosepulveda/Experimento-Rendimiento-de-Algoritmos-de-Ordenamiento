using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Diseño_de_Experimentos
{
    class BubbleSort
    {

        public long OrdenarBubbleSort(int[] arreglo)
        {

            Stopwatch sw = new Stopwatch();

            sw.Restart();
            sw.Start();

            int n = arreglo.Length;
            for (int i=2; i < n; i++)
            {
                for(int j=0; j <= (n - i); j++)
                {
                    if (arreglo[j] > arreglo[j + 1])
                    {
                        int aux = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = aux;
                    }
                }
            }
            sw.Stop();

            long tiempo = (long)(sw.Elapsed.TotalMilliseconds * 1000000);

            return tiempo;
        }




    }
}
