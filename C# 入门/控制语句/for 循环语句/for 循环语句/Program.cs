using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_循环语句
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i=0;i<=100;i++)
            {
                sum += i;
            }
            Console.WriteLine("the sum is {0}", sum);
            Console.ReadLine();
        }
    }
}
