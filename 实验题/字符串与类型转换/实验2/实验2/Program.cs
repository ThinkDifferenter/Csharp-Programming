using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 实验2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "The major reason for the good performance of the good algorithm is that the incorporation of the multhe tioperator strategy helps to select good crossover operators.";
            string s1 = "good";

            //输出字符串长度
            Console.WriteLine("字符串长度为:" + str.Length);

            //输出每个单词的第一个字符
            string[] splitstrings = str.Split(' ');
            int cnt=1;
            foreach (string t in splitstrings)
            {
                Console.WriteLine("第{0}个单词的首字母为:{1}", cnt, t[0]);
                cnt++;
            }


            //将of替换成OF
            string str1 = str.Replace("of", "OF");
            Console.WriteLine("\n替换后的字符串为:" + str1);

            //删除tioperator
            int Pos = str.IndexOf("tioperator");
            string str2 = str.Remove(Pos,10);
            Console.WriteLine("\n移除tioperator后的字符串为:" + str2+"\n");
            
            //输出good位置
            cnt = 1;
            Pos = str.IndexOf(s1);
            while (-1 != Pos)
            {
                Console.WriteLine("第{0}个good的位置为:{1}",cnt,Pos);
                cnt++;
                Pos = str.IndexOf(s1, Pos + 1);
            }

            //在strategy helps to前加the
            s1 = "strategy helps to";
            string s2 = "the";
            Pos = str.IndexOf(s1);
            string str3 = str.Insert(Pos, s2);
            Console.WriteLine("\n添加后的字符串为:"+str3);

            Console.ReadLine();
        }
    }
}
