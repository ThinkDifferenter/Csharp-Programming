using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace decimal数据强制数据类型转化
{
    class Program
    {
        static void Main(string[] args)
        {
            //一定要强制类型转化！！！
            decimal d1 = (decimal)123.456;
            decimal d2 = (decimal)234.567;
            Console.WriteLine("d1+d2=" + (d1 + d2));
            Console.ReadLine();
        }
    }
}
