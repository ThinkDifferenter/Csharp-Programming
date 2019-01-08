using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace while_circle_sentence
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1, j=1, k=1;
            Console.WriteLine("inter i:");
            i = Convert.ToInt32(Console.ReadLine());
            while(j<=i)
            {
                k*=j;
                j++;
            }
            Console.WriteLine("the result is {0}",k);
            Console.ReadLine();
        }
    }
}
