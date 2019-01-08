using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace do_while_cricle_sentence
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j=0;
            Console.WriteLine("inter i:");
            i = Convert.ToInt32(Console.ReadLine());
            do
            {
                j += i;
                i--;
            } while (i >= 0);
            Console.WriteLine("the sum is {0}", j);
            Console.ReadLine();
        }
    }
}
