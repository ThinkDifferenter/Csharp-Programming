using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inherit
{
    public class myclass1
    {
        public  int i = 123;
        public static  void show1()
        {
            Console.WriteLine("this is in the myclass1");
        }
    }
    public class myclass2:myclass1 
    {
        public  int j = 234;
        public static void show2()
        {
            Console.WriteLine("this is in the myclass2");
        }
    }
    class Program:myclass2
    {
        static void Main(string[] args)
        {
            int k = 345;
            Program.show1();
            Program.show2();
            Console.WriteLine("i+j+k={0}", Program.i + Program.j + k);
            Console.ReadLine();

        }
    }
}
