using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace destructecd_function
{
    class myclass
    {
        public int x, y;
        public myclass(int x,int y)
        {
            Console.WriteLine("x={0},y={1}", x, y);
        }
        ~myclass()
        {
            Console.WriteLine("Destructed {0}", this);
        }

        static void Main(string[] args)
        {
            myclass newclass = new myclass(23,43);
            Console.ReadLine();
           //在所有代码执行完后自动调用析构函数(一闪而过，仔细看！)
        }
    }
}
