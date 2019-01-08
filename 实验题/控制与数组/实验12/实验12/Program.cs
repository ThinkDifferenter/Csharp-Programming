using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 实验12
{
    class Program
    {
        static void Main(string[] args)
        {      
            const int N = 10;
            double[] a = new double[N];

            //输入十个小数
            Console.WriteLine("输入10个小数:");
            int i = 0;
            for (i = 0; i < a.Length; i++)
            {
                try
                {
                    Console.Write("输入第{0}个小数：", i + 1);
                    a[i] = double.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("捕捉异常:{0},请输入合法小数!", ex.Message);
                    i--;//重新输入
                }
            }

            //冒泡排序输入数据
            for (int l = 0; l < a.Length; l++)
            {
                for (int j = l + 1; j < a.Length; j++)
                {
                    if (a[l] > a[j])
                    {
                        a[l] = a[l] + a[j];
                        a[j] = a[l] - a[j];
                        a[l] = a[l] - a[j];
                    }
                }
            }

            //输出排序后的数据
            Console.WriteLine("\n冒泡排序后:");
            foreach (double t in a)
            {
                Console.Write(t+"\t");
            }

            Console.ReadLine();
        }
    }
}
