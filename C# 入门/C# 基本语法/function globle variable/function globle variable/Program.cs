using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace function_globle_variable
{
    
    class Program
    {
        static string myanme = "jiangjun";
        static void Main(string[] args)
        {
            string hisname="zhangming";
            Console.WriteLine("this is globle variable {0}", myanme);
            Console.WriteLine("____________________________________");
            Console.WriteLine("this is local variable {0}", hisname);
            Console.ReadLine();
        }
    }
}
