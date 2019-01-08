using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_语句
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, i,j;
            Console.WriteLine("输入一个累加的起始数:");
            i=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("输入一个累加的结束数:");
            j = Convert.ToInt16(Console.ReadLine());
            do
            {
                sum += i;
                i++;
            } while (i <= j);
            Console.WriteLine("the sum from {0} to {1} is {2}", i, j, sum);
            Console.ReadLine();
        }
    }
}
