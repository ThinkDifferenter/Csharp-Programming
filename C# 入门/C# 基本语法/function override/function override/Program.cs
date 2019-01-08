using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace function_override
{
    class Program
    {
        static void func(int i)
        {
            Console.WriteLine("this {0} is in func(int i)",i);
        }
        static void func(int i, int j)//参数数目
        {
            Console.WriteLine("this {0} {1} is in func(int i,int j)", i , j);
        }
        static void func(double i, double j)//参数类型
        {
            Console.WriteLine("this {0} {1} is in  int func(double i,double j)",i,j);
        }
        static void func(double j,int i)//参数顺序
        {
            Console.WriteLine("this {0} {1} is in int func(double j,int i)", j, i);
        }
        static void func(int i, double j)//重构
        {
            Console.WriteLine("this {0} {1} is in int func(int j,double i)", i, j);
        }
        static void Main(string[] args)
        {
            int i = 123;
            int j = 234;
            double m = 345.0;
            double n = 456.0;
            func(i);
            func(i, j);
            func(m, n);
            func(i, m);
            func(m, j);
            Console.ReadLine();
        }
    }
}
