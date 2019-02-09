using System;
using System.Collections.Generic;
using System.Text;

namespace Diseño_de_Experimentos
{
    class BubbleSort
    {


        public int[] OrdenarBubbleSort(int[] arreglo)
        {
            int n = arreglo.Length;
            for (int i=2; i < n; i++)
            {
                for(int j=0; j < (n - i); j++)
                {
                    if (arreglo[j] > arreglo[j + 1])
                    {
                        int aux = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = aux;
                    }
                }
            }
            return arreglo;
        }




    }
}
