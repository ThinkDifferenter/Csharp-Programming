using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skip_sentence_return
{
    class Program
    {
        public static int Min(int i, int j)
        {
            return i < j ? i : j;
        }
        static void Main(string[] args)
        {
            int i, j,k;
            Console.WriteLine("inter i,j:");
            i = Convert.ToInt32(Console.ReadLine());
            j = Convert.ToInt32(Console.ReadLine());
            k=Min(i,j);
            Console.WriteLine("the min is {0}",k);
            Console.ReadLine();
        }
    }
}
