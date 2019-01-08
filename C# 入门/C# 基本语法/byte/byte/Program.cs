using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace @byte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sizeof(byte) is {0}", sizeof(byte));
            byte b=0,i,j;
            while (b >= 0)
            {
                b++;
            }
            i=b;
            Console.WriteLine("b={0}", b);
            while(b<=0)
            {
                b--;
            }
            j=b;
            Console.WriteLine("The range of byte is {0} to {1}", i - 1,j + 1);
            Console.ReadLine();
        }
    }
}
