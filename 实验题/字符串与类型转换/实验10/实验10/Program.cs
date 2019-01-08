using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using System.Globalization;

namespace 实验10
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt;

            //设置时间输出格式
            DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
            dtFormat.FullDateTimePattern = "yyyy年MM月dd日 HH:mm:ss";
            string str = "2014年09月22日 12:12:05";

            //字符串转化成dateti
            dt = Convert.ToDateTime(str, dtFormat);

            //添加100天
            dt = dt.AddDays(100); 
            str = dt.ToString("yyyy年MM月dd日 HH时,mm分,ss秒");
            Console.WriteLine(str);

            Console.ReadLine();
        }
    }
}
