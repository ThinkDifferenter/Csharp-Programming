using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace string_input
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Please input your name:");
            name = Console.ReadLine();
            Console.WriteLine("my name is " + name);
            Console.ReadLine();
        }
    }
}
