using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 动态二维数组
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入动态二维数组的行数:");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("输入动态二维数组的列数:");
            int col = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(i + j.ToString() + " ");
                }
                Console.WriteLine();
            
            Console.ReadLine();
        }
    }
}
