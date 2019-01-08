using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法重复调用
{
    class Program
    {
        static void F()
        {
            Console.WriteLine("F()");
        }
        static void F(object o)
        {
            Console.WriteLine("F(object)");
        }
        static void F(int value)
        {
            Console.WriteLine("F(int )");
        }
        static  void F(int a,int b)
        {
            Console.WriteLine("F(int ,int)");
        }
        static void F(int [] value)
        {
            Console.WriteLine("F(int [])");
        }
        static void Main(string[] args)
        {
            F();
            F(1);
            F((object)1);
            F(1, 2);
            F(new int[] { 1, 2, 3, 4 });
            Console.ReadLine();
        }
    }
}
