using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Random randoms = new Random(DateTime.Now.Millisecond);
            int i=20, j;
            double k;
            i = randoms.Next();
            Console.Out.WriteLine("A random i: " + i);
            j = randoms.Next(10);
            Console.Out.WriteLine("A random from 0 to 9 is: " + j);
            k = randoms.Next(10) + 1;
            Console.Out.WriteLine("A random from 1 to 10 is:  " + k);

            Console.In.ReadLine();
        }
    }
}
