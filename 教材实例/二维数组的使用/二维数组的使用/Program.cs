using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 二维数组的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,]arr=new int[2,2]{{1,2},{3,4}};
            Console.WriteLine("数组的行数为:{0}",arr.Rank);//取二维数组行数
            Console.WriteLine("数组的列数为:{0}", arr.GetUpperBound(arr.Rank - 1) + 1);//取二维数组列数
            for (int i = 0; i < arr.Rank; i++)
            {
                for (int j = 0; j < arr.GetUpperBound(arr.Rank - 1) + 1; j++)
                {
                    Console.Write(arr[i, j]+"\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
