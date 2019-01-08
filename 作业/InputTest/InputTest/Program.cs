using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InputTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入您的姓名:");
            string Name=Console.ReadLine();

            Console.WriteLine("请输入您的年龄:");
            int Age =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("请输入您的学号:");
            int Num = int.Parse(Console.ReadLine());

//            Console.WriteLine("请输入您的电话:");
//            string t = Console.ReadLine();
//            int Mobile = int.Parse(Mobile);无法完成强制类型转化

            Console.WriteLine("您的姓名是: " + Name);
            Console.WriteLine("您的年龄是: " + Age);
            Console.WriteLine("您的学号是:" + Num);
            //Console.WriteLine("您的电话是;" + Mobile);

            Console.ReadLine();
        }
    }
}
