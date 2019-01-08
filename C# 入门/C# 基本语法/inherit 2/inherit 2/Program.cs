using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inherit_2
{
    public class baseclass
    {
        public static void show()
        {
            Console.WriteLine("这是基类的函数");
        }
    }
    public class derivedclass : baseclass
    {
        public new static void show()//没有new编译器会给warning!
        {
            Console.WriteLine("这是派生类的函数");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            derivedclass.show();//编译器对语法的检测较严格！
            
            Console.ReadLine();
        }
    }
}
