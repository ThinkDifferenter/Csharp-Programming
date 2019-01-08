using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace for_circle_sentence
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, result=0;
            Console.WriteLine("inter m,n:");
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = m; i <= n; i++)
            {
                result += i;
            }
            Console.WriteLine("the sum from {0} to {1} is {2}", m, n, result);
            Console.ReadLine();
        }
    }
}
