using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Random_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int i = rd.Next(1, 100);
            double d1 = (double)i;
            double d = rd.Next(1, 100);
            Console.WriteLine(i);
            Console.WriteLine("--------------------");
            Console.WriteLine(d);
            Console.WriteLine(d1);
            Console.ReadLine();
        }
    }
}
