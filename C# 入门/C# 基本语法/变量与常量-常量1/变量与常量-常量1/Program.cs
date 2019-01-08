using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 变量与常量_常量1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if(a==b)
            {
                Console.WriteLine("hello!");
            }
            else
            {
                Console.WriteLine("not same!");
            }
            Console.ReadLine();
        }
    }
}
