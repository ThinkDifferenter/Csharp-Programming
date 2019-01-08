using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for(i=0;i<10;i++)
            {
                for(j=0;j<i;j++)
                {
                    Console.Out.Write("*");
                }
                Console.Out.Write("\n");
            }
            
            Console.In.ReadLine();
        }
    }
}
