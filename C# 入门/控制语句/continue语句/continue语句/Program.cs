using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace continue语句
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=10;i++)
            {
                if(i%2==0)
                {
                    continue;
                }
                Console.WriteLine("当前输出的书为:{0}", i);
            }
            Console.ReadLine();
        }
    }
}
