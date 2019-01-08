using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder phrase = new StringBuilder("Change is inevitable");
            StringBuilder mutation1;
            string mutation2, mutation3, mutation4;
            Console.Out.WriteLine("original string: " + phrase + " \n");
            Console.Out.WriteLine("Length of string: " + phrase.Length);

            mutation1 = phrase.Append(", except from vending machines.");
            mutation2 = mutation1.ToString().ToUpper();
            mutation3 = mutation2.Replace("E", "X");
            mutation4 = mutation3.Substring(3, 30);

            Console.Out.WriteLine("Mutation #1:" + mutation1);
            Console.Out.WriteLine("Mutation #2:" + mutation2);
            Console.Out.WriteLine("Mutation #3:" + mutation3);
            Console.Out.WriteLine("Mutation #4:" + mutation4);

            Console.Out.WriteLine("Mutated length: " + mutation4.Length);
            Console.In.Read();
        }
    }
}
