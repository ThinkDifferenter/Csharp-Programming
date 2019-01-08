using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace constructed_function_in_baseclass
{
    public class baseclass
    {
        public baseclass()
        {
            Console.WriteLine("baseclass constructed funtion");
        }
    }
    public class dericedclass : baseclass
    {
        public void show()
        {
            Console.WriteLine("dericedclass dericeclass function");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            dericedclass sd = new dericedclass();
            sd.show();//it can use baseclass constructed function and dericedclass fuction
            Console.ReadLine();
        }
    }
}
