using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.1415926;
            double r, s, c;
            Console.Out.Write("Please input r:");
            r = double.Parse(Console.In.ReadLine());
            c = 2 * r * PI;
            s = PI * r * r;

            Console.Out.WriteLine("the s of circle is: "+c);
            Console.Out.WriteLine("the c of circle is: "+s);
            Console.In.ReadLine();
        }
    }
}
