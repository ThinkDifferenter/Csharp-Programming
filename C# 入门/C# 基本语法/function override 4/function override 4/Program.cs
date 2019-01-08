using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace function_override_4
{
    class myclass
    {
        public int i,j;
        public double a, b;
        public int func(int i, int j)
        {
            return i + j;
        }
        public double func(double a, double b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            myclass JJ = new myclass();//define JJ to represent myclass
            JJ.i = 123;
            JJ.j = 234;
            JJ.a = 12.3;
            JJ.b = 23.4;
            Console.WriteLine("the sum of i,j is {0}", JJ.func(JJ.i, JJ.j));
            Console.WriteLine("the sun of a,b is {0}", JJ.func(JJ.a,JJ.b));
            Console.ReadLine();
        }
    }
}
