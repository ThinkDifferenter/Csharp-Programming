using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace private_date
{
    class Program
    {
        private static int i = 123;//1.private 数据调用 2.在类中定义公共的方法将私有的变量公共化来调用类中的私有变量
        static void Main(string[] args)
        {
            int j = 234;
            Console.WriteLine("i+j={0}", i + j);
            Console.ReadLine();
        }
    }
}
