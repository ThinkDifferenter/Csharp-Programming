using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 实验3
{
    class Program
    {
        static void Main(string[] args)
        {
            double Sum = 0.0;
            int N = 0;
            double i=1;

            //输入N的值
            Console.Write("请输入N:");
            N = int.Parse(Console.ReadLine());

            //求和
            while(i<=N)
            {
                Sum += (i + 1) / (N + 1);
                i++;
            }

            //输出结果
            Console.WriteLine("求和的结果为:" + Sum);

            Console.ReadLine();
        }
    }
}
