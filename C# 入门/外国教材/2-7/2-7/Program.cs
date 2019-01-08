using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string message;

            Console.Out.Write("Enter a line of text:");

            message = Console.In.ReadLine();

            Console.Out.Write("You entered: " + message );
            Console.In.ReadLine();
        }
    }
}
