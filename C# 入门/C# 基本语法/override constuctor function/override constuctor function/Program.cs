using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace override_constuctor_function
{
    class myclass
    {
        public myclass()
        {
            Console.WriteLine("myclass()");
        }
        public myclass(int i)
        {
            Console.WriteLine("myclass(int {0})", i);
        }
        public myclass(double i)
        {
            Console.WriteLine("myclass(double {0}) ", i);
        }
        static void Main(string[] args)
        {
            myclass a = new myclass();//override constructor function
            myclass b = new myclass(123);
            myclass c = new myclass(23.4);
            Console.ReadLine();
        }
    }
}
