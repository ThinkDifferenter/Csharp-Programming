using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 定义类
{
    class Myclass
    {
        public int a;
        protected double x = -36.52;
        public int intabs(int a)
        {
            return Math.Abs(a);
        }
        public Myclass()
        {
            Console.WriteLine("Constructor");
        }
        public double doubleabs(double x)
        {
            return Math.Abs(x);
        }
        public int S_a
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }

        }
        
    }
}
