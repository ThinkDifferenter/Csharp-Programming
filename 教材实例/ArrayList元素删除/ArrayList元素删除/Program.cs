using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ArrayList元素删除
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 ,7,8,9};
            ArrayList List = new ArrayList(arr);
            Console.WriteLine("原ArrayList集合:");
            foreach (int i in List)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            List.RemoveRange(0, 5);//删除指定范围的数据
            Console.WriteLine("删除元素后的ArrayL集合:");
            foreach (int i in List)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            List.Remove(9);//删除集合中与参数相匹配的数据
            Console.WriteLine("删除元素后的ArrayL集合:");
            foreach (int i in List)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            List.RemoveAt(2);//删除指定下标的元素
            Console.WriteLine("删除元素后的ArrayL集合:");
            foreach (int i in List)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
