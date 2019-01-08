using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 重载构造函数
{
    class Program
    {
        public Program()
        {
            Console.WriteLine("调用无参数构造函数");
        }
        public Program(int a)
        {
            Console.WriteLine("调用参数为一个整数的构造函数");
        }
        public Program(double a)
        {
            Console.WriteLine("调用参数为一个浮点数的构造函数");
        }
        static void Main(string[] args)
        {
            Program sd = new Program();
            Program ssd = new Program(5);
            Program sdd = new Program(1.0);
            Console.ReadLine();
        }
    }
}
