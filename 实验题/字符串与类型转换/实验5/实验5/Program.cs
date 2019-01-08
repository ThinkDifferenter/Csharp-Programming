using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 实验5
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch = 0, number = 0, space = 0, other = 0;
            string str = "This figure (shows) that 2 random* search finds good features, but that [evolution] finds better %20 ones!";
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    ch++;
                }
                else if (char.IsDigit(str[i]))
                {
                    number++;
                }
                else if (char.IsWhiteSpace(str[i]))
                {
                    space++;
                }
                else
                {
                    other++;
                }
            }
            
            //输出结果
            Console.WriteLine("字母个数:{0}\n 数字个数:{1}\n空格个数:{2}\n其他字符个数:{3}", ch, number, space, other);
            
            Console.ReadLine();
        }
    }
}
