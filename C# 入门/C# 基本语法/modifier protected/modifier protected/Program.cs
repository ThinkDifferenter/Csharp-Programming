using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace modifier_protected
{
    public class myclass
    {
         protected int i = 123;
         protected int j = 234;
    }
    class Program:myclass//Proram class inherit myclass class
    {
        static void Main(string[] args)
        {
           // myclass sd = new myclass();  error!! we can't use protected date in the class,but we can use it in the inheriting class!
            Program sd = new Program();
            Console.WriteLine("i={0}", sd.i);
            Console.WriteLine("j={0}", sd.j);
            Console.ReadLine();
        }
    }
}
