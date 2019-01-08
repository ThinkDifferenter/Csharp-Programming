using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum=0;
            Console.Out.Write("Please input n:");
            n = int.Parse(Console.In.ReadLine());
            for(i=0;i<= n;i++)
            {
                sum += i;
            }
            Console.Out.WriteLine("the sum is " + sum);
            Console.In.ReadLine();
        }
    }
}
