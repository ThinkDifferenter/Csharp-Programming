using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace function_1
{
    class Program
    {
        public static double power(double m, int n)
        {
            double result = 1;
            if (n >= 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    result *= m;
                }
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                     result /= m;
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("inter i:");
            double i = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("inter j:");
            int j = Convert.ToInt32(Console.ReadLine());
            double k = power(i, j);
            Console.WriteLine("the result is {0}", k);
            Console.ReadLine();
        }
    }
}
