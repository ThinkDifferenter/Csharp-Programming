using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exchange_function
{
    class Program
    {
        static void exchange(int a, int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("please input a,b;");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the input a is {0},b is {1}", a,b);
            Console.WriteLine("-----------------------------------");

            //exchange(a, b);
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("after exchange the a is {0},b is {1}",a,b);
            Console.ReadLine();
        }
    }
}
