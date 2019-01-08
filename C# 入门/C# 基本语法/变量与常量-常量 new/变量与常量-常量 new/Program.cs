using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 变量与常量_常量_new
{
    class Program
    {
        struct Mystruct
        {
            public int x;
            public int y;
            public Mystruct (int x,int y)
            {
                this.x = x;
                this.y = y;
            }

        }
        class MyClass
        {
            public string name;
            public int ID;
            public MyClass()
            {

            }
            public MyClass (int ID,string name)
            {
                this.ID = ID;
                this.name = name;
            }
        }
        static void Main(string[] args)
        {
            Mystruct Location1 = new Mystruct();
            MyClass Employee1 = new MyClass();
            Console.WriteLine("Default values");
            Console.WriteLine("   Struct members:{0},{1}", Location1.x, Location1.y);
            Console.WriteLine("   class menbers:{0},{1}", Location1.x, Location1.y);
            Mystruct Location2 = new Mystruct(10, 20);
            MyClass Employee2 = new MyClass(1234, "JiangJun");
            Console.WriteLine("Assigned values:");
            Console.WriteLine("   Struct members:{0},{1}", Location2.x, Location2.y);
            Console.WriteLine("Class members:{0},{1}", Employee2.name, Employee2.ID);
            Console.ReadLine();
        }
    }
}
