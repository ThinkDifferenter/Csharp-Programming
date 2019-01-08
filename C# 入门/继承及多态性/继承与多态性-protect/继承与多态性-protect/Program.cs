using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//protect成员，只有派生类才可以访问，基类和外部代码不能访问protect成员
namespace 继承与多态性_protect
{
    public class Firstclass
    {
        protected double n = 3.1415;
        protected double m = 12.6;
        public void Thearea()
        {
            Console.WriteLine("定义的两个数分别是:{0}和{1}", n, m);
        }
        protected void Thesum()
        {
            Console.WriteLine("定义的两个数和为:{0}", (n + m));
        }
    }

    public class Secondclass:Firstclass
    {
        public void Show()
        {
            Secondclass ac = new Secondclass();
            ac.Thesum();
            Console.WriteLine("基类中定、定义的两个数乘积为:{0}", (m * n));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Secondclass sc = new Secondclass();
            sc.Show();
            sc.Thearea();
            Console.ReadLine();
        }
    }
}
