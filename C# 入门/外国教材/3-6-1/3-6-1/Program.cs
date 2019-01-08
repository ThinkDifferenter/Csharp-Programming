using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_6_1
{
    class Program
    {
        enum color { red=1,bule,green}
        static void Main(string[] args)
        {
            color color1, color2, color3;

            color1 = color.red;
            color2 = color.bule;
            color3 = color.green;

            Console.Out.WriteLine("the red is " + color1);
            Console.Out.WriteLine("the bule is " + color2);
            Console.Out.WriteLine("the green is " + color3);

            Console.In.ReadLine();
        }
    }
}
