using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace break语句
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while(i<=10)
            {
                Console.WriteLine("当前i为:{0}", i);
                i++;
                if(i==5)
                {
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
