using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Random generaor = new Random(DateTime.Now.Millisecond);
            int num1;
            double num2;

            num1 = generaor.Next();
            Console.Out.WriteLine("A random integer: " + num1);
            num1 = generaor.Next(10);
            Console.Out.WriteLine("from 0 to 9: " + num1);
            num1 = generaor.Next(10)+1;
            Console.Out.WriteLine("from 1 to 10: " + num1);
            num1 = generaor.Next(15) + 20;
            Console.Out.WriteLine("from 20 to 34: " + num1);
            num1 = generaor.Next(20) - 10;
            Console.Out.WriteLine("from -10 to 9: " + num1);

            num2 = generaor.NextDouble();
            Console.Out.WriteLine("A random double(between 0-1): " + num2);

            Console.In.ReadLine();
        }
    }
}
