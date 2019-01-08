using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boxing
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i = 10;
            object obj = i;//boxing
            object obj1 = 100;//type of date
            if (obj is object)
            {
                Console.WriteLine("the value of i is boxing");
            }
            Console.WriteLine("i={0}", i);
            Console.WriteLine("obj={0}", obj);
            Console.WriteLine("obj1={0}", obj1);
            Console.ReadLine();
        }
    }
}
