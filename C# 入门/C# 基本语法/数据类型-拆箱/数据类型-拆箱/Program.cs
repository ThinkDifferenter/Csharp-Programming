using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据类型_拆箱
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            object obj = i;
            int j = (int)obj;
            if(j is object)
            {
                Console.WriteLine("the value of j is unboxing");
            }
            Console.ReadLine();
        }
    }
}
