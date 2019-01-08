using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 变量与常量_变量1
{
    class Program
    {
        static void Main(string[] args)
        {
            double redius, heigh;
            const double PI = 3.1415926;

            Console.WriteLine("Please input redius:");
            redius = double.Parse(Console.ReadLine());
            Console.WriteLine("please input heigh:");
            heigh = double.Parse(Console.ReadLine());
            double volume = PI * redius * heigh;
            Console.WriteLine("volume is " + volume);
            Console.ReadLine();
        }
    }
}
