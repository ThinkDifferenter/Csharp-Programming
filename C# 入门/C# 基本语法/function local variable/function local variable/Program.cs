using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace function_local_variable
{
    public class myclass
    {
        //int i = 1996;
        public static void LocalVariable()
        {
            int i=1996;
            Console.WriteLine("this i is defined in LocalVarible function:"+i);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int i=1997;
            Console.WriteLine("this i is defined in main function"+i);
            Console.WriteLine("------------------------------------------------");
            myclass.LocalVariable();
            Console.ReadLine();
        }
    }
}
