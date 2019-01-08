using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 实验1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            double Sum = 0.0;
            double Aver = 0.0;
            double Diff = 0.0;

            //确定要输入数据的个数
            Console.Write("确定要输入数据的个数N:");
            N = int.Parse(Console.ReadLine());

            //输入N个整数
            int[] arr1 = new int[N];
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("输入第{0}个整数:",i+1);
                arr1[i] = int.Parse(Console.ReadLine());
                Sum += arr1[i];
            }
            Aver = Sum / arr1.Length;

            //输出N个整数的平均数
            Console.WriteLine("\nN个整数的平均数为:" + Aver);

            //输出N个整数的方差
            for (int i = 0; i < arr1.Length; i++)
            {
                Diff = Diff + (Aver - arr1[i]) * (Aver - arr1[i]); 
            }
            Console.WriteLine("N个整数的方差为:{0}\n", Diff);

            Console.WriteLine("***************************\n");

            //输入N个浮点数
            double[] arr2 = new double[N];
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write("输入第{0}个浮点数:", i + 1);
                arr2[i] = double.Parse(Console.ReadLine());
                Sum += arr2[i];
            }
            Aver = Sum / arr2.Length;

            //输出N个浮点数的平均数
            Console.WriteLine("\nN个浮点数的平均数为:" + Aver);

            //输出N个浮点数的方差
            for (int i = 0; i < arr1.Length; i++)
            {
                Diff = Diff + (Aver - arr2[i]) * (Aver - arr2[i]);
            }
            Console.WriteLine("N个浮点数的方差为:{0}", Diff);

            Console.ReadLine();
        }
    }
}
