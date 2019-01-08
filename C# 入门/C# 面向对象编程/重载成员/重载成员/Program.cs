using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 重载成员
{
    class Program
    {
        public int a, b;
        public double x, y;
        public int fun(int a,int b)
        {
            return a + b;
        }
        public double  fun(double a,double b)//重载成员
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Program sd = new Program();
            sd.a = 156;
            sd.b = 32;
            sd.x = 23.45;
            sd.y = 56.49;
            Console.WriteLine("{0}+{1}={2}", sd.a, sd.b, sd.fun(sd.a, sd.b));
            Console.WriteLine("{0}+{1}={2}", sd.x, sd.y, sd.fun(sd.x, sd.y));
            Console.ReadLine();
        }

        
    }
}
