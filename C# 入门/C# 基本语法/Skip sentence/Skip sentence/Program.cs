using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skip_sentence
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, cnt = 0, sum = 0;
            //double  average=0;
            for (; ; )
            {
                Console.Write("inter i:");
                i = Convert.ToInt32(Console.ReadLine());
                if (i == -1)
                {
                    break;
                }
                sum += i;
                cnt++;
                
            }
            Console.WriteLine("the sum is {0}", sum);
            Console.WriteLine("the averagw is {0}", (double)sum / cnt);
            Console.ReadLine();
        }
    }
}
