using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 装箱和拆箱
{
    class Program
    {
        static void Main(string[] args)
        {
            //装箱
            int i = 2016;
            object obj = i;
            Console.WriteLine("i={0},obj={1}\n", i, obj);
            //拆箱
            //double j = (double)obj;拆箱前后的数据类型要一致！
            int j = (int)obj;
            Console.WriteLine("j={0},obj={1}\n", j, obj);
            Console.ReadLine();
        }
    }
}
