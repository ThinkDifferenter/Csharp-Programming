using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 实验4
{
    class Program
    {
        static void Main(string[] args)
        {
            //分割字符串
            string str = "1.2	2.5	3	4	5	6.8	7	8	9	10	11	12	13	14	15	16	17	18	19	20.5";
            string[] splitstring = str.Split('\t');

            //提取数字并输出
            double sum = 0.0;
            for (int i = 0; i < splitstring.Length; i++)
            {
                double num = Convert.ToDouble(splitstring[i]);
                sum = sum + num;

                Console.WriteLine("第{0}个数:{1}", i + 1, num);
            }
            
            //输出和
            Console.WriteLine("\n数据的和为:{0}", sum);
            
            Console.ReadLine();
        }
    }
}
