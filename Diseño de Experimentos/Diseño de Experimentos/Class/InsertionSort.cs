using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Diseño_de_Experimentos
{
    public class InsertionSort
    {

        public static long OrdenarInsertionSort(int[] arreglo)
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

        public static int LinesInsertionSort(int[] arreglo)
        {

            int lines = 0;

            int i, j, n, aux;
            lines += 4;
            n = arreglo.Length;
            lines++;
            for (i = 1; i < n; i++)
            {
                lines += 3;
                aux = arreglo[i];
                lines++;
                j = i - 1;
                lines++;
                while (j >= 0 && arreglo[j] > aux)
                {
                    
                    lines += 2;
                    arreglo[j + 1] = arreglo[j];
                    lines++;
                    j--;
                    lines++;
                }
                arreglo[j + 1] = aux;
                lines++;
            }
            return ++lines;
        }
    }

    
}
