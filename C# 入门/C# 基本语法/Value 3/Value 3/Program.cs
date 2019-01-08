using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Value_3
{
    class Program
    {
        public static void show(int i,int j)
        {
            Console.WriteLine("{0}>{1}", i, j);
        }
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("inter i,j:");
            i = Convert.ToInt32(Console.ReadLine());
            j = Convert.ToInt32(Console.ReadLine());
            if (i > j)
            {
                show(i, j);
            }
            else
            {
                show(j, i);
            }
            Console.ReadLine();
        }
    }
}
