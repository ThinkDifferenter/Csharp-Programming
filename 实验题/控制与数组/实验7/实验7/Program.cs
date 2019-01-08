using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 实验7
{
    class Program
    {
        static void Main(string[] args)
        {
            //四重循环求水仙花数
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    for (int k = 0; k <= 9; k++)
                    {
                        for (int l = 0; l <= 9; l++)
                        {
                            if ((i * 1000 + j * 100 + k * 10+ l) == (i * i * i * i + j * j * j * j + k * k * k * k + l * l * l *l))
                            {
                                Console.WriteLine("四重水仙花数:" + (i * 1000 + j * 100 + k * 10 + l));
                            }
                        }
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
