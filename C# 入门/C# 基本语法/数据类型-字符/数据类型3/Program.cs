using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据类型3
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'A';
            char b = 'a';
            int c;
            c = a;
            Console.WriteLine(c);
            c = b;
            Console.WriteLine(c);
            Console.WriteLine("the sizeof(char) is " + sizeof(char));
            Console.ReadLine();
        }
    }
}
