using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 实验11
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 10;
            double Dmax = double.MinValue;//表示double最小可能值
            //Console.WriteLine(Dmax);
            double Dmin = double.MaxValue;//表示double最大可能值
            //Console.WriteLine(Dmin);
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
                    Console.WriteLine("捕捉异常:{0},请输入合法小数!",ex.Message);
                    i--;//重新输入
                }
            }

            //求输入数据的最值
            i = 0;
            while (i < a.Length)
            {
                if (Dmin > a[i])
                {
                    Dmin = a[i];
                }
                else if (Dmax < a[i])
                {
                    Dmax = a[i];
                }
                i++;
            }

            //输出最值
            Console.WriteLine("最大值为：{0}，最小值为:{1}", Dmax, Dmin);
            
            Console.ReadLine();
        }
    }
}
