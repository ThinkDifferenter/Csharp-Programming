using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 数组的合并
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new[] { 1, 2, 3, 4 };
            int[] arr2 = new[] { 5, 6, 7, 8 };
            int n = arr1.Length + arr2.Length;
            int[] arr3 = new int[n];
            for (int i = 0; i < arr3.Length; i++)
            {
                if (i < arr1.Length)
                {
                    arr3[i] = arr1[i];
                }
                else
                {
                    arr3[i] = arr2[i - arr1.Length];
                }
            }
            Console.WriteLine("合并后的一维数组:");
            foreach (int i in arr3)
            {
                Console.Write(i+"\t");
            }

            Console.WriteLine("\n数组合并为二维数组:");
            int[,] arr4 = new int[2, 4];
            for (int i = 0; i < arr4.Rank; i++)
            {
                switch (i)
                {
                    case 0:
                        {
                            for (int j = 0; j < arr1.Length; j++)
                            {
                                arr4[i, j] = arr1[j];
                            }
                            break;
                        }
                    case 1:
                        {
                            for (int j = 0; j < arr2.Length; j++)
                            {
                                arr4[i, j] = arr2[j];
                            }
                            break;
                        }
                }
            }
            Console.WriteLine("\n合并后的二维数组为:");
            for (int i = 0; i < arr4.Rank; i++)
            {
                for (int j = 0; j < arr4.GetUpperBound(arr4.Rank - 1) + 1; j++)
                {
                    Console.Write(arr4[i, j]+"\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
