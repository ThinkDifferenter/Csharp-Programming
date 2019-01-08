using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 实验15
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一维数组存储每个项目
            int[] n = new int[4];

            //输入字符串
            Console.WriteLine("请输入一串字符：");
            string str = Console.ReadLine();

            //遍历判断字符串中字符类型
            foreach (char c in str)
            {
                if (c <= '9' && c >= '0')
                {
                    n[0]++;
                }
                else if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {
                    n[1]++;
                }
                else if (c == ' ')
                {
                    n[2]++;
                }
                else
                {
                    n[3]++;
                }
            }

            //输出各项目的数据
            Console.WriteLine("输出字符串统计分类统计的结果：");
            Console.WriteLine("数字个数：{0}", n[0]);
            Console.WriteLine("字母个数：{0}", n[1]);
            Console.WriteLine("空格个数：{0}", n[2]);
            Console.WriteLine("其他字符个数：{0}", n[3]);

            Console.ReadLine();
        }
    }
}
