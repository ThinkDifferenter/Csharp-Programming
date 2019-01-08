using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pi_console
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 0, t = 1;
            long j = 1;
            int flag = 1;
            while (Math.Abs(t) > 1e-8)
            {
                pi += t;
                j += 2;
                flag *= -1;
                t = (double)flag / j; //Convert.ToDouble(j);
            }
            pi *= 4;
            Console.WriteLine("the pi is {0}", pi);
            Console.Write("-------------------------------\n");
            Console.Write("the pi is {0}", Math.PI);
            Console.ReadLine();
        }
    }
}
