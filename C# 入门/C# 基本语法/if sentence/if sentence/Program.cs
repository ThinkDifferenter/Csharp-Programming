using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace if_sentence
{
    class Program
    {
        static void Main(string[] args)
        {
            double i, j;
            Console.WriteLine("inter i,j:");
            i = Convert.ToDouble(Console.ReadLine());
            j = Convert.ToDouble(Console.ReadLine());
            if (i > j)
            {
                Console.WriteLine("Good");
            }
            else
            {
                Console.WriteLine("bad");
            }
            Console.WriteLine("--------------------------------------------");
            double k;
            k = Math.Pow(2, sizeof(double) * 8) / 2;
            Console.WriteLine("the arrange of double is {0} to {1}", -k, k - 1);
            Console.ReadLine();
        }
    }
}
