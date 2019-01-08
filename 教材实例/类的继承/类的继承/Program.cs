using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 类的继承
{
    class Myclass1
    {
        private int x = 0;
        private int y = 0;
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public int Add1()//注意：add函数没有参数
        {
            return X + Y;//属性的相加
        }
    }

    class Myclass2:Myclass1
    {
        private int z;
        public int Z
        {
            get
            {
                return z;
            }
            set
            {
                z=value;
            }
        }
        public int Add2()//注意：add函数没有参数
        {
            return X+Y+Z;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass1 myclass1 = new Myclass1();
            Myclass2 myclass2 = new Myclass2();
            myclass1.X = 3;
            myclass1.Y = 4;
            myclass2.X = 3;
            myclass2.Y = 4;
            myclass2.Z = 5;
            Console.WriteLine("类1中x+y="+myclass1.Add1());
            Console.WriteLine("类2中x+y="+myclass2.Add1());//类2中调用类1的方法
            Console.WriteLine("类2中x+y+z=" + myclass2.Add2());
            Console.ReadLine();
        }
    }
}
