using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using System.Globalization;

namespace 实验9
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt;

            while (true)
            {
                //输出时间
                dt = DateTime.Now;
                string s = dt.ToString("yyyy年MM月dd日 HH时,mm分,ss秒");
                Console.Clear();
                Console.WriteLine(s); 

                //当分钟为一的时候输出*
                if (dt.Minute == 1)
                {
                    Console.WriteLine('*');
                }
            }
        }
    }
}
