using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace if_nest_sentence
{
    class Program
    {
        public static int max(int i, int j, int k)
        {
            return i > j ? (i > k ? i : k) : (j > k ? j : k);
        }
        static void Main(string[] args)
        {
            int i, j, k,Max;
            Console.WriteLine("inter i,j,k:");
            i = Convert.ToInt32(Console.ReadLine());
            j = Convert.ToInt32(Console.ReadLine());
            k = Convert.ToInt32(Console.ReadLine());
            Max = max(i, j, k);
            Console.WriteLine("the max is " + Max);
            Console.ReadLine();
        }
    }
}
