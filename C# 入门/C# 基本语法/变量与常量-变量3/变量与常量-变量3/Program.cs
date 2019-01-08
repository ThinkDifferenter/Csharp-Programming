using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 变量与常量_变量3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y;
            if(x==10)
            {
                y = 20;
                Console.WriteLine("x and y is " + (x + y));
            }
             y = 100;
            Console.WriteLine("x is " + x);
            Console.ReadLine();
        }
    }
}
