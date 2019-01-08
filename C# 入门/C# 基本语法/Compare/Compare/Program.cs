using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compare
{
    class Program
    {
        static void hello()
        {
            Console.WriteLine("Hello,my name is JiangJun");
        }
        static void goodbye()
        {
            Console.WriteLine("Goodbye!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please input i:");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input i:");
            int j = Convert.ToInt32(Console.ReadLine());
            if (i == j)
            {
                Console.Write("i=j\n");
                hello();
            }
            else
            {
                Console.Write("i!=j\n");
                goodbye();
            }
            Console.ReadLine();
        }
    }
}