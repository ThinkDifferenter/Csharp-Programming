using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace function_gloable_variable
{
    public class myclass
    {
        public static int i = 123;
        public static void display()
        {
            Console.WriteLine("this i is in myclass gloable variable: {0}", i);
        }
    }
    class Program
    {
        static int j = 234;

        static void Main(string[] args)
        {
            int k = 345;
            Console.WriteLine("this j is in program class gloable variable :{0}", j);
            Console.WriteLine("------------------------------------------------------");
            myclass.display();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("this k is in main function locate variable :{0}", k);
            Console.ReadLine();
        }
    }
}
