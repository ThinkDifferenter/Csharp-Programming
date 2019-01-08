using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 实验17
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建二维数组
            int[,] a = new int[5, 3]{{1,6,11},{2,7,12},{3,8,13},{4,9,14},{5,10,15}};
            int[,] b = new int[3, 5];

            //输出原数组并赋值到b数组
            Console.WriteLine("原数组:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    b[j, i] = a[i, j];
                    Console.Write(a[i, j]+"\t");
                }
                Console.WriteLine();
            }

            //输出转置数组
            Console.WriteLine("\n转置数组:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(b[i, j] + "\t");
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
