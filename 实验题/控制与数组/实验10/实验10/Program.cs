using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 实验10
{
    class Program
    {
        static void Main(string[] args)
        {
            //输入a,b
            Console.Write("输入a:");
            int a = int.Parse(Console.ReadLine());

            Console.Write("输入b:");
            int b = int.Parse(Console.ReadLine());

            
            //运算
            try
            {
                Console.WriteLine("运算结果为:" + a / b);
            }
            catch (Exception ex)
            {
                Console.WriteLine("捕捉到异常:" + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
