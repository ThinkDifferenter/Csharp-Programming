using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 结构的使用
{
    class Program
    {
        public struct Rect
        {
            public double w;
            public double h;
            public Rect(double x, double y)//结构函数
            {
                w = x;
                h = y;
            }
            public double Are()
            {
                return w * h;
            }
        }
        static void Main(string[] args)
        {
            Rect r1;
            r1.h = 3;
            r1.w = 4;
            Console.WriteLine("矩形的面积为:" + r1.Are());
            Rect r2=new Rect(4,5);//设置矩形属性
            Console.WriteLine("矩形的面积为:" + r2.Are());
            Console.ReadLine();
        }
    }
}
