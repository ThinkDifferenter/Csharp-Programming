using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Random rand = new Random(DateTime.Now.Millisecond);
            int a, b;
            double c;

            a = rand.Next();
            Console.Out.WriteLine("A random integer is " + a);
            b = rand.Next(100);
            Console.Out.WriteLine("A random from 0 to 99 is " + b);
            c = rand.Next(100) + 1;
            Console.Out.WriteLine("A random from 1 to 100 is " + c);
            Console.In.ReadLine();
        }
    }
}
