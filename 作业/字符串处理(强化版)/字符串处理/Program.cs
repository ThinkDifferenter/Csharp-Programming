using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 字符串处理
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "The major reason for the good performance of the good algorithm is that the incorporation of the multhe tioperator strategy helps to select good crossover operators.";
            string s1 = "good";

            //查找输出"good"的位置
            int Pos = str.IndexOf(s1);
            int Cnt = 1;
            while (Pos != -1)
            {
                Console.WriteLine("字符串中第{0}个good的位置为：{1}",Cnt,Pos);
                Pos = str.IndexOf(s1, Pos + 1);
                Cnt++;
            }
            Console.WriteLine();

            //替换字符串中的good为Good
            String New1 = str.Replace(s1, "Good");
            Console.WriteLine("替换后的字符串为\n" + New1);

            //在指定位置插入字字符串
            s1 = "strategy helps to";
            string s2 = "the";
            Pos = str.IndexOf(s1);
            string News2 = str.Insert(Pos, s2);
            Console.WriteLine("\n插入字符串后的字符串为\n" + News2);

            //输出每个单词的首字母
            Cnt = 1;
            string[] StrArray = str.Split(' ');
            for (int i = 0; i < StrArray.Length; i++)
            {
                Console.WriteLine("第{0}个单词的首字母为{1}", i + 1, StrArray[i].Substring(0,1));
            }

            //我的信息
            Console.WriteLine("\n姓名：蒋军\n班级：信息151班\n学号：23号\n");

            Console.ReadLine();
        }
    }
}
