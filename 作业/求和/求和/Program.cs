using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 求和
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int n = 0;
            double result = 0;
            
            //输入求和个数
            Console.Write("输入求和个数N:");
            while (flag)
            {
                try
                {
                    //n = Convert.ToInt32(Console.ReadLine());
                    n = int.Parse(Console.ReadLine());
                    flag = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("捕捉到异常:" + ex.Message);
                    Console.WriteLine("请重新输入!");
                }
                
            }

            //求和
            for (double i = 1; i <= n; i++)
            {
                result += (i + 1) / (i + 3);
            }

            //输出结果
            Console.WriteLine("求和的结果为: "+ result);
            Console.ReadLine();
        }
    }
}
