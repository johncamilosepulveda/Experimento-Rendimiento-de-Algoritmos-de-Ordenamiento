using System;
using System.Management;

namespace Diseño_de_Experimentos.App
{
    public class Main {

        public string Processor { get; set; }

        public Main()
        {
            Processor = GetProcessorName();
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

        }
       


    }
}
