using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据类型_装箱
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            object obj = i;
            if(obj is int)
            {
                Console.WriteLine("the value of i is boxing");
            }
            i = 20;
            Console.WriteLine("int:i={0}", i);
            Console.WriteLine("object:obj={0}", obj);
            Console.ReadLine();
        }
    }
}
