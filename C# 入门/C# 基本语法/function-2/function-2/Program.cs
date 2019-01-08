using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace function_2
{
    public class myclass
    {
        public static int Maxvalue(int[] a, int n)
        {
            int max = a[0];
            for (int i = 0; i < n; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }
        public static void  myname()
        {
            Console.WriteLine("inter you name :");
            string name = Console.ReadLine();
            Console.WriteLine("myname is {0}", name);
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 12, 32, 45, 24, 14, 45 };
            myclass.myname();
            //Console.WriteLine("myname is {0}", myname);
            int max = myclass.Maxvalue(a, 6);
            Console.WriteLine("the max is {0}", max);
            Console.ReadLine();
        }
    }
}
