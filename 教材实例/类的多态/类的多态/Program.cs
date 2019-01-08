using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 类的多态//即同一事件在不同的场合中不同的叫法
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
        public virtual int Add1()//注意：add函数没有参数
        {
            return X + Y;//属性的相加
        }
    }

    class Myclass2 : Myclass1
    {
        public override int Add1()
        {
            int x = 5;
            int y = 7;
            return x + y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Myclass2 myclass2 = new Myclass2();
            Myclass1 myclass1 = (Myclass1)myclass2;//与强制类型转化相似
            myclass1.X = 3;
            myclass1.Y = 5;
            Console.WriteLine("类2中的sum:"+myclass2.Add1());
            Console.WriteLine("类1中的sun" + myclass1.Add1());
            Console.ReadLine();
        }
    }
}
