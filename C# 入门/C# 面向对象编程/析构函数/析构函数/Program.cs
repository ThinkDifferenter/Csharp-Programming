using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 析构函数
{
    class Program
    {
        public int x, y;
        public Program (int x,int y)
        {
            Console.WriteLine("x={0},y={1}", x, y);
        }
        ~Program()//析构函数 ~
        {
            Console.WriteLine("Destructed {0}", this);
        }
        static void Main(string[] args)
        {
            Program sd = new Program(35, 43);
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.ReadLine();
        }
    }
}
