using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double i = 3.1415926;
            double j;
            Console.Out.WriteLine("The formate i is " + i.ToString("0.###"));
            Console.Out.WriteLine("The formate i is " + i.ToString("0.000"));
            Console.Out.WriteLine("The foramte i is " + i.ToString("0.##"));
            Console.Out.WriteLine("The foramte i is " + i.ToString("0.#"));
            Console.Out.WriteLine("The formate i is " + i);
            j = 2 * i;
            Console.Out.WriteLine("The formate j is " + j);
            Console.In.ReadLine();
        }
    }
}
