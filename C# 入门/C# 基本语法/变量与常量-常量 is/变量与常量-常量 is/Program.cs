using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 变量与常量_常量_is
{
    class Class1
    {
        class Class2 { }
        class Istest
        {
            static void Test(object  obj)
            {
                Class1 a;
                Class2 b;
                if(obj is Class1)
                {
                    Console.WriteLine("obj is class1");
                    a = (Class1)obj;
                }
                else if(obj is Class2)
                {
                    Console.WriteLine("obj is claa2");
                    b = (Class2)obj;
                }
                else
                {
                    Console.WriteLine("obj is neither Class1 nor Class2.");
                }
            }
            static void Main(string[] args)
            {
                Class1 c1 = new Class1();
                Class2 c2 = new Class2();
                Test(c1);
                Test(c2);
                Test("a string");
                Console.ReadLine();
            }
        }

    }
}
