using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int radiums;
            double area, circumference;

            Console.Out.Write("Enter the circle's radius:");
            radiums = int.Parse(Console.In.ReadLine());

            area = Math.PI * Math.Pow(radiums, 2);
            circumference = 2 * Math.PI * radiums;

            Console.Out.WriteLine("the circle decimal: ")

        }
    }
}
