using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_循环
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1;
            int n=1;
            while(i<=10)
            {
                n *= i;
                i++;
            }
            Console.WriteLine("10的阶乘为:{0}", n);
            Console.ReadLine();
        }
    }
}
