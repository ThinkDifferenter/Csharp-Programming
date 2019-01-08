using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据类型2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = 300;
            double b = 12.3;
            int c = 12;
            a = a + (decimal)b;
            Console.WriteLine("the sizeof(decimal) is " + sizeof(decimal));
            Console.WriteLine("the sizeof(double) is " + sizeof(double));
            Console.WriteLine(a);
            a = a + c;
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
