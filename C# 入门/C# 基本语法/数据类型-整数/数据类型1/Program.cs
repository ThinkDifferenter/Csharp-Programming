using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据类型1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 255;
            sbyte b = 25;

            Console.WriteLine(a);
            Console.WriteLine("the sizeof (a) is " + sizeof(byte));
            Console.WriteLine(b);
            Console.WriteLine("the sizeof (b) is " + sizeof(sbyte));

            Console.ReadLine();
        }
    }
}
