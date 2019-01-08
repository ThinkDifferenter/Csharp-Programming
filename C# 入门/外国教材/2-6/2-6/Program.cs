using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            const int BASE = 32;
            const double CONVERSION_FACTOR = 9.0 / 5.0;

            int cesiusTemp = 24;
            double fahrenheitTemp;
            fahrenheitTemp = cesiusTemp * CONVERSION_FACTOR + BASE;

            Console.Out.Write("celsius Tempture:" + cesiusTemp+"\n");
            Console.Out.Write("Fahrenheit Equivalent:" + fahrenheitTemp+"\n");
            

            Console.Out.WriteLine("celsius Tempture:" + cesiusTemp  );
            Console.Out.WriteLine("Fahrenheit Equivalent:" + fahrenheitTemp  );

            Console.In.Read();
        }
    }
}
