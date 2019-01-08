using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_循环语句2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("九九乘法表:");
            for(i=0;i<=9;i++)
            {
                for(j=0;j<= i;j++)
                {
                    Console.Write("{0}*{1}={2}\t", i, j, i * j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
