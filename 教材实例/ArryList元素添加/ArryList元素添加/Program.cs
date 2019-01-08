using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ArryList元素添加
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
            ArrayList List = new ArrayList(arr);
            Console.WriteLine("原ArrayList 集合:"); 
            foreach (int i in List)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for (int i = 1; i < 5; i++)
            {
                List.Add(i + arr.Length);//将对象添加到集合尾处
            }
            Console.WriteLine("使用Add方法添加:");
            foreach (int i in List)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            List.Insert(6, 6);//在指定位置插入数据
            foreach (int i in List)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
