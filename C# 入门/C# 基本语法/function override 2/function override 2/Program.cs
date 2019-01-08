using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace function_override_2
{
    public class mycalss
    {
        public  static void func()
        {
            Console.WriteLine("this function is defined in myclass");
        }
    }
    class Program
    {
        public  static void func()
        {
            Console.WriteLine("this function is defined in program");
        }
        static void Main(string[] args)
        {
            mycalss.func();
            Console.WriteLine("--------------------------------------");
            func();
            Console.ReadLine();
        }
    }
}
