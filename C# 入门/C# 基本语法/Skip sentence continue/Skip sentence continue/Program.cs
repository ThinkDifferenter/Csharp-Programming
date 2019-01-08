using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skip_sentence_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 7; i < 100; i++)
            {
                if (i % 7 != 0)
                {
                    continue;
                }
                Console.Write(i + "\t");
            }
            Console.ReadLine();
        }
    }
}
