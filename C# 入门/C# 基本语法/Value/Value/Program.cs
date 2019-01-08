using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Value
{
    class Program
    {
        static void Main(string[] args)
        {
            double i,j;
            i=sizeof(int)*8;
            j=Math.Pow(2,i)/2;
            Console.WriteLine("the arrange of int is {0} to {1}", -j, j - 1);
            Console.WriteLine("3^2={0}", Math.Pow(3, 2));
            Console.WriteLine("sizeof(int)={0}", sizeof(int));
            Console.ReadLine();
        }
    }
}
