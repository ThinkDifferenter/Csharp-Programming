using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mutiply_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,]a=new int[3,4];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = i + j;
                    Console.WriteLine("a[{0},{1}]={2}", i, j, a[i, j]);
                }
            }
            Console.ReadLine();
        }
    }
}
