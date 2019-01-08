using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, sum=0;
            for(i=0;i<=100;i++)
            {
                sum += i;
            }
            Console.Out.WriteLine("the sum is " + sum);
            Console.In.ReadLine();
        }
    }
}
