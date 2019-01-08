using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace new_operator
{
    public class Newtest
    {
        struct Mystruct
        {
            public int x;
            public int y;
            public Mystruct(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        class Myclass
        {
            public string name;
            public int id;
            public Myclass()
            {
            }
            public Myclass(string name, int id)
            {
                this.name = name;
                this.id = id;
            }
        }


        public static void Main(string[] args)
        {
            Mystruct Location1 = new Mystruct();
            Myclass Employee1 = new Myclass();
            Console.WriteLine("Default value:");
            Console.WriteLine(" Struct menbers:{0},{1}", Location1.x, Location1.y);
            Console.WriteLine(" Class members:{0},{1}", Employee1.name, Employee1.id);
            Console.WriteLine("Assigned value:");
            Mystruct Location2 = new Mystruct(10, 20);
            Myclass Employee2 = new Myclass("jiangjun", 12345);
            Console.WriteLine(" Struct menbers:{0},{1}", Location2.x, Location2.y);
            Console.WriteLine(" Class members:{0},{1}", Employee2.name, Employee2.id);
            Console.ReadLine();
        }
    }
    
}
