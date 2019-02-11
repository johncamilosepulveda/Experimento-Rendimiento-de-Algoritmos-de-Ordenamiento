using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Diseño_de_Experimentos.Class;


namespace Diseño_de_Experimentos
{
    public class GenerateArray {

        public int[] RandomArray { get; set; }
        public int[] AscendingOrderArray { get; set; }
        public int[] DescendingOrderArray { get; set; }

        public GenerateArray() {

            int[] sizes = new int[] { 100, 1000, 100000, 1000000 };
            int[] arrayTypes = new int[] {
                (int) OrderType.Ascending,
                (int)OrderType.Descending,
                (int)OrderType.Random
            };
            Random Rand = new Random();

            foreach (var size in sizes) {
                RandomArray = new int[size];
                AscendingOrderArray = new int[size];
                DescendingOrderArray = new int[size];

                for (int i = 0; i < size; i++)
                {
                    RandomArray[i] = Rand.Next(0, 1000000);
                }
                int[] auxRandom1 = RandomArray.Clone() as int[];
                int[] auxRandom2 = RandomArray.Clone() as int[];
                AscendingOrderArray = auxRandom1.OrderBy(x => x).ToArray();
                DescendingOrderArray = auxRandom2.OrderByDescending(x => x).ToArray();
                List<int[]> ArraysList = new List<int[]> { AscendingOrderArray, DescendingOrderArray, RandomArray };
                foreach (var type in arrayTypes)
                {
                    File.WriteAllText(@"./Data\Arrays" + size + " - Type " + type, "");
                    StreamWriter streamWriter = new StreamWriter("./Data/Arrays/" + size + " - " + "Type " + type);
                    if (type == 0) {
                        for (int i = 0; i < AscendingOrderArray.Length; i++)
                        {
                            streamWriter.Write(AscendingOrderArray[i]+ " ");
                        }
                    }
                    else if (type == 1) {
                        for (int i = 0; i < DescendingOrderArray.Length; i++)
                        {
                            streamWriter.Write(DescendingOrderArray[i] + " ");
                        }
                    }
                    else {
                        for (int i = 2; i < RandomArray.Length; i++)
                        {
                            streamWriter.Write(RandomArray[i] + " ");
                        }
                    }
                    streamWriter.Close();
                }
            }
        }
       
    }
}
