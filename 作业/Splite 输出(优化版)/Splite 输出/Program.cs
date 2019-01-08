using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Splite_输出
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入要分割的句子:");
            string Str = Console.ReadLine();
            int cnt = 1;
            Console.WriteLine("\n\n分割结果为:");
            string[] SplitStrings;
            SplitStrings = Str.Split(' ');
            foreach (string t in SplitStrings)
            {
                Console.WriteLine("第{0}个单词为:{1}",cnt , t);
                cnt++;
            }
            Console.ReadLine();
        }
    }
}
