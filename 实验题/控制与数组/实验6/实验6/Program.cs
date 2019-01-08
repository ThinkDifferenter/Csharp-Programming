using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 实验6
{
    class Program
    {
        static void Main(string[] args)
        {
            //三重循环求水仙花数
            Console.WriteLine("三重循环求水仙花数");
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    for (int k = 0; k <= 9; k++)
                    {
                        if ((i*100 + j * 10 + k) == (i * i * i + j * j * j + k * k * k))
                        {
                            Console.WriteLine("水仙花数:" + (i * 100 + j * 10 + k));
                        }
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
