using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_6
{
    class Program
    {
        enum Flavor
        { vanilla, chocolate, strawbery, fudgeripple, coffee, rockyroad,mintchocolatechip, cookiedough }

        static void Main(string[] args)
        {
            Flavor cone1, cone2, cone3;

            cone1 = Flavor.rockyroad;
            cone2 = Flavor.chocolate;

            Console.Out.WriteLine("cone1   value: " + cone1);
            Console.Out.WriteLine("cone1 ordinal: "+(int)cone1);
            Console.In.ReadLine();

            Console.Out.WriteLine("cone1    value: " + cone1);
            Console.Out.WriteLine("cone2  ordinal: " + (int)cone2);
            Console.In.ReadLine();

            cone3 = cone1;
            Console.Out.WriteLine("cone3   value: " + cone3);
            Console.Out.WriteLine("cone3 ordinal:" + (int)cone3);
            Console.In.ReadLine();

            
        }
    }
}
