using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 实验14
{
    class Program
    {
        static void Main(string[] args)
        {
            //输入两个五维的向量
            double[] x = new double[5];
            double[] v = new double[5];
            Console.WriteLine("输入五维向量X:");
            for (int i = 0; i < 5; i++)
            {
                x[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("输入五维向量V:");
            for (int i = 0; i < 5; i++)
            {
                v[i] = double.Parse(Console.ReadLine());
            }


        }
    }
}
