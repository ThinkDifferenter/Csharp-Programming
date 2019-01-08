using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace function_override_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("调用negative(-100)的结果为：{0}", negative(-100));
            Console.WriteLine("调用negative(1.5)的结果为:{0}", negative(1.5));
            Console.WriteLine("调用nagetive(1234567890)的结果为:{0}", negative(1234567890));
            Console.ReadLine();
        }
        static int nagative(int i)//参数类型
        {
            return -i;
        }
        static double nagetive(double i)
        {
            return -i;
        }
        static long negative(long i)
        {
            return -i;
        }
    }
}
