using System;
using System.Collections.Generic;
using System.Text;

namespace 实验6
{
    class Program
    {
        static void Main(string[] args)
        {
              /*string 对象是不可改变的。
            每次使用string 类中的方法之一时，
             都要在内存中创建一个新的字符串对象，
            这就需要为该新对象分配新的空间。
            在需要对字符串执行重复修改的情况下，
            与创建新的 string 对象相关的系统开销可能会非常昂贵。
            如果要修改字符串而不创建新的对象，则可以使用 StringBuilder 类。
            例如，当在循环中将许多字符串连接时，用 StringBuilder 类可以提升性能。
              */

             string a = "good";
             string b = a;
             b += "bye";

             Console.WriteLine("a={0}", a);
             Console.WriteLine("b={0}", b);

             b = a.Insert(4, "dddd");
             Console.WriteLine("\n");
             Console.WriteLine("a={0}", a);
             Console.WriteLine("b={0}", b);

             b = a.Replace("oo", "QQ");
             Console.WriteLine("\n");
             Console.WriteLine("a={0}", a);
             Console.WriteLine("b={0}", b);

             //StringBuilder MyStringBuilder =  "Hello World!"; //出错
             StringBuilder StrBuA = new StringBuilder("Hello World!");
             StringBuilder StrBuB = StrBuA;

             StrBuB.Append(" Good");
             Console.WriteLine("\n");
             Console.WriteLine("StrBuA={0}", StrBuA);
             Console.WriteLine("StrBuB={0}", StrBuB);

             Console.WriteLine("\n");
            double c = 25.0;
            StrBuA = new StringBuilder("Your total is ");
            StrBuA.AppendFormat("{0:f4}", c);
            Console.WriteLine("StrBuA={0}", StrBuA);

            Console.WriteLine("\n");
            StrBuA = new StringBuilder("Hello World!");
            StrBuA.Insert(6, "Beautiful ");
            Console.WriteLine("StrBuA={0}", StrBuA);

            Console.WriteLine("\n");
            StrBuA = new StringBuilder("Hello World!");
            StrBuA.Remove(5, 7);
            Console.WriteLine("StrBuA={0}", StrBuA);

            Console.WriteLine("\n");
            StrBuA = new StringBuilder("Hello World!");
            StrBuA.Replace("o", "OO");
            Console.WriteLine("StrBuA={0}", StrBuA);

            Console.ReadLine();
        }
    }
}