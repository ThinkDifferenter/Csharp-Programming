using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 变量与常量_变量4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            for(x=0;x<3;x++)
            {
                int y = -1;
                Console.WriteLine("y is " + y);
                y = 100;
                Console.WriteLine("y is {0}", y);
            }
            Console.ReadLine();
        }
    }
}
