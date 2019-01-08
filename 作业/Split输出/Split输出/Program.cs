using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Split输出
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            string Str = "I Love Program";
            string[] Split = new string[3];
            Console.WriteLine("输入句子:" + Str);
            Split = Str.Split(' ');
            foreach (string t in Split)
            {
                Console.WriteLine("第{0}个单词为:{1}",i,t);
                i++;
            }
            Console.ReadLine();
        }
    }
}