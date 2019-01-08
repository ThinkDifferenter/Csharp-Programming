using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 枚举类型
{
    class Program
    {
        //设定星期枚举类型
        enum MyDate
        {
            Sun = 0,
            Mon = 1,
            Tue = 2,
            Wed = 3,
            Thi = 4,
            Fri = 5,
            Sat = 6
        }
        //判断日期
        static void Main(string[] args)
        {
            //获得当天所在星期并强制类型转化
            int date = (int)DateTime.Now.DayOfWeek;
            //显示当天日期
            Console.WriteLine("Today is " + DateTime.Now.DayOfWeek);
            Console.WriteLine("Today is " + DateTime.Now);
            //多路选择判断
            switch (date)
            {
                case (int)MyDate.Sun: Console.WriteLine("今天是星期日"); break;
                case (int)MyDate.Mon: Console.WriteLine("今天是星期一"); break;
                case (int)MyDate.Tue: Console.WriteLine("今天是星期二"); break;
                case (int)MyDate.Wed: Console.WriteLine("今天是星期三"); break;
                case (int)MyDate.Thi: Console.WriteLine("今天是星期四"); break;
                case (int)MyDate.Fri: Console.WriteLine("今天是星期五"); break;
                case (int)MyDate.Sat: Console.WriteLine("今天是星期六"); break;
            }
            Console.ReadLine();
        }
    }
}
