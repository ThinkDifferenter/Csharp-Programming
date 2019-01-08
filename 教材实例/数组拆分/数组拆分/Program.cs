using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 数组拆分
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[] arr2 = new int[3];
            int[] arr3 = new int[3];
            for (int i = 0; i < arr1.Rank; i++)
            {
                for (int j = 0; j < arr1.GetUpperBound(arr1.Rank - 1) + 1; j++)
                {
                    switch (i)
                    {
                        case 0: arr2[j] = arr1[i, j]; break;
                        case 1: arr3[j] = arr1[i, j]; break;
                    }
                }
            }
            Console.WriteLine("拆分后的二维数组为:");
            Console.WriteLine("一维数组1:");
            foreach (int i in arr2)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine("\ns一维数组2:");
            foreach (int i in arr3)
            {
                Console.Write(i + "\t");
            }
            Console.ReadLine();
        }
    }
}
