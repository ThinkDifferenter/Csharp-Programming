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
            int i = 1;
           
            //循环求结果
            while (true)
            {
                if (i % 7 == 3 && i % 5 == 2 && i % 3 == 1)
                {
                    Console.WriteLine("同时被7除余3, 被5余2，被3除余1,的最小整数为:{0}" ,i);
                    break;
                }
                i++;
            }

            Console.ReadLine();
        }
    }
}
