using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 构造函数
{
    class Program
    {
        public  Program()//构造函数
        {
            Console.WriteLine("Constructor");
        }
        static void Main(string[] args)
        {
            Program sd = new Program();//自动调用构造函数
            Console.ReadLine();
        }
    }
}
