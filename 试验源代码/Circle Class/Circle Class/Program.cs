using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Circle_Class
{
    public class Circle
    {
        //圆心坐标px,py
        private double px;
        private double py;

        //圆的半径 radius
        private double radius;

        //定义Px属性
        public double Px
        {
            get
            {
                return px;
            }
            set
            {
                px = value;
            }
        }

        //定义Py属性
        public double Py
        {
            get
            {
                return py;
            }
            set
            {
                py = value;
            }
        }

        //定义Radius属性
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        //求圆的面积
        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        //比较圆的面积 静态方法（类方法）
        public static void Compare(Circle c1,Circle c2)
        {
            if (c1.Radius > c2.Radius)
            {
                Console.WriteLine("前者大!");
            }
            if (c1.Radius == c2.Radius)
            {
                Console.WriteLine("相等!");
            }
            if (c1.Radius < c2.Radius)
            {
                Console.WriteLine("后者大!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //创建圆的实例c1
            Circle c1 = new Circle();
            c1.Px = 1.2;
            c1.Py = 1.3;
            c1.Radius = 10;
            //输出信息
            Console.WriteLine("圆心的坐标为:({0},{1})", c1.Px, c1.Py);
            Console.WriteLine("圆的面积为:{0}", c1.GetArea());

            //创建圆的实例c2
            Circle c2 = new Circle();
            c2.Px = 1.4;
            c2.Py = 1.5;
            c2.Radius = 12;
            //输出信息
            Console.WriteLine("\n圆心的坐标为:({0},{1})", c2.Px, c2.Py);
            Console.WriteLine("圆的面积为:{0}\n", c2.GetArea());

            //比较圆的面积大小
            Circle.Compare(c1, c2);

            

            Console.ReadLine();
        }
    }
}
