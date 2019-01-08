using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace constructed_function_in_baseclass_1
{
    public class baseclass
    {
        public baseclass()
        {
            Console.WriteLine("construced function in baseclass");
        }
    }
    public class dericedclass:baseclass
    {
        public dericedclass()
        {
            Console.WriteLine("constructed function in dericedclass");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            dericedclass sd = new dericedclass();
            Console.ReadLine();
        }
    }
}
