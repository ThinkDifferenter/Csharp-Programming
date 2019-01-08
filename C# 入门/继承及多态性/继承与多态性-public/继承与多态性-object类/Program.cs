using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承与多态性_object类
{
    class Area
    {
        public double width;
        public double length;
        public void Showarea()
        {
            Console.WriteLine("图形的面积是:{0}", width * length);
        }
    }
    class Peri:Area
    {
        public void Showperi()
        {
            Console.WriteLine("图形的周长是:{0}", 2 * (width + length));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Peri shape = new Peri();
            Console.WriteLine("请输入图形的宽度:");
            shape.width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入图形的长度:");
            shape.length = Convert.ToDouble(Console.ReadLine());
            shape.Showarea();
            shape.Showperi();
            Console.ReadLine();
        }
    }
}
