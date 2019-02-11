using System;
using System.IO;
using System.Management;
using System.Linq;
using Diseño_de_Experimentos.Class;
using System.Text;

namespace Diseño_de_Experimentos.App
{
    public class Main {

        public string Processor { get; set; }

        public Main()
        {
            Processor = GetProcessorName();
            IniziatizateExperiment();
            //new GenerateArray();
        }

        public string GetProcessorName() {
            string name = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from " + "Win32_Processor");
            foreach (ManagementObject share in searcher.Get()) {
                name = share["Name"].ToString();
            }
            return name;
        }

        public void IniziatizateExperiment() {
            string[] files = Directory.GetFiles(@"Data\Arrays\");
            Console.Write(Directory.GetCurrentDirectory());
            int[] algorithmType = new int[] {
                (int) AlgorithmType.BubbleSort,
                (int)AlgorithmType.InsertionSort,
            };
            string[] guid = Guid.NewGuid().ToString().Split('-');
            string id = guid[0];
            var myfile = File.Create(Directory.GetCurrentDirectory()+@"\Data\"+id+".csv");
            myfile.Close();
            //StreamWriter streamWriter = new StreamWriter(Directory.GetCurrentDirectory() + @"\Data\" + id + ".csv");
            var csv = new StringBuilder();

            string header = "Processor,Array Size,Order Type, Algorithm, time, Executed Lines";
            csv.AppendLine(header);

            foreach (var file in files)
            {
                try
                {
                    StreamReader streamReader = new StreamReader(file);
                    string line = streamReader.ReadLine();

                    string[] numbers = line.Split(' ');
                    int[] intNumbers = Array.ConvertAll(numbers, int.Parse);

                    string[] info = file.Split('-');

                    string size = info[0].Substring(11);
                    string orderType = info[1].Last().ToString();
                    string proccessor = Processor;
                    string lineNumbers;
                    string time;

                    foreach (var algorithm in algorithmType)
                    {
                        if (algorithm == 0)
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                int lines = BubbleSort.LinesBurbleSort(intNumbers);
                                lineNumbers = lines.ToString();
                                long intTime = BubbleSort.TimeBurbleSort(intNumbers);
                                time = intTime.ToString();
                                csv.AppendLine(proccessor + "," + size + "," + orderType + "," + algorithm + "," + time + "," + lineNumbers);
                                File.WriteAllText(Directory.GetCurrentDirectory() + @"\Data\" + id + ".csv", csv.ToString());
                            }
                        }
                        else
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                int lines = InsertionSort.LinesInsertionSort(intNumbers);
                                lineNumbers = lines.ToString();
                                long intTime = InsertionSort.OrdenarInsertionSort(intNumbers);
                                time = intTime.ToString();
                                csv.AppendLine(proccessor + "," + size + "," + orderType + "," + algorithm + "," + time + "," + lineNumbers);
                                File.WriteAllText(Directory.GetCurrentDirectory() + @"\Data\" + id + ".csv", csv.ToString());
                            }
                        }
                    }
                    streamReader.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            File.WriteAllText(Directory.GetCurrentDirectory() + @"\Data\" + id + ".csv", csv.ToString());
            Console.WriteLine("End");

            


        }



    }
}
