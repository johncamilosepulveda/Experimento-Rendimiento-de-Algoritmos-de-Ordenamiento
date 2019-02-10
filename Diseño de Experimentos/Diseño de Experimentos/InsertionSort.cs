using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Diseño_de_Experimentos
{
    class InsertionSort
    {

        public long OrdenarInsertionSort(int[] arreglo)
        {

            Stopwatch sw = new Stopwatch();

            sw.Restart();
            sw.Start();

            int i, j,n, aux;
            n = arreglo.Length;
            for(i=1; i < n; i++)
            {
                aux = arreglo[i];
                j = i - 1;
                while (j >= 0 && arreglo[j] > aux)
                {
                    arreglo[j + 1] = arreglo[j];
                    j--;
                }
                arreglo[j + 1] = aux;
            }
            sw.Stop();

            long tiempo = (long)(sw.Elapsed.TotalMilliseconds * 1000000);

            return tiempo;
        }
        

    }
}
