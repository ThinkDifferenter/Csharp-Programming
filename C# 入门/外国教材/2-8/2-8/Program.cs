using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int miles;
            double gallons,mpg;
            Console.Out.Write("Enter the number os miles:");
            miles = int.Parse(Console.In.ReadLine());//数据输入函数！

            Console.Out.Write("Enter gallons of fuel used:");
            gallons = double.Parse(Console.In.ReadLine());
            mpg = miles / gallons;

            Console.Out.Write("miles per gallons: " + mpg.ToString("0.0"));
            Console.In.Read();
        }
    }
}
