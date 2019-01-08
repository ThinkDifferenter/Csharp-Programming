using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 水仙花数_优化版_
{
    class Program
    {
        static void Main(string[] args)
        {
            //确定水仙花数的位数
            int n;
            Console.Write("输入要判定的水仙花位数:");
            n = int.Parse(Console.ReadLine());
            int[] num = new int[n];

            //分割数据并判断
            for (int i = (int)Math.Pow(10,n-1); i < Math.Pow(10,n); i++)
            {
                int sum = 0;
                int t = i;
                for (int j = 0; j < n; j++)
                {
                    num[j] = t % 10;
                    t = t / 10;
                    sum += (int)Math.Pow(num[j],n);
                }
                if (sum == i)
                {
                    Console.WriteLine("水仙花数:" + i);
                }
            }

            Console.ReadLine();
        }
    }
}
