using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace function_3
{
    public class myclass
    {
        public static void display()
        {
            Console.WriteLine("this function is defined in myclass");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this function is defined in main");
            Console.WriteLine("------------------------------------");
            myclass.display();
            Console.ReadLine();
        }
    }
}
