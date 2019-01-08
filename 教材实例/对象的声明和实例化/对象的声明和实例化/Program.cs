using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 对象的声明和实例化
{
    class Myclass
    {
        private int x;
        private int y;
        private int z;
        public int X//构造属性
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
        public int Z
        {
            get
            {
                return z;
            }
            set
            {
                z = value;
            }
        }
        public Myclass()//构造函数
        {
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass myclass = new Myclass();
            int x = 3;
            int y = 4;
            myclass.X = 3;
            myclass.Y = 4;
            myclass.Z = myclass.X + myclass.Y;//属性的读写性
            Console.WriteLine("the sum ofx and y is {0}", myclass.Z);
            Console.ReadLine();
        }
    }
}
