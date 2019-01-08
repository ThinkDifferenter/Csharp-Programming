using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Struct
{

    struct date
    {
        public int year;
        public int month;
        public int day;
    };
    class Program
    {
        static void Main(string[] args)
        {
            date today;
            today.year = 2016;
            today.month = 4;
            today.day = 25;
            Console.WriteLine("Today is {0}.{1}.{2}",today.year,today.month,today.day);
            Console.ReadLine();
        }
    }
}
