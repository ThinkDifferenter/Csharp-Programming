using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据类型6
{
    class Program
    {
        enum Days { Mon=1,Tue=2,Wed=3,Thu=4,Fri=5,Sta=6,Sun=7 };
        static void Main(string[] args)
        {
            int i;
            
            Days aday=Days.Wed;
            int a = (int)aday;
            Console.WriteLine(a);
            Console.WriteLine("the sizeof(int) is "+sizeof(int));
            Console.ReadLine();

            Console.WriteLine("\n");
     

        }
    }
}
