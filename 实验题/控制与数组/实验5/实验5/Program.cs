using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 实验5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            bool flag = true;

            //输入N
            Console.Write("输入判断上限N:");
            N = int.Parse(Console.ReadLine());

            //判断输出质数
            int i = 0;
            for ( i = 2; i <= N; i++)
            {
                for (int j = 2; j <= Math.Sqrt(N); j++)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    Console.WriteLine("质数:" + i);
                }
            }

            Console.ReadLine();
        }
    }
}
