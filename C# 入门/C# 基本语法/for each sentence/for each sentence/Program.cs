using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace for_each_sentence
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] a={'J','i','a','n','g'};//array defination
            int[] b = { 1, 9, 9, 6, 0, 3, 2, 7 };//array defination
            foreach (char ch  in a)
            {
                Console.Write(ch);
            }
            Console.WriteLine();
            Console.Write("------------------------------------\n");
            foreach (int i in b)
            {
                Console.Write(i);
            }
            Console.ReadLine();
        }
    }
}
