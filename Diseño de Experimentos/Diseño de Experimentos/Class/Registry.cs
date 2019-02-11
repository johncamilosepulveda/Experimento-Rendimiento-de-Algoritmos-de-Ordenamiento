using System;
using System.Collections.Generic;
using System.Text;

namespace Diseño_de_Experimentos.Class
{
    class Registry {
        public long Time { get; set; }
        public int ExecutedLines { get; set; }

        public string Processor { get; set; }
        public string Algorithm{ get; set; }
        public int ArraySize { get; set; }
        public int OrderType { get; set; }


    }
}
