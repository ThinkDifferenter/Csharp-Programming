using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sizeof(decimal) is {0}",sizeof(decimal));
            Console.ReadLine();
            decimal a = 300;
            double b = 12.3;
            a=a+(decimal)b;
            Console.WriteLine("a={0}", a);
            Console.ReadLine();
        }
    }
}
