using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Value_2
{
    
    class Program
    {
        public  static string str = "my name is jiangjun";
        protected static int i = 100;
        static void write(string str)
        {
            Console.WriteLine(str);
        }
        static void show(int i)
        {
            Console.WriteLine("i={0}", i);
        }
        static void Main(string[] args)
        {
            write(str);
            show(i);
            Console.ReadLine(); 
        }
    }
}
