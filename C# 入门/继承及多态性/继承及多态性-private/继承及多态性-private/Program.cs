using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//派生类和外部代码都无法访问基类中的private成员，但可以利用public成员来访问private成员
namespace 继承及多态性_private
{
    public class Shape
    {
        private double Numo;
        private double Numt;
        public double getNumo() { return Numo; }
        public double getNumt() { return Numt; }
        public void Setnumo(double w)
        {
            Numo = w;
        }
        public void Setnumt(double h)
        {
            Numt = h;
        }
    }
    public class Anther:Shape
    {
        public void area()
        {
            Console.WriteLine("输出两个数的乘积:{0}", getNumo()*getNumt());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Anther aclass = new Anther();
            aclass.Setnumo(1.25);
            aclass.Setnumt(2.56);
            aclass.area();
            Console.ReadLine();
        }
    }
}
