using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 取余运算
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 55;
            int j = 10;
            int k;
            Console.WriteLine("取余结果:" + (i % j));
            Console.WriteLine("取余结果:" + Math.DivRem(i, j, out k));
            Console.ReadLine();
        }
    }
}
