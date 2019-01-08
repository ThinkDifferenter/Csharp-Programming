using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace delegate_defined
{
    class Program
    {
        delegate void mydelegate();
        public  static void f1()
        {
            Console.WriteLine("delegate 1");
        }
        public static void f2()
        {
            Console.WriteLine("delegate 2");
        }
        public static void f3()
        {
            Console.WriteLine("delegate 3");
        }
        static void Main(string[] args)
        {
            mydelegate dg;
            dg = new mydelegate(f1);
            dg = new mydelegate(f2);
            dg = new mydelegate(f3);
            Console.ReadLine();
        }
    }
}
