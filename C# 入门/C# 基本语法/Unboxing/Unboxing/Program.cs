using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=10;//boxing
            object obj =(object) i;//object obj=i;
            if(i is object)
            {
                Console.WriteLine("the i is boxing");
            }
            int j=(int)obj;//unboxing
            if(j is int)
            {
                Console.WriteLine("the j is unboxing");
            }
            Console.WriteLine("i={0}", i);
            Console.WriteLine("obj={0}", obj);
            Console.WriteLine("j={0}", j);
            Console.ReadLine();
        }
    }
}
