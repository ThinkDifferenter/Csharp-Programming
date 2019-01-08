using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace delegate_2
{
    class Program
    {
        delegate int usedelegate(int i, int j);
        static int addition(int i ,int j)
        {
            return i+j;
        }
        static int subtraction(int i, int j)
        {
            return i - j;
        }
        static void Main(string[] args)
        {
            usedelegate dg;
            Console.WriteLine("input two unber i,j:");
            int i = Convert.ToInt32(Console.ReadLine());
            int j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input 1 for sum,input -1 for subtraction:");
            int k = Convert.ToInt32(Console.ReadLine());
            if (k == 1)
            {
                dg = new usedelegate(addition);
            }
            else
            {
                dg = new usedelegate(subtraction);
            }
            Console.WriteLine("the result is {0}", dg(i, j));
            Console.ReadLine();
        }
    }
}
