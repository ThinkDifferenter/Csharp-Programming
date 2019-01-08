using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 实验1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "hello";
            string b = "h";
          
            b += "ello";

            if (a == b)
            {
                Console.WriteLine("a==b");
            }
            else
            {
                Console.WriteLine("a！=b");
            }

            //==========可以用[]访问字符串中的各个字符===========
            Console.WriteLine("\n");
            a = "good " + "morning";
            Console.WriteLine(a);

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("a[{0}]={1}", i, a[i]);
            }

            //=============Substring  取字符子串===============
            Console.WriteLine("\nSubstring:");
            a = "good morning";
           string s1 = a.Substring(5, 3);
            Console.WriteLine(s1);  


            //=============Replace 替换字符子串===============
            Console.WriteLine("\nReplace:");
            a = "good morning";
            s1 = a.Replace("mor", "MOR");
            Console.WriteLine(s1);  
Console.WriteLine(a);


            //=============Insert 插入字符子串===============
            a = "Home cooking food features include recipes";
            Console.WriteLine("\nInsert:");
            s1 = a.Insert(5, "the ");
            Console.WriteLine(s1); 
Console.WriteLine(a);

            //=============Trim 删除开始与末尾空格===============
            a = "    Visual C# Express   ";
            Console.WriteLine("\nTrim:");
            s1 = a.Trim();
            Console.WriteLine(s1);   


            //=============Remove  删除指定起始位置及长度字符子串
            a = "Visual C# Express";
            Console.WriteLine("\nRemove:");
            s1 = a.Remove(3, 5);
            Console.WriteLine(s1);  

            //=============Split 将字符串划分子串===============
            a = "System.Console.WriteLine";
            Console.WriteLine("\nSplit:");
            string[] sa = a.Split('.');
            for (int i = 0; i < sa.Length; i++)
            {
                Console.WriteLine("sa[{0}]={1}", i, sa[i]);
            }

            //若要将字符串中的字母更改为大写或小写调用
            //============= ToUpper() 或 ToLower()，===============
            a = "System.Console.WriteLine";
            Console.WriteLine("\nToUpper, ToLower: ");
            string sUp = a.ToUpper();
            string sLow = a.ToLower();
            Console.WriteLine("sUp={0}",  sUp);
            Console.WriteLine("sLow={0}", sLow);


            //若要在一个字符串中搜索另一个字符串
            //=============可以使用 IndexOf()===============
            // 未找到搜索字符串，返回 -1，否则返回出现的第一个位置
            a = "System.Console.WriteLine";
            Console.WriteLine("\nIndexOf:");
            int index1 = a.IndexOf("te");
            int index2 = a.IndexOf("te", index1+1);
            Console.WriteLine("index={0}", index1);
            Console.WriteLine("index={0}", index2);

            Console.ReadLine();
        }
    }
}
