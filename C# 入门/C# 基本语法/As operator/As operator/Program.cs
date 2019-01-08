using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace As_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] arr = new object[2];
            arr[1] = "test";
            arr[0] = 123;
            for (int j = 0; j < arr.Length; j++)
            {
                Console.WriteLine(arr[j]);
            }
            Console.WriteLine("----------------------------");
            for (int i = 0; i < arr.Length; i++)
            {
                string s = arr[i] as string;
                if (s != null)
                {
                    Console.Write("i={0}\n", s);
                }
            }
            Console.ReadLine();
        }
    }
}
