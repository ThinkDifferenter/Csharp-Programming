using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inherit_3
{
    public class class1
    {
        public static int i = 123;
        protected static int j = 234;
        internal static int k=345;
    }
    public class class2 : class1
    {
        public static double n = 3.14;
        private static double m = 2.718;
        public static double Return()//private 数据调用方式
        {
            return m;
        }
    }
    class class3:class2
    {
        static void Main(string[] args)
        {
            double a = class3.Return();
            Console.WriteLine("class1 :i+j={0}", class1.i+class3.j);
            Console.WriteLine("class2 :n={0}", class3.n);
            Console.WriteLine("class1 :k={0}", class3.k);
            Console.WriteLine("class2 :m={0}", a);
            Console.ReadLine();
        }
    }
}
