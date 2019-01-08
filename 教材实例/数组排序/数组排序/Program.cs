using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 数组排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[]{23,45,12,54,9,76,34,10,24};
            Console.WriteLine("\n排序前的数据为:");
            foreach (int i in arr)
            {
                Console.Write(i + "\t");
            }
            Array.Sort(arr);
            Console.WriteLine("\n排序后的数据为:");
            foreach (int i in arr)
            {
                Console.Write(i + "\t");
            }
            Array.Reverse(arr);
            Console.WriteLine("\n反序后的数据为:");
            foreach (int i in arr)
            {
                Console.Write(i + "\t");
            }
            Console.ReadLine();
        }
    }
}
