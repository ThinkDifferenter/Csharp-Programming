using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Is_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            double m, n;
            Console.WriteLine("Please input i:");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input m:");
            m = Convert.ToInt32(Console.ReadLine());
            if (i is int)
            {
                Console.WriteLine("the i is int");
            }
            if (m is double)
            {
                Console.WriteLine("the m is double");
            }
            j = (int)m;
            n = (double)i;
            if (j is int)
            {
                Console.WriteLine("the j is int");
            }
            else
            {
                Console.WriteLine("the is not int");
            }
            if (n is double)
            {
                Console.WriteLine("the n is double");
            }
            else
            {
                Console.WriteLine("the n is not double");
            }
            Console.ReadLine();

        }
    }
}
