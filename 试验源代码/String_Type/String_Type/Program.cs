using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace String_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            //值类型
            int a = 1;
            int b = a;
            a = 2;
            Console.WriteLine("a is {0},b is {1}", a, b);

            //字符串
            string str1 = "ab";
            string str2 = str1;
            str1 = "abc";
            Console.WriteLine("str1 is {0},str2 is {1}", str1, str2);

            StringBuilder strb1 = new StringBuilder("abc");
            StringBuilder strb2 = new StringBuilder("abc");

            Console.WriteLine("\nReference equal for string: " + Object.ReferenceEquals(str1, str2)); //结果true
            
            Console.WriteLine("Reference equal for int: " + Object.ReferenceEquals(a, b)); //结果false
            
            Console.WriteLine("Reference equal for StringBuilder: " + Object.ReferenceEquals(strb1, strb2)); //结果false
            
            Console.WriteLine("Value equal for string: " + str1.Equals(str2)); //结果true，类似于值类型

            Console.ReadLine();
        }
    }
}
