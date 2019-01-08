using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 实验13
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] arr = new double[4, 5];
 
            //输入每个向量
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("输入第{0}个向量:",i+1);
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = double.Parse(Console.ReadLine());
                }
            }

            //随机选取三个向量和参数k
            Random rd = new Random();
            int k = rd.Next(0, 1);

            int l1 = rd.Next(0, 2);
            int l2 = rd.Next(0, 2);
            int l3 = rd.Next(0, 2);

            //计算等式结果
            double[] v = new double[5];

            for (int i = 0; i < 5; i++)
            {
                v[i] = arr[l1, i] + arr[l2, i] * k - arr[l3, i] * k;
            }

            //输出结果
            Console.WriteLine("等式计算结果为:");
            foreach (double t in v)
            {
                Console.Write(t + "\t");
            }
            
            Console.ReadLine();
        }
    }
}
