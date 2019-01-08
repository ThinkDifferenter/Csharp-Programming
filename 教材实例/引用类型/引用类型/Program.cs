using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 引用类型
{
    public class C
    {
        public int Value = 0;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int v1 = 0;
            int v2 = v1;
            v2 = 123;
            C r1 = new C();
            r1.Value = 123;
            C r2 = r1;
            r2.Value = 234;
            Console.WriteLine("v1={0},v2={1}\n", v1, v2);
            Console.WriteLine("r1.value={0},r2.value={1}", r1.Value, r2.Value);
            //引用类型，数据管理者，相当于指针。
            Console.ReadLine();
        }
    }
}
