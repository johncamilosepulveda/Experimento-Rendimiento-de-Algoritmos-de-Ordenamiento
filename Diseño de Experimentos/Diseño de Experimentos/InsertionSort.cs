using System;
using System.Collections.Generic;
using System.Text;

namespace Diseño_de_Experimentos
{
    class InsertionSort
    {

        public  int[] OrdenarInsertionSort(int[] arreglo)
        {
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
            return arreglo;
        }
        

    }
}
