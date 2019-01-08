using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 实验19
{
    class Program
    {
        static void Main(string[] args)
        {
            string str="This figure (shows) that 2 random* search finds & good features, but that 98 [evolution] finds better %20 ones!";

            //创建交错数组
            string[][] S = new string[3][];

            int i = 0;
            int j = 0;
            int k = 0;
            foreach(char ch in str)
            {
                //数字
                if (char.IsDigit(ch))
                {
                    S[0][i] = ch;
                    i++;
                }
                //字母
                else if (char.IsLetter(ch))
                {
                    S[1][j] = ch;
                    j++;
                }
                //其他
                else 
                {
                    S[2][k] = ch;
                    k++;
                }
            }

            //输出结果
            for (int m = 0; m < S.Length; m++)
            {
                Console.WriteLine(S[m]);
            }

            Console.ReadLine();
        }
    }
}
