using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace question_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter i:");
            int i = Convert.ToInt32(Console.ReadLine());
            int j;
            j = i > 0 ? 1 : -1;
            Console.WriteLine("j={0}", j);
            Console.ReadLine();
        }
    }
}
