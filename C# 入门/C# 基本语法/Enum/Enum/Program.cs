using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enum
{
    class Program
    {
        enum Days { Mon = 1, Tue , Wed , Thu = 4, Fri = 8, Sta, Sun };
        static void Main(string[] args)
        {
            Days Day1 = Days.Wed;
            Days Day2 = Days.Sta;
            int a = (int)Day1;
            int b = (int)Day2;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
