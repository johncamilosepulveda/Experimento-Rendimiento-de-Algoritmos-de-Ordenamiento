using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Diseño_de_Experimentos
{
    public class BubbleSort
    {

        public long TimeBurbleSort(int[] arreglo)
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

        public long LinesBurbleSort(int[] arreglo)
        {
            int countLines = 0;
            int n = arreglo.Length;
            countLines++;
            for (int i = 2; i < n; i++)
            {
                countLines+=3;
                for (int j = 0; j <= (n - i); j++)
                {
                    countLines+=3;
                    if (arreglo[j] > arreglo[j + 1])
                    {
                        countLines++;
                        int aux = arreglo[j];
                        countLines++;
                        arreglo[j] = arreglo[j + 1];
                        countLines++;
                        arreglo[j + 1] = aux;
                        countLines++;
                    }
                }
            }
            return ++countLines;
        }




    }
}
