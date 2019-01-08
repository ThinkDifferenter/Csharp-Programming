using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace constructed_function_in_baseclass_2
{
    public class firstclass
    {
        protected firstclass(string A, string B)
        {
            Console.WriteLine("this is in the first baseclass");
            Console.WriteLine("the first baseclass is inherited");
            Console.WriteLine("the first parameter:{0}", A);
            Console.WriteLine("the second paramenter:{0}", B);
            Console.WriteLine();
        }
    }
    public class personclass : firstclass
    {
       // protected string a;
        protected personclass(string T, string M)
            : base(T, M)//每个基类中的构造函数有参数的话需要通过base关键字来传递参数
        {
            Console.WriteLine("constructed function in baseclass");
            Console.WriteLine("the baseclass is inheritde");
            Console.WriteLine("the first paramenter:{0}", T);
            Console.WriteLine("the second paramenter:{0}", M);
            Console.WriteLine();
        }
    }

    public class myclass : personclass
    {
        public myclass(string N, string I)
            : base(N, I)//基类的构造函数可通过派生类一次调用
        {
            Console.WriteLine("constructed function in dericedclass");
            Console.WriteLine("the name is {0}", N);
            Console.WriteLine("the id is {0}", I);
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myclass sd = new myclass("jiangjun","1920154944");
            Console.ReadLine();
        }
    }
}
