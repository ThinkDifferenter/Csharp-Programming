using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 实验8
{
    class Program
    {
        static void Main(string[] args)
        {
            string str="123.567 56.9 32 908.90 91.12";

            //分割输出
            string[] splitstring = str.Split(' ');
            double result = 0.0;
            for (int i = 0; i < splitstring.Length ; i++ )
            {
                double num = Convert.ToDouble(splitstring[i]);
                result += num;

                Console.WriteLine("第{0}个数为:{1}", i + 1, num);
            }

            //输出乘积
            Console.WriteLine("乘积为:" + result);

            Console.ReadLine();
        }
    }
}
