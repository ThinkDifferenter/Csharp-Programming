using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_first_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("开始程序");
            int number1;
            int number2;
            Console.WriteLine("输入第一个数:");
            number1 = Convert.ToInt32(Console.ReadLine());
            //int number=convert.ToInt32(Console.ReadLine());//输入一个数的方法
            Console.WriteLine("输入第二个数:");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("两个数的积是:{0}\n两个数的和是:{1}", number1 * number2, number2 + number1);
            Console.ReadLine();
        }
    }
}
