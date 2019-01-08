using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace destructor_function
{
    class myclass
    {
        public int i=0, j=0;
        public myclass(int i, int j)//构造函数与定义函数的差别
        {
            Console.WriteLine("i={0},j={1}", i, j);
        }
        ~myclass()//destructed myclass function 不能被显式的调用
        {
            Console.WriteLine("Destructed {0}", this);
        }
        static void Main(string[] args)
        {
            myclass sd = new myclass(123, 234);
            int i = new int();//int i=100;//构造->初始化
            i = 100;
            Console.WriteLine("i={0}", i);
            Console.ReadLine();
        }
    }
}
