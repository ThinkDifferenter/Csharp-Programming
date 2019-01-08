using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 显式接口成员实现
{
    interface Imyinterface1
    {
        int add();
    }
    interface Imyinterface2
    {
        int add();
    }
    class Myclass : Imyinterface1, Imyinterface2
    {
        int Imyinterface1.add()
        {
            int x = 3;
            int y = 4;
            return x + y;
        }

        int Imyinterface2.add()
        {
            int x = 3;
            int y = 4;
            int z = 5;
            return x + y + z;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass myclass = new Myclass();
            Imyinterface1 imyinterface1 = myclass;
            Console.WriteLine(imyinterface1.add());
            Imyinterface2 imyinterface2 = myclass;
            Console.WriteLine(imyinterface2.add());
            Console.ReadLine();
        }
    }
}
