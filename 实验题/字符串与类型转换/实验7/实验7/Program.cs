using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace 实验7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nConvert.ToDouble:");
            string str = "123.67";
            double b = Convert.ToDouble(str);
            Console.WriteLine("b={0}", b);

            Console.WriteLine("\nConvert.ToString:");
            b = 14125125.89;
            str = Convert.ToString(b);
            Console.WriteLine("str={0}", str);

            Console.WriteLine("\nConvert.ToInt32:");
            str = "121249";
            int Ia = Convert.ToInt32(str);
            Console.WriteLine("Ia={0}", Ia);

            Console.WriteLine("\nDateTime.Now:");
            DateTime dt;
            dt = DateTime.Now;
            str = dt.ToString("yyyy/MM/dd HH:mm:ss");
            Console.WriteLine("dt={0}", str);

            Console.WriteLine("\nDateTime.ToString:");
            str = dt.ToString("yyyy年MM月dd日 HH:mm:ss");
            Console.WriteLine("dt={0}", str);

            Console.WriteLine("dt.Year={0}", dt.Year);
            Console.WriteLine("dt.Month={0}", dt.Month);
            Console.WriteLine("dt.Hour={0}", dt.Hour);

            Console.WriteLine("\nConvert.ToDateTime:");
            DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
            dtFormat.FullDateTimePattern = "yyyy年MM月dd日 HH:mm:ss";
            dt = Convert.ToDateTime("2014年09月22日 12:12:05", dtFormat);
            Console.WriteLine("dt ={0}", dt);

            dtFormat.FullDateTimePattern = "yyyy年MM月dd日";
            DateTime dt2 = Convert.ToDateTime("2014年09月25日", dtFormat);
            Console.WriteLine("dt2={0}", dt2);

            Console.ReadLine();
        }
    }
}