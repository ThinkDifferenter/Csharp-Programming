using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Genericity
{
    class Program
    {
        public static void Exchange<T>(ref T a, ref T b)
        {
            T t = a;
            a = b;
            b = t;
        }
        static void Main(string[] args)
        {
            int a = 12;
            int b = 13;

            Console.WriteLine("Before Exchange:a={0},b={1}", a, b);
            
            Program.Exchange<int>(ref a, ref b);
            
            Console.WriteLine("\nAfter Exchange:a={0},b={1}", a, b);

            Console.ReadLine();
        }
    }
}
